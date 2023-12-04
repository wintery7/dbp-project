using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using deepcheesebacon.SourceCode.ApprovalSystem;
using deepcheesebacon.SourceCode.ApprovalSystem.Models;
using deepcheesebacon;

namespace deepcheesebacon
{
    public partial class CreateNewApprovalForm : Form
    {
        ApprovalService ApprovalService;
        List<(int, string)> firstApproverIdList;
        Dictionary<string, int> firstApprovalIdDict; // 딕셔너리 필드 추가
        LoginedUserInfo myinfo;

        public CreateNewApprovalForm()
        {
            InitializeComponent();
            ApprovalService = new ApprovalService();
            myinfo = LoginedUserInfo.GetMyInfo();
            SetApproverList();
        }

        private void SetApproverList()
        {
            firstApproverIdList = ApprovalService.GetFirstApproverIdList();

            comboBoxApproverList.Items.Clear();

            foreach ((int, string) email in firstApproverIdList)
            {
                comboBoxApproverList.Items.Add(email.Item2);
            }

            // List<(int, string)>을 딕셔너리로 변환
            firstApprovalIdDict = firstApproverIdList.ToDictionary(item => item.Item2, item => item.Item1);
        }

        private void buttonCreateApproval_Click(object sender, EventArgs e)
        {
            if (comboBoxApproverList.SelectedItem != null)
            {
                int selectedApproverId;
                if (firstApprovalIdDict.TryGetValue(comboBoxApproverList.SelectedItem.ToString(), out selectedApproverId))
                {

                    Console.WriteLine("title: " + textBoxApprovalTitle.Texts + " || content: " + textBoxApprovalDescription.Texts);

                    // 각 텍스트 박스의 텍스트 길이를 확인하여 비어 있는지 여부를 판단
                    if (string.IsNullOrEmpty(textBoxApprovalTitle.Texts) ||
                        string.IsNullOrEmpty(textBoxApprovalDescription.Texts))
                    {

                        MessageBox.Show("결재 제목과 내용 입력란을 채워주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    Approval approval = new Approval
                    {
                        Title = textBoxApprovalTitle.Texts,
                        Description = textBoxApprovalDescription.Texts,
                        RelatedTask = textBoxApprovalRelatedTask.Texts,
                        Comment = textBoxApprovalComment.Texts,
                        RoleStatus = Role.FirstApprover,
                        Status = Approval.ApprovalStatus.Pending,
                        ApproverId = selectedApproverId,
                        Memo = "",
                        FirstApproverId = 0,
                        SecondApproverId = 0,
                        ApprovalDate = DateTime.Now,
                        RequestId = myinfo.userId
                    };

                    if (ApprovalService.CreateApproval(approval) > 0)
                    {
                        textBoxApprovalTitle.ClearText();
                        textBoxApprovalDescription.ClearText();
                        textBoxApprovalRelatedTask.ClearText();
                        textBoxApprovalComment.ClearText();
                        

                        MessageBox.Show("결재 등록에 성공하였습니다.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Debug.WriteLine("등록된 결재를 승인할 승인자 ID: " + approval.ApproverId);
                    }
                    else
                    {
                        MessageBox.Show("결재 등록에 실패하였습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("선택한 결재자 ID를 찾을 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("결재자를 선택해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxApproverList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

