using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Tims.DataLayer; 

namespace Tims.WebAPI.Controllers
{
    //[RoutePrefix("api/Application")]
    public class ApplicationController : ApiController
    {
        readonly Tims.DataLayer.IApplicationRepository _repository;
        ////////////////////////////
        /// 
        /// Controller Constructor
        /// 
        ///////////////////////////

        public ApplicationController():
            this(new Tims.DataLayer.ApplicationRepository())
        {

        }
        public ApplicationController(Tims.DataLayer.IApplicationRepository Repository)
        {
            _repository = Repository;
        }
        public IEnumerable<Application> Get()
        {
            //return Ok(_repository.Retrieve());
            return _repository.Retrieve().ToList<Application>();
        }
    }
}