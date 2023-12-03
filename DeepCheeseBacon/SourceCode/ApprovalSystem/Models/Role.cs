using System;
using System.Collections.Generic;
using System.Text;

namespace deepcheesebacon

{
    public enum Role // 직급 
    {
        Requester, // 결제 요청자
        FirstApprover, // 1차 승인자
        SecondApprover, // 2차 승인자
        Approved // 최종 승인된 상태 이건 직급 아님 
    }
}
