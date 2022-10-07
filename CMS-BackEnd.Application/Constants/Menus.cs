using CMS_BackEnd.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Constants
{
    public class Menus
    {
        public Dictionary<string, List<Menu>> menus;
        public Menus()
        {
            menus = new Dictionary<string, List<Menu>>();
            menus.Add("Admin", new List<Menu>
            {
                new Menu{Route="/app/announcements",Title="Announcements",Icon="announcement"},
                new Menu{Route="/app/attendaces",Title="Attendances",Icon="date_range"},
                new Menu{Route="/app/course",Title="Courses",Icon="collections_bookmark"},
                new Menu{Route="/app/staff",Title="Staffs",Icon="work"},
                new Menu{Route="/app/student",Title="Students",Icon="school"},
                new Menu{Route="/app/session-year",Title="Session Year",Icon="update"}
            });
            menus.Add("Manager", new List<Menu>
            {
                new Menu{Route="/app/attendaces",Title="Attendances",Icon="date_range"},
                new Menu{Route="/app/course",Title="Courses",Icon="collections_bookmark"}
            });
            menus.Add("Accountant", new List<Menu>
            {
                new Menu{Route="/app/income",Title="Income transations",Icon="attach_money"},
                new Menu{Route="/app/outcome",Title="Outcome transaction",Icon="attach_money"},
                new Menu{Route="/app/salary",Title="Salary Templates",Icon="attach_money"}
            });
            menus.Add("Receptionist", new List<Menu>
            {
                new Menu{Route="/app/announcements",Title="Announcements",Icon="announcement"},
                new Menu{Route="/app/attendaces",Title="Attendances",Icon="date_range"},
                new Menu{Route="/app/student",Title="Students",Icon="school"}
            });
        }
    }
}
