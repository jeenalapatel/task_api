using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/{TaskId}")]
    public class SubTaskController:ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateMaterialType()
        {
            
        }
        //make changes using SubTaskId
        [HttpPut("{id:int}")]
        public async Task<ActionResult>UpdateSubTaskInfo(int id ,TaskModel model)
        {
            
        }
    }
}