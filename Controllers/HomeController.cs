using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Caso02.Models;

namespace Caso02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult dobleDescuento()
        {
            return View("dobleDescuento");
        }


        public ActionResult calculo()
        {
            Compra comp = new Compra();
            comp.cantidad = Convert.ToInt32(Request.Form["txtCantidad"]);
            comp.precio = Convert.ToDouble(Request.Form["txtPrecio"]);
            comp.primerDesc = (comp.cantidad * comp.precio) * 0.05;
            comp.segundoDesc = ((comp.cantidad * comp.precio) - comp.primerDesc) * 0.05;
            comp.totalDesc = comp.primerDesc + comp.segundoDesc;
            comp.total = (comp.cantidad * comp.precio) - comp.totalDesc;

            return View("DetallePago", comp);
        }

        //Segundo Caso
        public ActionResult sueldoTrabajador()
        {
            return View("sueldoTrabajador");
        }



        public ActionResult calculoTrabajador()
        {
            Trabajador trab = new Trabajador();
            //nroHijos - Comision - descuento - sueldo bruto - sueldo neto
            trab.nroHijos = Convert.ToInt32(Request.Form["txtNroHijos"]);
            trab.comision = Convert.ToDouble(Request.Form["txtComision"]) * 0.075;
            trab.sueldoBruto = 600 + (trab.nroHijos * 50) + trab.comision;
            trab.descuento = trab.sueldoBruto * 0.11;
            trab.sueldoNeto = trab.sueldoBruto - trab.descuento;


            return View("DetalleTrabajador", trab);
        }

        //Tercer Caso
        public ActionResult casoArroz()
        {
            return View("casoArroz");
        }

        public ActionResult calculoArroz()
        {

            //cantidad - tipo arroz - descuento - total 
            Venta vent = new Venta();
            vent.cantidad = Convert.ToInt32(Request.Form["txtCantidad"]);
            vent.tipoArroz = Convert.ToString(Request.Form["selectTipoArroz"]);
            //Costeño - Paisana del Norte - Tropical Superior - Norteño Superior
            if (vent.tipoArroz == "Costeño")
            {
                vent.total = vent.cantidad * 14.5;
            }
            else if (vent.tipoArroz == "Paisana del Norte")
            {
                vent.total = vent.cantidad * 12.6;

            }
            else if (vent.tipoArroz == "Tropical Superior")
            {
                vent.total = vent.cantidad * 10.0;

            }
            else if (vent.tipoArroz == "Tropical Superior")
            {
                vent.total = vent.cantidad * 12.8;
            }

            //Descuento  
            if (vent.total > 200)
            {
                vent.descuento = 0.12;
            }
            else if (vent.total >= 200 && vent.total < 400)
            {
                vent.descuento = 0.14;
            }
            else if (vent.total >= 400)
            {
                vent.descuento = 0.16;
            }
            vent.totalPagar = vent.total - (vent.total * vent.descuento);
            return View("DetallePagoArroz", vent);
        }

        //Actividad Alumno
        public ActionResult ingresoNotas()
        {
            return View("ingresoNotas");
        }

        public ActionResult detalleNotas()
        {
            Alumno alu = new Alumno();
            //codigo - nombre - curso - parcial - final - practica
            alu.codigo = Convert.ToInt32(Request.Form["txtCodigo"]);
            alu.nombre = Convert.ToString(Request.Form["txtNombre"]);
            alu.curso = Convert.ToString(Request.Form["selectCurso"]);
            alu.parcial = Convert.ToDouble(Request.Form["txtParcial"]);
            alu.final = Convert.ToDouble(Request.Form["txtFinal"]);
            alu.practica = Convert.ToDouble(Request.Form["txtPractica"]);
            //Lógica para saber si aprobó o no 
            alu.promedio = (alu.parcial * 0.5) + (alu.final * 0.3) + (alu.practica * 0.2);
            //parcial 5 / final 3 / practica 2
            if (alu.promedio >= 13)
            {
                alu.estado = "Aprobado";
            }
            else
            {
                alu.estado = "Desaprobado";
            }

            return View("detalleNotas", alu);
        }


    }
}