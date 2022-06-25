﻿namespace ManyToMany.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int SosialAccountId { get; set; }
        public SosialAccount SosialAccount { get; set; }
    }
}
