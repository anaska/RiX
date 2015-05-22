using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiX.Models
{
    public class Search
    {
        public virtual DateTime DateOfSearch { get; set; }
        public virtual int UserId { get; set; }
        public virtual String[] SearchedTerms { get; set; }
        public virtual int[] FrequencyOfTerms { get; set; }
    }
}