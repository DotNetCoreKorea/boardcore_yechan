using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week01.Models.Request
{
    public class PostPostModel
    {
        [DisplayName("제목")]
        public string Title { get; set; }

        [DisplayName("내용")]
        public string Content { get; set; }

        [DisplayName("비밀번호")]
        public string Password { get; set; }
    }
}
