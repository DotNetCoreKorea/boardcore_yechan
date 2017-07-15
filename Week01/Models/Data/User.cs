using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week01.Models.Data
{
    public class User
    {
        public long Id { get; set; }
        public string NickName { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
