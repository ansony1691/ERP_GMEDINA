﻿using ERP_GMEDINA.Helpers;
using ERP_GMEDINA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ERP_GMEDINA.Attribute
{
    public class SessionManager : ActionFilterAttribute
    {
        private readonly string _screenId;
        Models.Helpers General = new Models.Helpers();
        public SessionManager()
        {
        }

        public SessionManager(string screenId)
        {
            _screenId = screenId;            
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var valuesSinAcceso = new RouteValueDictionary(new{action = "SinAcceso", controller = "Login"});
            var valuesSinRol = new RouteValueDictionary(new { action = "SinRol", controller = "Login" });
            var valuesIndex = new RouteValueDictionary(new { action = "Index", controller = "Login" });
            var valuesCambiarPass = new RouteValueDictionary(new { action = "ModificarPass/" + HttpContext.Current.Session["UserLogin"], controller = "Usuario" });

            if (General.GetUserLogin())
            {
                if (_screenId != "Usuario/ModificarPass")
                {
                    if (General.Sesiones(_screenId))
                    {
                        if (General.GetRol())
                        {
                            if (_screenId != "Menu/Index")
                            {
                                if (!General.GetUserRols(_screenId))
                                    filterContext.Result = new RedirectToRouteResult(valuesSinAcceso);
                            }
                        }
                        else
                            filterContext.Result = new RedirectToRouteResult(valuesSinRol);
                    }
                    else
                    {
                        filterContext.Result = new RedirectToRouteResult(valuesCambiarPass);
                    }
                }
            }
            else
                filterContext.Result = new RedirectToRouteResult(valuesIndex);
        }
		
    }

}