using deepcheesebacon.SourceCode.ApprovalSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace deepcheesebacon

{
    public class LoginedUserInfo
    {
        public static LoginedUserInfo loginedUserInfo = new LoginedUserInfo();
        public int userId = 1;
        public string email = "test";
        public Role role = Role.Requester;

        public static LoginedUserInfo GetMyInfo() { return loginedUserInfo; }



    }
}
