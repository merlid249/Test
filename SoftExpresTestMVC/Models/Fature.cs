using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SoftExpresTestMVC.Models
{
    public class Fature
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Emertimi")]
        [Required(ErrorMessage = "Emertimi is required")]
        public string  Emertimi { get; set; }
        [DisplayName("Njesia")]
        [Required(ErrorMessage = "Njesia is required")]
        public string  Njesia { get; set; }
        [DisplayName("Date Skadences ")]
        [Required(ErrorMessage = "Date Skadences is required")]
        public DateTime? DatasKdences { get; set; }
        [DisplayName("Cmimi")]
        [Required(ErrorMessage = "Cmimi is required")]
        public double Cmimi { get; set; }
        [DisplayName("Lloji")]
        [Required(ErrorMessage = "Lloji is required")]
        public string Lloji { get; set; }
        [DisplayName("KaTvsh")]
        public bool KaTvsh { get; set; }
        [DisplayName("Tipi")]
        [Required(ErrorMessage = "Tipi is required")]
        public string Tipi { get; set; }
        [DisplayName("Barkodi ")]
        [Required(ErrorMessage = "Barkodi is required")]
        public string Barkod { get; set; }

    }
}
