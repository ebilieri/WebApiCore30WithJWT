﻿using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace WebApiCore30WithJWT.CustomClaims
{
    public class CustomAuthorization
    {
        public static bool ValidarClaimsUsuario(HttpContext context, string claimName, string claimValue)
        {
            return context.User.Identity.IsAuthenticated &&
                context.User.Claims.Any(c => c.Type == claimName && c.Value.Split(',').Contains(claimValue));
        }
    }       
}
