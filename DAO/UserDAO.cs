using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }

        }
        public UserDAO()
        {
        }

        public string checkLogin(UserDTO user)
        {
            return (string) DataProvider.Instance.ExecuteScalar("Select role from users where phonenum = @phonenumber and password = @password", new object[] { user.PHONENUMBER, user.PASSWORD });
            
        }
    }
}
