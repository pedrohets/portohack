using System.Collections.Generic;

namespace AtracacaoApi.Model
{
    public class NavioModel
    {
        public string Nome { get; set; }
        public string Imo { get; set; }
        public string Bandeira { get; set; }
        public string TipoNavio { get; set; }
        public decimal LOA { get; set; }
        public decimal Calado { get; set; }

        public static List<NavioModel> ObterNavios()
        {
            return new List<NavioModel>{
                new NavioModel()
            {
                Nome = "CAP SAN LORENZO",
                Imo = "9622227",
                Bandeira = "Denmark [DK]",
                TipoNavio = "Container Ship",
                LOA = (decimal) 333.2,
                Calado = (decimal) 48.32

            },
                new NavioModel()
            {
                Nome = "MSC MICHAELA",
                Imo = "9230488",
                Bandeira = "Panama [PA]",
                TipoNavio = "Container Ship",
                LOA = (decimal) 303.93  ,
                Calado = (decimal) 12
            },
                new NavioModel()
            {
                Nome = "MSC CATERINA",
                Imo = "9705005",
                Bandeira = "Portugal [PT]",
                TipoNavio = "Container Ship",
                LOA = (decimal) 300  ,
                Calado = (decimal) 12
            },
                new NavioModel()
            {
                Nome = "MSC DARDANELLES",
                Imo = "9247754",
                Bandeira = "Cyprus [CY]",
                TipoNavio = "Container Ship",
                LOA = (decimal) 299.9,
                Calado = (decimal) 11.8
            },
                new NavioModel()
            {
                Nome = "CAP SAN ANTONIO",
                Imo = "9622241",
                Bandeira = "Denmark [DK]",
                TipoNavio = "Container Ship",
                LOA = (decimal) 333.2,
                Calado = (decimal) 11.1
            },
               new NavioModel()
            {
                Nome = "MAERSK BERMUDA",
                Imo = "9697014",
                Bandeira = "Singapore [SG]",
                TipoNavio = "Container Ship",
                LOA = (decimal) 194.93,
                Calado = (decimal) 8.8
            }};
        }
    }
}
