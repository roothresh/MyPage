using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CommentEntity
    {
        [Key]
        public int CommentId{ get; set; }
        public string CommentUserName{ get; set; }
        public string CommentTitle{ get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogId { get; set; }
        public BlogEntity Blogs{ get; set; }
        public bool RecordStatus { get; set; }
    }
}
