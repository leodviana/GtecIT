﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GtecIt.ViewModels
{
    public class GrupoEditViewModel 
    {
        public int Id_stqcdgrp { get; set; }
        public string desc_grupo { get; set; }
        public string participa_rateio { get; set; }
        /*public Nullable<int> Id_grlcdusu { get; set; }
        public virtual grlcdusu grlcdusu { get; set; }
        public virtual ICollection<stqcdprd> stqcdprds { get; set; }*/
        //public List<EstadoCivilEditViewModel> EstadosList { get; set; }
    }
}