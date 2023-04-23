using System.Data;

namespace DTO
{
    public class UserDTO
    {
        public UserDTO() { }    
   
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string ROLE { get; set; }
        public string PHONENUMBER { get; set; }
        public string CREATEAT { get; set; }
        public string UPDATEAT { get; set; }

    }
}