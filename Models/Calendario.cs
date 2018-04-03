using System;

namespace Aula_Asp_Net_Mvc.Models
{
    public class Calendario
    {
        public string DataPorExtenso { get; set; }
        public string MensagemDoDia { get; set; }

        public Calendario()
        {
            this.DataPorExtenso = this.FormataDataHora(new DateTime());
        }

        public Calendario(DateTime dataHora)
        {
            this.DataPorExtenso = this.FormataDataHora(dataHora);
        }

        private string FormataDataHora(DateTime dataHora)
        {
            return dataHora.ToString("dd \\d\\e MMMM \\d\\e yyyy");
        }
    }
}