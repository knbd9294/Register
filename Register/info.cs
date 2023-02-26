using System;
using System.ComponentModel.DataAnnotations;

namespace Registre
{
    public class info
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FingerPrint { get; set; }

        public DateTime? Date { get; set; }

        [Required]
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Cni { get; set; }
        public int? Tel { get; set; }
        public string Qualite { get; set; }
        public string MotifVisite { get; set; }
        public string ServiceVisite { get; set; }
        public DateTime? HeureEntrer { get; set; }
        public DateTime? HeureSortie { get; set; }
        public string Note { get; set; }
        public bool Groupe { get; set; }
        public byte Nombre { get; set; }
    }
}