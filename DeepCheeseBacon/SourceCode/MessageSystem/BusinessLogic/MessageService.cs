using deepcheesebacon.SourceCode.ApprovalSystem.DataAccess;
using deepcheesebacon.SourceCode.LoginSystem.MyInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace deepcheesebacon.SourceCode.MessageSystem.BusinessLogic
{
    internal class MessageService
    {
        MyInfo myInfo;
        DBManager dbManager;

        public MessageService()
        {
            myInfo = MyInfo.GetMyInfo();
            dbManager = DBManager.GetDBManager();
        }
        public List<string> GetChattingList()
        {
            Console.WriteLine("GetChattingList 실행");

            return dbManager.GetChattingListByUserId(myInfo.userId);
        }
    }
}
