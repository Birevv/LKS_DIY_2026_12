using LKS_DIY_2026_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_DIY_2026_12.Helpers
{
    public class SessionHelper
    {
        public static users currentUser { get; set; }

        public bool IsLoggedIn()
        {
            return currentUser != null;
        }
        public static void Logout()
        {
            currentUser = null;
        }
    }
}
