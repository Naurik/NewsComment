using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsComment
{
    public class Comments
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Comment { get; set; }
        public Guid NewsId { get; set; }
    }
}
