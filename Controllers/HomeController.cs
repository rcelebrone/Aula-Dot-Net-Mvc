using Aula_Asp_Net_Mvc.Models;
using System;
using System.Web.Mvc;

namespace Aula_Asp_Net_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private DateTime Agora;
        private Calendario ViewModel;

        public HomeController()
        {
            this.Agora = DateTime.Now;
        }

        public ActionResult Ontem()
        {
            //remove um dia de hoje
            this.Agora.AddDays(-1);

            //cria uma instancia do calendario passando como referencia a data que alteramos para ontem
            this.ViewModel = new Calendario(this.Agora);
            this.ViewModel.MensagemDoDia = "Acho que ontem choveu... Não me recordo :/";

            //retorna o objeto para a view 
            //*lembre-se que se retornar uma string, o método View() vai entender que é o nome da view
            return View(this.ViewModel);
        }

        public ActionResult Hoje()
        {
            throw new NotImplementedException();
        }

        public ActionResult Amanha()
        {
            throw new NotImplementedException();
        }
    }
}