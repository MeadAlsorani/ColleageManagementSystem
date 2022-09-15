using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain.Common
{
    public class BaseModelClass
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }= DateTime.Now;
        public DateTime ModificationDate { get; set; }

    }
}
