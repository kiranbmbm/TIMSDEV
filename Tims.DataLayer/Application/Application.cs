using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tims.DataLayer
{
    public class Application
    {
        public int id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string description { get; set; }
        public int securedId { get; set; }
        public int ClientId { get; set; }
        public string clientAccess { get; set; }
        public int changeManagemenId { get; set; }
        public int availabilityId { get; set; }
        public string relatedId { get; set; }
        public int statusId { get; set; }
        public int sourceCodeRepositoryId { get; set; }
        public string sourceCodePath { get; set; }
        public string actionType { get; set; }
        public int amendmentUserId { get; set; }
        public string effectiveDate { get; set; }

    }
}
