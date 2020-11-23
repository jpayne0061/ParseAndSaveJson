using System;
using System.Collections.Generic;
using System.Text;

namespace ParseAndSaveJson.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
        public bool Completed { get; set; }
        public string Image  { get; set; }
    }
}
