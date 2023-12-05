using System;
using System.Collections.Generic;
using System.Text;

namespace deepcheesebacon.SourceCode.ApprovalSystem.Models
{
    public class ApprovalRejectRequest
    {
        public int ApprovalId { get; set; }
        public string Memo { get; set; }
    }
}
