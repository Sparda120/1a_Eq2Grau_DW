using Eq2Grau.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eq2Grau.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// calcula das raizes de uma eq 2º grau
        /// </summary>
        /// <param name="A">parametro do x^2</param>
        /// <param name="B">parametro do x</param>
        /// <param name="C">parametro independente</param>
        /// <returns>vista</returns>
        public IActionResult Index( string A,string  B,string C){
            /*
            * Algoritmo:
            * 1- ler os parâmetros de A, B e C
            * 2- verificar se os parâmetros são válidos
            *   2.1- A, B e C são números
            *   2.2- A!=0
            * 3- se tudo estiver bem, posso fazer o cálculo
            *   3.1- calcular o DELTA
            *   3.2- se DELTA >=0, raízes reais
            *       3.2.1- calcular raízes reais
            *   3.3- se DELTA <0, raízes complexas conjugadas
            *       3.3.1- calcular raízes complexas conjugadas
            *   3.4- informar o utilizador das raízes calculadas
            * 
            * senão, notificar o utilizador de como corrigir o problema
            * 
            */

            //2.1
            if(!float.TryParse(A, out float a)){
                //A não é número
                //falta ainda gerar a mensagem de erro
                //para ajudar o utilizador a corrigir o problema
                return View();

            }
            if (!float.TryParse(B, out float b))
            {
                //B não é número
                //falta ainda gerar a mensagem de erro
                //para ajudar o utilizador a corrigir o problema
                return View();

            }
            if (!float.TryParse(C, out float c))
            {
                //C não é número
                //falta ainda gerar a mensagem de erro
                //para ajudar o utilizador a corrigir o problema
                return View();

            }
            //fica a faltar validar o 0 2.2


            //3.1
            float delta = b * b - 4 * a * c;

            //3.2
            if (delta>=0){
                //3.2.1
                float x1 = (-b + MathF.Sqrt(delta)) / (2 * a);
                float x2 = (-b - MathF.Sqrt(delta)) / (2 * a);

                //3.4
                ViewBag.X1 = x1;
                ViewBag.X2 = x2;

            }



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
