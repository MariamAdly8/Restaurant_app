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
    [Table("items")]
    public class Items
    {
        [Key]
        public int itemId { get; set; }
        [Required]
        public string name { get; set; }
        public string price { get; set; }
    }
}
