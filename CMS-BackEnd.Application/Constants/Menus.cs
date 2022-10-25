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
                new Menu{Route="/app/home",Title="Home",Icon="dashboard",Actions=new List<string>{} },
                new Menu{Route="/app/announcements",Title="Announcements",Icon="announcement",Actions=new List<string>{"add","edit","delete" } },
                new Menu{Route="/app/attendances",Title="Attendances",Icon="date_range" },
                new Menu{Route="/app/course",Title="Courses",Icon="collections_bookmark",Actions=new List<string>{"add","edit","delete" } },
                new Menu{Route="/app/staff",Title="Staffs",Icon="work",Actions=new List<string>{"add","edit","delete" } },
                new Menu{Route="/app/student",Title="Students",Icon="school",Actions=new List<string>{"add","edit","delete" } },
                new Menu{Route="/app/session-year",Title="Session Year",Icon="update",Actions=new List<string>{"add","edit","delete" } }
            });
            menus.Add("Manager", new List<Menu>
            {
                new Menu{Route="/app/home",Title="Home",Icon="dashboard",Actions=new List<string>{} },
                new Menu{Route="/app/attendances",Title="Attendances",Icon="date_range",Actions=new List<string>{} },
                new Menu{Route="/app/course",Title="Courses",Icon="collections_bookmark",Actions=new List<string>{"add","edit","delete" } },
                new Menu{Route="/app/announcements",Title="Announcements",Icon="announcement",Actions=new List<string>{"add" } },
                new Menu{Route="/app/session-year",Title="Session Year",Icon="update",Actions=new List<string>{"add"} }
            });
            menus.Add("Accountant", new List<Menu>
            {
                new Menu{Route="/app/home",Title="Home",Icon="dashboard",Actions=new List<string>{} },
                new Menu{Route="/app/income",Title="Income transactions",Icon="attach_money",Actions=new List<string>{"add","edit" } },
                new Menu{Route="/app/outcome",Title="Outcome transaction",Icon="attach_money",Actions=new List<string>{"add","edit" } },
                new Menu{Route="/app/salary",Title="Salary Templates",Icon="attach_money",Actions=new List<string>{"add","edit","delete" } }
            });
            menus.Add("Reciptionist", new List<Menu>
            {
                new Menu{Route="/app/home",Title="Home",Icon="dashboard",Actions=new List<string>{} },
                new Menu{Route="/app/announcements",Title="Announcements",Icon="announcement",Actions=new List<string>{"add","edit","delete" } },
                new Menu{Route="/app/attendances",Title="Attendances",Icon="date_range",Actions=new List<string>{"add", "delete" } },
                new Menu{Route="/app/student",Title="Students",Icon="school",Actions=new List<string>{"add","edit","delete" } }
            });
        }
    }
}
