using System;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Barbershop;

namespace Курсач
{
    public interface User
    {
        string UserName { get; set; }
        string UserPhone { get; set; }
    }
}
