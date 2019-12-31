using System;
using Contracts.User;

namespace Urfu.Learn.Contracts.User
{
    public class User
    {
        public Guid Id { get; set; }
        public FullName Name { get; set; }
        public string Email { get; set; }
    }
}