using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIS3033_HW5.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Auto increment
        public int Id { get; set; }
        public int NumMouses { get; set; }
        public int NumPads { get; set; }
        public double Subtotal { get; set; } //Subtotal=39.99*NumMoues+19.99*NumPads;
    }
}
