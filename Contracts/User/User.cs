using System;
using System.Net.Mail;

namespace Contracts.User
{
    public class User
    {
        public Guid Id { get; set; }
        public FullName Name { get; set; }
        public MailAddress Email { get; set; }
    }
}