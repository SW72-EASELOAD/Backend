using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        // Your custom authorization logic here
        // Example: Check if the user has a specific claim
        if (!context.HttpContext.User.HasClaim("YourClaimType", "YourClaimValue"))
        {
            context.Result = new UnauthorizedResult();
        }
    }
}