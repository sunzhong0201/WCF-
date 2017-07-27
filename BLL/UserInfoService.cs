using IBLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserInfoService:IUserInfoService
    {

        #region IUserInfoService 成员

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }

        #endregion

        #region IUserInfoService 成员


        public Models.UserInfo GetUserInfo()
        {
            UserInfo userinfo = new UserInfo();
            userinfo.Email = "usaqq1@163.com";
            userinfo.id = 1;
            userinfo.userName = "sunzhong";
            userinfo.Gender = 1;
            return userinfo;
        }

        #endregion
    }
}
