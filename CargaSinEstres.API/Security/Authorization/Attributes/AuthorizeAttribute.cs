using CargaSinEstres.API.Security.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CargaSinEstres.API.Security.Authorization.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    /// <summary>
    /// Attribute for authorizing access to a class or method based on specified roles.
    /// </summary>
    ///<remarks> Grupo 1: Carga sin estres </remarks>
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        /// <summary>
        /// Performs authorization based on the provided context.
        /// </summary>
        /// <param name="context">The context in which the authorization is performed.</param>
        public void OnAuthorization(AuthorizationFilterContext context)
        { 
            // Skip authorization if [AllowAnonymous] attribute is present
            if (context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any())
                return; 

            // Authorization process
            var company = (Company)context.HttpContext.Items["Company"];
            var client = (Client)context.HttpContext.Items["Client"];

            if (company == null || client == null)
            {
                context.Result = new JsonResult(new { message = "Unauthorized: Missing company or client information." })
                {
                    StatusCode = StatusCodes.Status401Unauthorized
                };
            }
        }
    }
}