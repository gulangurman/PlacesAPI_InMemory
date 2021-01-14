using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlacesAPI_InMemory.Models
{
    public class Place
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }
        public bool IsOpen { get; set; }
        public string Details { get; set; }
    }
}
