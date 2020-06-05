using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BLLModel : IDetails
    {
       
        public string _Email { get; set; }
        public string _confirmpassword { get; set; }
        public string _password { get; set; }
        public string confirmpassword
        {
            get
            {

                return _confirmpassword;
            }

            set
            {
                _confirmpassword = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
    }
}
