using System;
using System.Collections.Generic;
using System.Text;

namespace ParseAndSaveJson.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Bundle> Bundles { get; set; }
    }
}
