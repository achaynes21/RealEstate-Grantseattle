using InventoryERP.Core;
using InventoryERP.Services;
using InventoryERP.Services.Models;
using InventoryERP.Web.Models;
using InventoryERP.Web.ModelConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryERP.Web.ModelBuilders
{
    #region Sign-In

    public class SignInModelBuilder
    {
        public static void SignIn(SignInViewModel model, IAuthenticationService authenticationService, ModelStateDictionary modelState)
        {
            if (!authenticationService.LoginAsMember(model.Email, model.Password, model.RememberMe))
                modelState.AddModelError("ERROR", "Incorrect username/password.");
        }
    }

    #endregion
}