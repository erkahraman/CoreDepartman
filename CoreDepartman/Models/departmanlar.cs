﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class departmanlar
    {
        [Key]
        public int id { get; set; }


        [DisplayName ("Departman İsmi")]
        public string departmanad { get; set; }

        public List<personel> personels { get; set; }




    }
}
