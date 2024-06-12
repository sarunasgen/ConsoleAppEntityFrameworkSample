using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFrameworkSample.Models
{
    [Table("Automobiliai")]
    public class Car
    {
        [Key]
        [Column("AutomobilioId")]
        public int Id { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public DateTime PirmRegData { get; set; }
    }
}
