using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.User
{
    public class FullName
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
    }
}