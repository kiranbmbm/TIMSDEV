using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tims.DataLayer
{
    public interface IApplicationRepository : IDisposable
    {
         List<Application> Retrieve();
    }
}
