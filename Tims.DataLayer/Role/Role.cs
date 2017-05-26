using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tims.DataLayer.Application
{
    public class Role
    {
        public int roleId { get; set; }
        public int applicationId { get; set; }
        public string actionType { get; set; }
        public int amendmentUserId { get; set; }
        public string effectiveDate { get; set; }
    }
}
