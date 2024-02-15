using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Resturant_App.Data
{
    [Table("orders")]
    public class Orders
    {
        [Key]
        public int orderId { get; set; }
        [Required]
        public int userID { get; set; }
        public string TotalPrice { get; set; }
        public DateTime date { get; set; }

        [ForeignKey("userID")]
        public virtual User user { get; set; }
    }
}
