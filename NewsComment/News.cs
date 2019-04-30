using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsComment
{
    public class News
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NewsHeadlines { get; set; }
        public string Statue { get; set; }
    }
}
