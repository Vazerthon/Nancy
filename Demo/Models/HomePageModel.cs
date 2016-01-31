using System.Collections;
using System.Collections.Generic;

namespace Demo.Models
{
    public class HomePageModel
    {
        public string Title { get; set; }
        public IEnumerable<string> Items { get; set; }
    }
}