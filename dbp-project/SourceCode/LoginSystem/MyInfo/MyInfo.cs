using DeepCheeseBacon.SourceCode.ApprovalSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCheeseBacon.SourceCode

{
    public class MyInfo
    {
        public static MyInfo myInfo = new MyInfo();
        public int userId = 1;
        public string email = "test@gmail.com";
        public Role role = Role.Requester;

        public static MyInfo GetMyInfo() { return myInfo; }



    }
}
