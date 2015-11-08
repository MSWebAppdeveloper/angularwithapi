using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ClickSOFT_Test.Portable.Database;
using System.Net;
using ClickSOFT_Test.Portable.Objects;
namespace ClickSOFT_Test.UI.Controllers
{
    [RoutePrefix("data")]
    public class DataController : ApiController
    {

        //
        // GET: /data/Subjects/
        [HttpGet]
        [Route("subjects")]
        public IHttpActionResult GetSubjects()
        {
            try
            {
                return Ok(Repository.GetSubjects());
            }
            catch
            {
                return BadRequest("Some error occured.");
            }

        }
        // GET: /data/Subject/id
        [HttpGet]
        [Route("subject/{id}")]
        public IHttpActionResult GetSubject(int id)
        {
            try
            {
                return Ok(Repository.GetSubjects().FirstOrDefault(x => x.Id == id));
            }
            catch
            {
                return BadRequest("Some error occured.");
            }
        }
        // GET: /data/items/
        [HttpGet]
        [Route("items")]
        public IHttpActionResult GetItems()
        {
            try
            {
                return Ok(Repository.GetItems());
            }
            catch
            {
                return BadRequest("Some error occured.");
            }
        }
        // GET: /data/subject/{id}/addsale
        [HttpPost]
        [Route("subject/{id}/addsale")]
        public IHttpActionResult AddSubjectSale(Sale data)
        {
            try
            {
                Repository.AddSale(data);
                return Ok(data);
            }
            catch
            {
                return BadRequest("Some error ocurred");
            }
        }
        // GET: /data/subject/{id}/sales"
        [HttpGet]
        [Route("subject/{id}/sales")]
        public IHttpActionResult GetSubjectSale(int id)
        {
            try
            {
                return Ok(Repository.GetSubjectSale(id));
            }
            catch
            {
                return BadRequest("Some error ocurred");
            }
        }
    }
}