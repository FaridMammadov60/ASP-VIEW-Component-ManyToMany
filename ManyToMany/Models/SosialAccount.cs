using System.Collections.Generic;

namespace ManyToMany.Models
{
    public class SosialAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
