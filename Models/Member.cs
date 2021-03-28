using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demoAPI
{
    public class Member : Person
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}