using System;
using System.Collections.Generic;
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
            string rs = (string) DataProvider.Instance.ExecuteScalar("Select username from users where phonenumber = @phonenumber and password = @password", new object[] { user.PHONENUMBER, user.PASSWORD });
            return rs;
        }
    }
}
