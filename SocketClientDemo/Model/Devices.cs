using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketClientDemo.Model
{
   public class Devices
    { 
        [Key]
        public int ID { get; set; }

        [StringLength(50),Required]
        public string DevicesName { get; set; }
        [StringLength(50), Required]
        public string Region { get; set; }
        [StringLength(15), Required]
        public string IpAddress { get; set; }
        [StringLength(5), Required]
        public string IpPort { get; set; }

        [StringLength(20)]
        public string MACAddress { get; set; }

        [StringLength(3), Required]
        public string Protocols { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
