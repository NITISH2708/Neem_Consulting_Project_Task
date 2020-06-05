using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IDetails
    {

        string Email { get; set; }
        string password { get; set; }
        string confirmpassword { get; set; }
    }
}
