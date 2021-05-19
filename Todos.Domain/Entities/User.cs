using System;
using System.Collections.Generic;
using Todos.Domain.Common;

namespace Todos.Domain.Entities
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public ICollection<Todo> Todos { get; set; }
    }
}
