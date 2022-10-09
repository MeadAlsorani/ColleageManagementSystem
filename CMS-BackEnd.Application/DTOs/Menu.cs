using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs
{
    public class Menu
    {
        public Menu()
        {
            this.Actions = new List<string>();
        }
        public string Title { get; set; }
        public string Route { get; set; }
        public string Icon { get; set; }
        public List<string> Actions { get; set; }
    }
}
