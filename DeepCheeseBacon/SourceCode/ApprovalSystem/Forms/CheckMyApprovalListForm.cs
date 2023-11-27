using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using deepcheesebacon.SourceCode.ApprovalSystem;
using deepcheesebacon.SourceCode.ApprovalSystem.Models;
using deepcheesebacon.SourceCode.LoginSystem.MyInfo;

namespace deepcheesebacon
{
    public partial class CheckMyApprovalListForm : Form
    {
        int userId = 1; // 로그인 한 유저의 아이디 임시로 1로 설정
        ApprovalService approvalService;
        MyInfo myInfo = MyInfo.GetMyInfo();

        public CheckMyApprovalListForm()
        {
            InitializeComponent();
            approvalService = new ApprovalService();
        }

        private void CheckMyApprovalListForm_Load(object sender, EventArgs e)
        {
            LoadPendingApprovalList();
            LoadCompletedApprovalList();
            LoadTaskRequiringMyApprovalList();
            LoadMyApprovalProgressList();
        }

        // 내가 결재해야하는 업무 리스트 불러오기
        private void LoadTaskRequiringMyApprovalList()
        {
            List<Approval> approvals = approvalService.GetPendingApprovals
                (
                    new PendingApprovalRequest
                    {
                        userId = myInfo.userId,
                    }
                );

            listBoxTaskRequiringMyApprovalList.Items.Clear();

            foreach (Approval approval in approvals)
            {
                listBoxTaskRequiringMyApprovalList.Items.Add(approval.Title);
            }
        }

        // 결재 완료 내역
        private void LoadCompletedApprovalList()
        {
            List<Approval> approvals = approvalService.GetCompletedApprovals
                (
                    new PendingApprovalRequest
                    {
                        userId = myInfo.userId,
                    }
                );



            listBoxCompletedApprovalList.Items.Clear();

            foreach (Approval approval in approvals)
            {
                listBoxCompletedApprovalList.Items.Add(approval.Title);
            }
        }

        // 결재 중 내역 불러오기

        private void LoadPendingApprovalList()
        {
            List<Approval> approvals = approvalService.GetFirstApproverIsMe
                (
                    new PendingApprovalRequest
                    {
                        userId = myInfo.userId,
                    }
                );

            listBoxPendingApprovalList.Items.Clear();

            foreach (Approval approval in approvals)
            {
                string title = approval.Title;
                string status = "";
                switch (approval.Status)
                {
                    case Approval.ApprovalStatus.Approved:
                        status = "승인됨";
                        break;
                    case Approval.ApprovalStatus.Pending:
                        status = "승인 보류중";
                        break;
                    case Approval.ApprovalStatus.Rejected:
                        status = "반려됨";
                        break;
                }
                string statusText = $"결재 제목: {title} / 진행 상태: {status} ";

                listBoxPendingApprovalList.Items.Add(statusText);
            }

        }

        // 내가 등록한 결재들의 진행상황
        private void LoadMyApprovalProgressList()
        {
            List<Approval> approvals = approvalService.GetMyApproval
               (
                   new MyApprovalProgressRequest
                   {
                       userId = myInfo.userId,
                   }
               );

            listBoxMyApprovalProgressList.Items.Clear();

            foreach (Approval approval in approvals)
            {
                string title = approval.Title;
                string status = "";
                switch (approval.Status)
                {
                    case Approval.ApprovalStatus.Approved:
                        status = "승인됨";
                        break;
                    case Approval.ApprovalStatus.Pending:
                        status = "승인 보류중";
                        break;
                    case Approval.ApprovalStatus.Rejected:
                        status = "반려됨";
                        break;
                }
                string statusText = $"결재 제목: {title} / 진행 상태: {status} ";

                listBoxMyApprovalProgressList.Items.Add(statusText);
            }
        }


        private void buttonApproveApproval_Click(object sender, EventArgs e)
        {
            ApproveForm approveForm = new ApproveForm();
            approveForm.ShowDialog();
        }

        private void listBoxMyApprovalProgressList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
