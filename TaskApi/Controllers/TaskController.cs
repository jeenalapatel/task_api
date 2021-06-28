using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        //TaskId would be autoGenerated

        [HttpPost]
        public async Task<ActionResult> CreateTask(TaskModel model)
        {
        }


        [HttpGet]
        public async Task<ActionResult> GetAllTask()
        {
        }

        //will get data using emailId & TaskId
        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateTaskInfo(int id, TaskModel model)
        {
        }
        [HttpPost("{id:int}/subtask")]
        public async Task<ActionResult> CreateSubTask(SubTaskModel model)
        {
        }

        //make changes using SubTaskId
        [HttpPut("{id:int}/subtask/{id:int}")]
        public async Task<ActionResult> UpdateSubTaskInfo(int id, SubTaskModel model)
        {
        }

       
        
    }
}