using Microsoft.AspNetCore.Mvc;
using TasksApi.BL;
using TasksApi.Models.DTOModels;
using TasksApi.Models.Entities;

namespace TasksApi.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("Api")]
    public class TaskController : Controller
    {

        private readonly TasksSevice tasksSevice;

        public TaskController(TasksSevice _tasksSevice)
        {
            tasksSevice = _tasksSevice;
        }
        [HttpGet]
        [Produces("application/json")]
        public ActionResult ApiCheck()
        {
            return Ok("hello world");
        }

        [HttpGet]
        [Route("GetUsers")]
        [Produces("application/json")]
        public ActionResult GetUserById()
        {
            ResponseDTO<List<User>> res = new ResponseDTO<List<User>>();
            try
            {
                res.data = tasksSevice.GetUsersList();
                res.success = true;
                return Ok(res);
            }
            catch (Exception ex)
            {

                res.success = false;
                res.errorMessage = ex.Message;
                res.data = null;
                return BadRequest(res);
            }
        }
        [HttpGet]
        [Route("GetAllMession")]
        [Produces("application/json")]
        public ActionResult GetAllMession()
        {
            ResponseDTO<List<Mession>> res = new ResponseDTO<List<Mession>>();
            try
            {
                res.data = tasksSevice.GetAllMession();
                res.success = true;
                return Ok(res);
            }
            catch (Exception ex)
            {

                res.success = false;
                res.errorMessage = ex.Message;
                res.data = null;
                return BadRequest(res);
            }
        }

        [HttpGet]
        [Route("GetOpenMession")]
        [Produces("application/json")]
        public ActionResult GetOpenMession()
        {
            ResponseDTO<List<User>> res = new ResponseDTO<List<User>>();
            try
            {
                res.data = tasksSevice.GetOpenMession();
                res.success = true;
                return Ok(res);
            }
            catch (Exception ex)
            {

                res.success = false;
                res.errorMessage = ex.Message;
                res.data = null;
                return BadRequest(res);
            }
        }
        [HttpGet]
        [Route("GetOutOfTimeMession")]
        [Produces("application/json")]
        public ActionResult GetOutOfTimeMession()
        {
            ResponseDTO<List<Mession>> res = new ResponseDTO<List<Mession>>();
            try
            {
                res.data = tasksSevice.OutOfTimeMession();
                res.success = true;
                return Ok(res);
            }
            catch (Exception ex)
            {

                res.success = false;
                res.errorMessage = ex.Message;
                res.data = null;
                return BadRequest(res);
            }
        }

        [HttpPost]
        [Route("AddTask")]
        [Produces("application/json")]
        public ActionResult AddMession([FromBody] Mession mession)
        {
            ResponseDTO<bool> res = new ResponseDTO<bool>();
            try
            {
                res.data = tasksSevice.AddMession(mession);
                res.success = true;
                return Ok(res);
            }
            catch (Exception ex)
            {

                res.success = false;
                res.errorMessage = ex.Message;
                res.data = false;
                return BadRequest(res);
            }
        }

    }
}
