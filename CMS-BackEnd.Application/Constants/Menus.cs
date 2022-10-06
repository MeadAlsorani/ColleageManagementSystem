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
                new Menu{Route="/announcement",Title="Announcements"},
                new Menu{Route="/attendaces",Title="Attendances"},
                new Menu{Route="/course",Title="Courses"},
                new Menu{Route="/staff",Title="Staffs"},
                new Menu{Route="/student",Title="Students"},
                new Menu{Route="/session-year",Title="Session Year"}
            });
            menus.Add("Manager", new List<Menu>
            {
                new Menu{Route="/attendaces",Title="Attendances"},
                new Menu{Route="/course",Title="Courses"}
            });
            menus.Add("Accountant", new List<Menu>
            {
                new Menu{Route="/income",Title="Income transations"},
                new Menu{Route="/outcome",Title="Outcome transaction"},
                new Menu{Route="/salary",Title="Salary Templates"}
            });
            menus.Add("Receptionist", new List<Menu>
            {
                new Menu{Route="/announcement",Title="Announcements"},
                new Menu{Route="/attendaces",Title="Attendances"},
                new Menu{Route="/student",Title="Students"}
            });
        }
    }
}
