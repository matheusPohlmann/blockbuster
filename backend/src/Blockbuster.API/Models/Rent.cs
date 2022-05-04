using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blockbuster.API.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public string DateRent { get; set; }
        public string DateDevolution { get; set; }

    }
}