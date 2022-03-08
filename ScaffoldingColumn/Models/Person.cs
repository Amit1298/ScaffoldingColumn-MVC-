using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScaffoldingColumn.Models
{
    public class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string Age { get; set; }
        [ScaffoldColumn(false)]
        public string contact { get; set; }
        [ScaffoldColumn(false)]
        public string Address { get; set; }

    }
}