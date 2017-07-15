using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Week01.Models.Data
{
    public class Post
    {
        public long Id { get; set; }

        [DisplayName("제목")]
        public string Title { get; set; }

        [DisplayName("내용")]
        public string Content { get; set; }

        [DisplayName("작성자")]
        public User Writer { get; set; }
        
        public string Password { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
