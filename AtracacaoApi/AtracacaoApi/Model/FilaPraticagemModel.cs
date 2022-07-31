using System;

namespace AtracacaoApi.Model
{
    public class FilaPraticagemModel
    {
        public DateTime? PrevInicio {get; set;}
        public string Sentido { get; set; }
        public string Status { get; set; }
        public NavioModel Navio { get; set; }

    }
}
