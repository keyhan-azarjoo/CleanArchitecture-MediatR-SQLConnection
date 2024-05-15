using Core.commands;
using Core.Queries;
using Core.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController :  BaseController
    {

        

        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategory(int id)    
        {
            try
            {
                var query = new GetCategoryByIdQuery { Id = id };
                var result =await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
        {
            try
            {
                var query = new GetAllCategoriesQuery();
                var result =await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Post( CategoryAddVm request, CancellationToken cancellationToken)
        {
            try
            {
                var command = new AddCategoryCommand{Title = request.Title};
                var result =await _mediatr.Send(command);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> Put(int id, CategoryEditVm request, CancellationToken cancellationToken)
        {
            try
            {
                if (id != request.Id)
                {
                    return BadRequest();
                }

                var command = new EditCategoryCommand{ Title = request.Title,Id = request.Id};
                var result =await _mediatr.Send(command);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            try
            {
                var command = new DeleteCategoryCommand { Id = id };
                var result =await _mediatr.Send(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}




