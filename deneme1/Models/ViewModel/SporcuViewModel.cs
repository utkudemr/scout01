using deneme1.Models.Entitiy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace deneme1.Models.ViewModel
{
    public class SporcuViewModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [Display(Name="Birth Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? Dtarihi { get; set; }
        public double Puan { get; set; }
        public int TakimId { get; set; }
        public int LiglerId { get; set; }
        public int Id { get; set; }
        public int SporcuId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
    }
}