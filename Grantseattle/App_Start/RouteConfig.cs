using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace InventoryERP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            #region Route for PropertyListing Controller
            routes.MapRoute(
                          name: "MakePropertyPurpose",
                          url: "Create-Property-Purpose",
                          defaults: new { controller = "PropertyListing", action = "MakePropertyPurpose" }
                      );
            routes.MapRoute(
                          name: "MakePropertyLocation",
                          url: "Make-Property-Location",
                          defaults: new { controller = "PropertyListing", action = "MakePropertyLocation" }
                      );

            routes.MapRoute(
                          name: "CreatePropertyType",
                          url: "Create-PropertyType",
                          defaults: new { controller = "PropertyListing", action = "CreatePropertyType" }
                      );
            routes.MapRoute(
                          name: "PropertyTypeList",
                          url: "PropertyType-List",
                          defaults: new { controller = "PropertyListing", action = "PropertyTypeList" }
                      );
            routes.MapRoute(
                          name: "PropertyTypeDetails",
                          url: "PropertyType-Details",
                          defaults: new { controller = "PropertyListing", action = "PropertyTypeDetails" }
                      );
            routes.MapRoute(
                         name: "PropertyTypeDelete",
                         url: "PropertyType-Delete",
                         defaults: new { controller = "PropertyListing", action = "PropertyTypeDelete" }
                     );
            routes.MapRoute(
                         name: "PropertyRegistration",
                         url: "Property-Registration",
                         defaults: new { controller = "PropertyListing", action = "PropertyRegistration" }
                     );
            routes.MapRoute(
                          name: "IndexPropertyListing",
                          url: "DefaultMethod",
                          defaults: new { controller = "PropertyListing", action = "Index" }
                      );



            routes.MapRoute(
                         name: "GetPropertyModelView",
                         url: "GetPropertyModelView",
                         defaults: new { controller = "PropertyListing", action = "GetPropertyModelView" }
                     );
            routes.MapRoute(
                         name: "FinallyPropertySave",
                         url: "FinallyPropertySave",
                         defaults: new { controller = "PropertyListing", action = "FinallyPropertySave" }
                     );
            #endregion
            #region Routes for News Controlller
            routes.MapRoute(
               name: "PublishNews",
               url: "Publish-News",
               defaults: new { controller = "NewsPortal", action = "PublishNews" }
           );
            routes.MapRoute(
               name: "NewsList",
               url: "News-List",
               defaults: new { controller = "NewsPortal", action = "NewsList" }
           );
            routes.MapRoute(
               name: "Edit",
               url: "Edit",
               defaults: new { controller = "NewsPortal", action = "Edit" }
           );
            routes.MapRoute(
               name: "details",
               url: "details",
               defaults: new { controller = "NewsPortal", action = "details" }
           );
            routes.MapRoute(
               name: "Delete",
               url: "Delete",
               defaults: new { controller = "NewsPortal", action = "Delete" }
           );

            #endregion

            #region Routes for Agent Controlller
            routes.MapRoute(
               name: "Create",
               url: "Create-Agent",
               defaults: new { controller = "Agent", action = "Create" }
           );
            routes.MapRoute(
               name: "AgentList",
               url: "Agent-List",
               defaults: new { controller = "Agent", action = "AgentList" }
           );
            // routes.MapRoute(
            //    name: "Edit",
            //    url: "Agent-Edit",
            //    defaults: new { controller = "Agent", action = "Edit" }
            //);
            routes.MapRoute(
               name: "AgentDetails",
               url: "Agent-Details",
               defaults: new { controller = "Agent", action = "Details" }
           );
            routes.MapRoute(
               name: "AgentDelete",
               url: "Agent-Delete",
               defaults: new { controller = "Agent", action = "Delete" }
           );
            #endregion

            #region Routes for Item Controlller

            routes.MapRoute(
               name: "CreateItem",
               url: "create-item",
               defaults: new { controller = MVC.Item.Name, action = MVC.Item.ActionNames.CreateItem }
           );

            routes.MapRoute(
               name: "ItemList",
               url: "items",
               defaults: new { controller = MVC.Item.Name, action = MVC.Item.ActionNames.ViewItems }
           );

            #endregion

            #region Routes for Account Controller

            routes.MapRoute(
                name: "LogInWithFacebook",
                url: "log-in-with-facebook",
                defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.LogInWithFacebook }
            );

            routes.MapRoute(
                name: "SignUpWithFacebook",
                url: "sign-up-with-facebook",
                defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.SignUpWithFacebook }
            );

            routes.MapRoute(
                name: "EmailExist",
                url: "email-exist",
                defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.EmailExist }
            );

            routes.MapRoute(
                name: "SignUp",
                url: "sign-up",
                defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.SignUp }
            );


            routes.MapRoute(
                name: "SignIn",
                url: "",
                defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.SignIn }
            );

            routes.MapRoute(
                name: "SignOut",
                url: "sign-out",
                defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.SignOut }
            );

            routes.MapRoute(
                name: "ForgotPassword",
                url: "forgot-password",
                defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.ForgotPassword }
            );

            //routes.MapRoute(
            //    name: "EmailConfirmation",
            //    url: "confirm-email",
            //    defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.EmailConfirmation }
            //);

            //routes.MapRoute(
            //    name: "ResetPassword",
            //    url: "reset-password",
            //    defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.ResetPassword }
            //);

            //routes.MapRoute(
            //    name: "reset-password",
            //    url: "reset-password",
            //    defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.ResetPassword, code = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "confirm-email",
            //    url: "confirm-email",
            //    defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.EmailConfirmation }
            //);

            #endregion

            #region Routes for Home Controller

            routes.MapRoute(
                name: "Index",
                url: "home",
                defaults: new { controller = MVC.Home.Name, action = MVC.Home.ActionNames.Index }
            );

            //routes.MapRoute(
            //    name: "Help",
            //    url: "help",
            //    defaults: new { controller = MVC.Home.Name, action = MVC.Home.ActionNames.Help }
            //);

            routes.MapRoute(
                name: "About",
                url: "about-job-vizz",
                defaults: new { controller = MVC.Home.Name, action = MVC.Home.ActionNames.About }
            );

            //routes.MapRoute(
            //    name: "TermsOfUse",
            //    url: "terms-of-use",
            //    defaults: new { controller = MVC.Home.Name, action = MVC.Home.ActionNames.TermsOfUse }
            //);

            //routes.MapRoute(
            //    name: "PrivacyPolicy",
            //    url: "privacy-policy",
            //    defaults: new { controller = MVC.Home.Name, action = MVC.Home.ActionNames.PrivacyPolicy }
            //);


            #endregion

            routes.MapRoute(
                name: "Default",
                url: "log-in",
                defaults: new { controller = MVC.Account.Name, action = MVC.Account.ActionNames.SignIn }
            );

            routes.MapRoute(
               name: "404",
               url: "404",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
