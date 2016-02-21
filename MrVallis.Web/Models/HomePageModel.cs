using System.Collections.Generic;

namespace MrVallis.Web.Models
{
    public class HomePageModel
    {
        public string Title { get; set; }
        public IEnumerable<string> Items { get; set; }
    }
}