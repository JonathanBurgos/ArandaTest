using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaData.Connection.Models
{
    public class PropertiesMachine
    {
        [Key]
        public int Id { get; set; }
        public string VersonSystem { get; set; }
        public string NameHost { get; set; }
        public string IPAddress { get; set; }
        public string HardDisk { get; set; }
        public string MemoryRAM { get; set; }
        public string ProcessorName { get; set; }
        public string DateTimeNow { get; set; }

    }
}
