using AutoMapper;
using HashWebApi.ModelsDTO;
using Microsoft.AspNetCore.Mvc;

namespace HashWebApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IMapper m_mapper;
        
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserCreationParamsDTO userCreationParams)
        {
            #region Pre-Conditions

            if (userCreationParams == null)
                return BadRequest(new ErrorDTO($"{nameof(userCreationParams)} cannot be null."));

            #endregion


            return Ok(); //TODO: Change http response to Created();
        }

        /// <summary>
        /// Working
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/{userId}/send-email-confirmation")]
        public IActionResult SendEmailConfirmationCode([FromRoute] string userId)
        {
            #region Pre-Conditions

            if (string.IsNullOrEmpty(userId))
                return BadRequest(new ErrorDTO($"{nameof(userId)} cannot be null."));

            #endregion

            try
            {

            }
            catch (Exception ex)
            {

            }

            return Ok();
        }

        [HttpPost]
        [Route("/{userId}/check-email-confirmation")]
        public IActionResult CheckEmailConfirmationCode([FromRoute] string userId, [FromBody] string emailConfirmationCode)
        {
            #region Pre-Conditions

            if (string.IsNullOrEmpty(userId))
                return BadRequest(new ErrorDTO($"{nameof(userId)} cannot be null."));

            if (string.IsNullOrEmpty(emailConfirmationCode))
                return BadRequest(new ErrorDTO($"{nameof(emailConfirmationCode)} cannot be null."));

            #endregion

            try
            {

            }
            catch (Exception ex)
            {

            }

            return Ok();
        }
    }
}
