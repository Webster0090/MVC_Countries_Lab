using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryMenuView
    {
        public static string UserPick()
        {
            Console.WriteLine("What contient would you like to learn about");
            string input = Console.ReadLine();
            return input;
        }

    }
}
