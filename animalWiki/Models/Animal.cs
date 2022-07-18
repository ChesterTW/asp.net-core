using System;
using System.Collections.Generic;

namespace animalWiki.Models
{
    public partial class Animal
    {
        public int Id { get; set; }
        public string? ChName { get; set; }
        public string? EnName { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public string? Img { get; set; }
        public bool? Saved { get; set; }
        public bool? Loved { get; set; }
        public int? LoveCount { get; set; }
    }
}
