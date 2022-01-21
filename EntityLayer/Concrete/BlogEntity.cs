using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class BlogEntity
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnail { get; set; }
        public string BlogImage { get; set; }
        public DateTime CreateDate { get; set; }
        public bool RecordStatus { get; set; }
    }
}
