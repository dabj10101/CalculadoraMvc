using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculadoraWeb.Models;

namespace CalculadoraWeb.Controllers
{
    public class HomeController : Controller
    {
        dbCalcEntities db = new dbCalcEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult total(int value1, int value2, String calc)
        {
            Resultado r = new Resultado();
           
            Calculadora c = new Calculadora();
            decimal total = 0;

            switch (calc)
            {
                case "+":
                    total = c.suma(value1, value2);
                        break;
                case "-":
                    total = c.resta(value1, value2);
                    break;
                case "*":
                    total = c.multiplicacion(value1, value2);
                    break;
                case "/":
                    total = c.division(value1, value2);
                    break;
                default:
                    total = 0;
                    break;

            }

            r.Resultados = total;
            return Content("Resultado:"+total );
            
        }

    }
}