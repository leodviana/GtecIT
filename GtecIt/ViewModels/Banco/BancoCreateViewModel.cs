﻿using System.ComponentModel.DataAnnotations;

namespace GtecIt.ViewModels
{
    public class BancoCreateViewModel 
    {
        public int id_Fincdbanco { get; set; }
        public string cd_banco { get; set; }
        public string desc_banco { get; set; }
        public int? cd_usuario { get; set; }
    }
}