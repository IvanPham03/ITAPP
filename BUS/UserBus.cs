using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace BUS
{
    public class UserBUS
    {
        private static UserBUS instance;

        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserBUS();
                }
                return instance;
            }

        }
        private UserBUS()
        {

        }
        public string Login(UserDTO user)
        {
           
            if (string.IsNullOrEmpty(user.PHONENUMBER) || string.IsNullOrEmpty(user.PASSWORD))
            {
                return "";
            }
            if (user.PASSWORD.Length < 8)
            {
                return "";
            }
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (!validateGuidRegex.IsMatch(user.PASSWORD.ToString()))
            {
                return "";
            }
            return DAO.UserDAO.Instance.checkLogin(user);
        }
    }
}
