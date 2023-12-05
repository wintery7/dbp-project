using System;
using System.Collections.Generic;
using System.Text;

namespace deepcheesebacon
{
    public class User
    {
        public int UserId { get; set; } // 사용자 식별자
        public string Password { get; set; } // 사용자 비밀번호
        public string Username { get; set; } // 사용자 이름
        public string Email { get; set; } // 사용자 이메일
        public string Department { get; set; } // 부서 또는 부서 식별자
        public Role UserRole { get; set; } // 사용자 역할


    }

}
