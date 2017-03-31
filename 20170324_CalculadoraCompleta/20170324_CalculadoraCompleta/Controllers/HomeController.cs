using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20170324_CalculadoraCompleta.Controllers
{
    public class HomeController : Controller{
        // GET: Home
        [HttpGet]
        public ActionResult Index(){
            //inicializar os dados a serem enviados para VIEW
            ViewBag.Visor = "0";

            //Invocar a VIEW
            return View();

        }

        // POST: Home
        [HttpPost]
        public ActionResult Index(string bt, string visor){

            switch (bt){
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (visor.Equals("0")) { visor = bt; }
                    else { visor += bt; } //visor=visor+bt;
                    break;
                //*******************************************************************
                case "+/-":
                    visor = Convert.ToDouble(visor) * -1 + ""; //FORMA MAIS CORRETA
                    //if (visor.StartsWith("-")) visor = visor.Replace("-", "");
                    //else visor = "-" + visor;
                    break;
                case ",":
                    if (!visor.Contains(",")) visor += ",";
                    break;
                case "C":
                    visor = "0";
                    break;
                //*******************************************************************
                //case "":
            }


            //Enviar dados para a VIEW
            ViewBag.Visor = visor;



            return View();

        }



    }
}