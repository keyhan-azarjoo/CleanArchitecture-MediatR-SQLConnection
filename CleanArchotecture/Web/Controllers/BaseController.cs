using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

    public class BaseController : ControllerBase
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediatr
        {
            get => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();
        }


        //public  ActionResult customOk(object data = null, string message = "")
        //{
        //    return  Ok(new Result()
        //    {
        //        Message = message,
        //        Data = data,
        //        Status = Status.Success
        //    });
        //}
        //public ActionResult customError(object data = null, string message = "")
        //{
        //    return BadRequest(new Result()
        //    {
        //        Message = message,
        //        Data = data,
        //        Status = Status.Failed
        //    });
        //}
    }



    //public class Result
    //{
    //    public object Data { get; set; }
    //    public Status Status {get; set; }
    //    public string Message { get; set; }
    //}

    //public enum Status
    //{
    //    Success = 1,
    //    Failed = -1
    //}

