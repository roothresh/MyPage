﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class BlogEntity
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnail { get; set; }
        public string BlogImage { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId{ get; set; }
        public CategoryEntity Categories { get; set; }
        public List<CommentEntity> Comments{ get; set; }
        public bool RecordStatus { get; set; }
    }
}
