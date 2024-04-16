using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCascadingDropdowns.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int PlatformId { get; set; }
    }
}