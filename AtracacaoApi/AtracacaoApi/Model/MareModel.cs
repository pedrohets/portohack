using System;
using System.Collections.Generic;

namespace AtracacaoApi.Model
{
    public class MareModel
    {
        public string mare { get; set; }
        public DateTime? inicio { get; set; }
        public DateTime? fim { get; set; }

        public static List<MareModel> ObterDadosMare()
        {
            return new List<MareModel>() {
                new MareModel()
            {
                mare = "Alta",
                inicio = new DateTime(2022, 08, 01, 20, 30, 00),
                fim = new DateTime(2022, 08, 01, 21, 30, 00),
            } };
        }
    }
}
