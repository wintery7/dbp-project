using deepcheesebacon;
using System;
using System.Collections.Generic;
using System.Text;

namespace deepcheesebacon
{
    internal class MessageService
    {
        LoginedUserInfo myInfo;
        DBManager dbManager;

        public MessageService()
        {
            myInfo = LoginedUserInfo.GetMyInfo();
            dbManager = DBManager.GetInstance();
        }
        public List<string> GetChattingList()
        {
            Console.WriteLine("GetChattingList 실행");

            return dbManager.GetChattingListByUserId(myInfo.userId);
        }
    }
}
