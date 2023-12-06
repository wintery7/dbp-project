using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using deepcheesebacon.SourceCode.ApprovalSystem;
using deepcheesebacon.SourceCode.ApprovalSystem.Models;
using deepcheesebacon;
using WebSocketSharp;

namespace deepcheesebacon
{

    public partial class ApproveForm : Form
    {
        ApprovalService approvalService = new ApprovalService();
        LoginedUserInfo myInfo;
        List<Approval> pendingApprovalList;
        List<(int, string)> secondApproverIdList;

        public ApproveForm()
        {
            InitializeComponent();
            myInfo = LoginedUserInfo.GetMyInfo();
            LoadTaskRequiringMyApprovalList();
            SetLabelDateTime();
            SetNextApproverList();
        }

        private void SetNextApproverList()
        {
            secondApproverIdList = approvalService.GetFirstApproverIdList();

            comboBoxNextApproverList.Items.Clear();

            foreach ((int, string) email in secondApproverIdList)
            {
                comboBoxNextApproverList.Items.Add(email.Item2);
            }
        }


        private void SetLabelDateTime()
        {
            labelDateTime.Text = "결재 시각: " + DateTime.Now.ToString();
        }

        // 내가 결재해야하는 업무 리스트 불러오기
        private void LoadTaskRequiringMyApprovalList()
        {
            listBoxTaskRequiringMyApprovalList.Items.Clear();

            pendingApprovalList = approvalService.GetPendingApprovals(new PendingApprovalRequest
            {
                userId = myInfo.userId,
            });

            foreach (Approval approval in pendingApprovalList)
            {
                listBoxTaskRequiringMyApprovalList.Items.Add(approval);
            }
        }

        private void buttonApproveApproval_Click(object sender, EventArgs e)
        {
            if (listBoxTaskRequiringMyApprovalList.SelectedIndex == -1)
            {
                MessageBox.Show("결재하실 목록을 선택해주세요");
                return;
            }

            if(comboBoxNextApproverList.SelectedIndex == -1 && LoginedUserInfo.loginedUserInfo.role != Role.SecondApprover)
            {
                MessageBox.Show("다음 결재자를 선택해주세요");
                return;
            }

            Approval selectedApproval = null;

            foreach (Approval approval in pendingApprovalList)
            {
                if (approval.Id.Equals(((Approval)listBoxTaskRequiringMyApprovalList.SelectedItem).Id))
                {
                    selectedApproval = approval;
                }

            }

            if (selectedApproval != null)
            {
                if (!textBoxComment.Text.IsNullOrEmpty())
                {
                    if (selectedApproval.Comment.IsNullOrEmpty())
                    {
                        selectedApproval.Comment = $"{LoginedUserInfo.loginedUserInfo.email}: " + textBoxComment.Text + "\n";
                        
                    }
                    else
                    {
                        selectedApproval.Comment += $"{LoginedUserInfo.loginedUserInfo.email}: " + textBoxComment.Text + "\n";
                    }
                }
                ApprovalApproveRequest approvalApproveRequest = new ApprovalApproveRequest();
                approvalApproveRequest.approval = selectedApproval;
                if(comboBoxNextApproverList.SelectedIndex != -1)
                {
                    approvalService.ApproveRequest(new ApprovalApproveRequest()
                    {
                        
                        approval = selectedApproval,
                        nextApproverEmail = comboBoxNextApproverList.SelectedItem.ToString()
                    });
                }
                else
                {
                    approvalService.ApproveRequest(
                    new ApprovalApproveRequest()
                    {
                        approval = selectedApproval,

                    });
                }

                
                textBoxComment.Clear();
                listBoxTaskDetail.Items.Clear();
                MessageBox.Show("결재완료되었습니다");
                LoadTaskRequiringMyApprovalList();
            }
            else
            {
                MessageBox.Show("문제가 발생하였습니다.");
            }

            LoadTaskRequiringMyApprovalList();
            SetLabelDateTime();


        }

        public class PendingApprovalItem
        {
            public string Title { get; set; }
            public int ApprovalId { get; set; }

            public override string ToString()
            {
                return Title;
            }

            public PendingApprovalItem(string title, int approvalId)
            {
                Title = title;
                ApprovalId = approvalId;
            }
        }

        private void buttonRejectApproval_Click(object sender, EventArgs e)
        {
            if (listBoxTaskRequiringMyApprovalList.SelectedIndex == -1)
            {
                MessageBox.Show("반려하실 결재를 선택해주세요");
                return;
            }

            RejectForm rejectForm = new RejectForm();
            int approvalId;
            string memo;

            if (rejectForm.ShowDialog() == DialogResult.OK)
            {
                // 사용자가 폼에서 OK 버튼을 눌렀을 때 메모를 가져옴
                memo = rejectForm.GetMemo(); // GetMemo는 RejectForm에서 메모를 반환하는 메서드로 가정
                approvalId = ((Approval)listBoxTaskRequiringMyApprovalList.SelectedItem).Id;
                approvalService.RejectRequest(new ApprovalRejectRequest()
                {
                    ApprovalId = approvalId,
                    Memo = memo
                });
                LoadTaskRequiringMyApprovalList();
                MessageBox.Show("반려되었습니다");
            }

            LoadTaskRequiringMyApprovalList();
            SetLabelDateTime();

        }

        private void listBoxTaskRequiringMyApprovalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTaskRequiringMyApprovalList.SelectedIndex != -1)
            {
                Approval? approval = listBoxTaskRequiringMyApprovalList.SelectedItem as Approval;

                if (approval != null)
                {
                    listBoxTaskDetail.Items.Clear();

                    listBoxTaskDetail.Items.Add($"Title: {approval.Title}");
                    listBoxTaskDetail.Items.Add($"Description: {approval.Description}");
                    listBoxTaskDetail.Items.Add($"Comment: {approval.Comment}");
                    listBoxTaskDetail.Items.Add($"Related Task: {approval.RelatedTask}");
                    if (!approval.Memo.IsNullOrEmpty())
                    {
                        listBoxTaskDetail.Items.Add($"반려 메모: {approval.Memo}");
                    }
                }

            }
        }
    }
}
