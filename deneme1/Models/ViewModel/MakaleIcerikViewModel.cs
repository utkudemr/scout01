using deneme1.Models.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deneme1.Models.ViewModel
{
    public class MakaleIcerikViewModel
    {
        public int Id { get; set; }
        public string Ad{ get; set; }
        public string Soyad { get; set; }
        public List<MakaleViewModel> Makale { get; set; }
    }
}