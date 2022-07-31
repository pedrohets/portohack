using System;
using System.Collections.Generic;
using System.Linq;

namespace AtracacaoApi.Model
{
    public class ViagemModel
    {
        public string Numero { get; set; }
        public NavioModel Navio { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ETB { get; set; }
        public DateTime? ETS { get; set; }
        public DateTime? AberturaGate { get; set; }
        public string Operador { get; set; }
        public string Berco { get; set; }

        public static List<ViagemModel> ObterViagens()
        {
            return new List<ViagemModel>() {
                new ViagemModel()
                {
                    Numero = "2404W",
                    ETA = new DateTime(2022, 08, 01, 20, 30, 00),
                    ETB = new DateTime(2022, 08, 01, 23, 30, 00),
                    ETS = new DateTime(2022, 08, 02, 19, 00, 00),
                    Operador = "BTP",
                    AberturaGate = new DateTime(2022, 08, 04, 19, 00, 00),
                    Navio = NavioModel.ObterNavios().Where(c => c.Imo == "9230488").FirstOrDefault(),
                    Berco = "BTP1"
                },
                new ViagemModel()
                {
                    Numero = "02675 2022",
                    ETA = new DateTime(2022, 08, 31, 01, 00, 00),
                    ETB = new DateTime(2022, 08, 01, 13, 00, 00),
                    ETS = new DateTime(2022, 08, 02, 07, 00, 00),
                    Operador = "Santos Brasil",
                    AberturaGate = new DateTime(2022, 08, 02, 12, 30, 00),
                    Navio = NavioModel.ObterNavios().Where(c => c.Imo == "9622227").FirstOrDefault(),
                    Berco = "SB3"
                },
                new ViagemModel()
                {
                    Numero = "02983 2022",
                    ETA = new DateTime(2022, 07, 31, 16, 00, 00),
                    ETB = new DateTime(2022, 07, 31, 21, 00, 00),
                    ETS = new DateTime(2022, 08, 01, 13, 00, 00),
                    Operador = "Santos Brasil",
                    AberturaGate = new DateTime(2022, 08, 01, 21, 00, 00),
                    Navio = NavioModel.ObterNavios().Where(c => c.Imo == "9697014").FirstOrDefault(),
                    Berco = "SB3"
                },
                new ViagemModel()
                {
                    Numero = "03150 2022",
                    ETA = new DateTime(2022, 07, 31, 12, 00, 00),
                    ETB = new DateTime(2022, 08, 01, 00, 00, 00),
                    ETS = new DateTime(2022, 08, 04, 18, 00, 00),
                    Operador = "Santos Brasil",
                    AberturaGate = new DateTime(2022, 08, 02, 00, 00, 00),
                    Navio = NavioModel.ObterNavios().Where(c => c.Imo == "9622241").FirstOrDefault(),
                    Berco = "SB3"
                }
            };
        }
    }
}
