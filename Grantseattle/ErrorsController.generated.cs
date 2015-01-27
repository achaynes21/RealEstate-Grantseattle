// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace InventoryERP.Web.Controllers
{
    public partial class ErrorsController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ErrorsController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ErrorsController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Http404()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Http404);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Http404ForSubscription()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Http404ForSubscription);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Http500()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Http500);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ErrorsController Actions { get { return MVC.Errors; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Errors";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Errors";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Http404 = "Http404";
            public readonly string Http404ForSubscription = "Http404ForSubscription";
            public readonly string Http500 = "Http500";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Http404 = "Http404";
            public const string Http404ForSubscription = "Http404ForSubscription";
            public const string Http500 = "Http500";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string error = "error";
        }
        static readonly ActionParamsClass_Http404 s_params_Http404 = new ActionParamsClass_Http404();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Http404 Http404Params { get { return s_params_Http404; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Http404
        {
            public readonly string error = "error";
        }
        static readonly ActionParamsClass_Http404ForSubscription s_params_Http404ForSubscription = new ActionParamsClass_Http404ForSubscription();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Http404ForSubscription Http404ForSubscriptionParams { get { return s_params_Http404ForSubscription; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Http404ForSubscription
        {
            public readonly string error = "error";
        }
        static readonly ActionParamsClass_Http500 s_params_Http500 = new ActionParamsClass_Http500();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Http500 Http500Params { get { return s_params_Http500; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Http500
        {
            public readonly string error = "error";
            public readonly string errorCode = "errorCode";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ErrorsController : InventoryERP.Web.Controllers.ErrorsController
    {
        public T4MVC_ErrorsController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string error);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(string error)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "error", error);
            IndexOverride(callInfo, error);
            return callInfo;
        }

        [NonAction]
        partial void Http404Override(T4MVC_System_Web_Mvc_ActionResult callInfo, string error);

        [NonAction]
        public override System.Web.Mvc.ActionResult Http404(string error)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Http404);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "error", error);
            Http404Override(callInfo, error);
            return callInfo;
        }

        [NonAction]
        partial void Http404ForSubscriptionOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string error);

        [NonAction]
        public override System.Web.Mvc.ActionResult Http404ForSubscription(string error)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Http404ForSubscription);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "error", error);
            Http404ForSubscriptionOverride(callInfo, error);
            return callInfo;
        }

        [NonAction]
        partial void Http500Override(T4MVC_System_Web_Mvc_ActionResult callInfo, string error, string errorCode);

        [NonAction]
        public override System.Web.Mvc.ActionResult Http500(string error, string errorCode)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Http500);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "error", error);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "errorCode", errorCode);
            Http500Override(callInfo, error, errorCode);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
