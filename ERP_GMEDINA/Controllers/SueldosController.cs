﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA.Controllers
{				
	public class SueldosController : Controller
    {
        private ERP_GMEDINAEntities db = new ERP_GMEDINAEntities();

        // GET: /Sueldos/
        public ActionResult Index()        
		{           
            Session["Usuario"] = new tbUsuario { usu_Id = 1 };
            List<tbSueldos> tbSueldos = new List<tbSueldos> { };
            return View(tbSueldos);
        }

        public ActionResult llenarTabla()
        {
            try
            {
                using (db = new ERP_GMEDINAEntities())
                {
                    var tbsueldos = db.V_Sueldos
                        .Select(
                        t => new
                        {
                            Id = t.Id,
                            Identidad = t.Identidad,
                            Nombre = t.Nombre,
                            Sueldo = t.Sueldo,
                            Tipo_Moneda = t.Tipo_Moneda,
                            Cuenta = t.Cuenta                                                     
                        }

                        )
                        .ToList();
                    return Json(tbsueldos, JsonRequestBehavior.AllowGet);
                        
                }
            }
            catch
            {
                return Json("-2", JsonRequestBehavior.AllowGet);

            }
        }


        public ActionResult ChildRowData(int? id)
        {
            List<V_Sueldos> lista = new List<V_Sueldos> { };
            using (db = new ERP_GMEDINAEntities())
            {
                try
                {
                    lista = db.V_Sueldos.Where(x => x.Id == id).ToList();
                }
                catch
                {

                }
            }
            return Json(lista, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Details(int? id)
        {
            if (id== null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            tbSueldos tbSueldos = null;
            using (db = new ERP_GMEDINAEntities())
            {
                try
                {
                    tbSueldos = db.tbSueldos.Find(id);
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    
                }
            }
            if (tbSueldos == null)
            {
                return HttpNotFound();

            }
            return View(tbSueldos);
        }


        // POST: /Sueldos/Create

        public ActionResult Create()
        {
            List<tbSueldos> sueldos = new List<tbSueldos> { };
            ViewBag.sue_Id = new SelectList(sueldos, "sue_Id", "sue_Cantidad");
            return View();
        }


        [HttpPost]
        public ActionResult Create(tbSueldos tbsueldos, tbEmpleados tbempleados)
        {
            string msj = "";
            using (db = new ERP_GMEDINAEntities())

            {
                var usuario = (tbUsuario)Session["Usuario"];
                try
                {
                    var list = db.UDP_RRHH_tbSueldos_Insert(tbsueldos.emp_Id,
                                                            tbsueldos.tmon_Id,
                                                            tbsueldos.sue_Cantidad,
                                                            tbsueldos.sue_SueldoAnterior,
                                                            usuario.usu_Id,
                                                            DateTime.Now);

                    foreach (UDP_RRHH_tbSueldos_Insert_Result item in list)
                    {
                        msj = item.MensajeError + " ";
                    }
                }
                catch (Exception ex)
                {
                    msj = "-2";
                    ex.Message.ToString();
                }
            }

            return Json(msj.Substring(0, 2), JsonRequestBehavior.AllowGet);
        }

		// GET: /Sueldos//Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            tbSueldos tbSueldos = null;
            using (db = new ERP_GMEDINAEntities())
            {
                List <tbEmpleados> tbempleados = null;
            
                try
                {
                    tbSueldos = db.tbSueldos.Find(id);
                    tbempleados = db.tbEmpleados.ToList();
                    ViewBag.emp_Id = new SelectList(tbempleados, "emp_Id");
                 
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
                 }          
          if (tbSueldos == null)
                {
                    return HttpNotFound();

                }
                return View(tbSueldos);
        }
        // POST: /Sueldos/Edit/5
        [HttpPost]
        public ActionResult Edit(tbSueldos tbSueldos)
        {
            string msj = "";
            if (tbSueldos.sue_Id != 0 && tbSueldos.emp_Id != 0 && tbSueldos.tmon_Id != 0 && tbSueldos.sue_Cantidad !=0  && tbSueldos.sue_SueldoAnterior !=0)            
			{
                var id = (int)Session["id"];
                var Usuario = (tbUsuario)Session["Usuario"];
                try
                {
                    var list = db.UDP_RRHH_tbSueldos_Update(id, tbSueldos.emp_Id, tbSueldos.tmon_Id, tbSueldos.sue_Cantidad, tbSueldos.sue_SueldoAnterior, Usuario.usu_Id, DateTime.Now);
                    foreach (UDP_RRHH_tbSueldos_Update_Result item in list)
                    {
                        msj = item.MensajeError + " ";
                    }
                }
                catch (Exception ex)
                {
                    msj = "-2";
                    ex.Message.ToString();
                }
                Session.Remove("id");
            }
            else
            {
                msj = "-3";
            }            
            return Json(msj.Substring(0, 2), JsonRequestBehavior.AllowGet);
        }
		// GET: /Sueldos//Delete/5
        [HttpPost]
        public ActionResult Delete(tbSueldos tbSueldos)
        {
            string msj = "";
            if (tbSueldos.sue_Id != 0 && tbSueldos.sue_RazonInactivo != "")
            {
                var id = (int)Session["id"];
                var Usuario = (tbUsuario)Session["Usuario"];
                try
                {
                    var list = db.UDP_RRHH_tbSueldos_Delete(id, tbSueldos.sue_RazonInactivo, Usuario.usu_Id, DateTime.Now);
                    foreach (UDP_RRHH_tbSueldos_Delete_Result item in list)
                    {
                        msj = item.MensajeError + " ";
                    }
                }
                catch (Exception ex)
                {
                    msj = "-2";
                    ex.Message.ToString();
                }
                Session.Remove("id");
            }
            else
            {
                msj = "-3";
            }            
            return Json(msj.Substring(0, 2),JsonRequestBehavior.AllowGet);
        }
        protected tbUsuario IsNull(tbUsuario valor)
        {
            if (valor!=null)
            {
                return valor;
            }
            else
            {
                return new tbUsuario {usu_NombreUsuario="" };
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
