﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tims.DataLayer
{
    public class User
    {
        public int userId { get; set; }
        public int systemId { get; set; }
        public string passKey { get; set; }
        public string actionType { get; set; }
        public int amendmentUserId { get; set; }
        public string effectiveDate { get; set; }

    }
}
