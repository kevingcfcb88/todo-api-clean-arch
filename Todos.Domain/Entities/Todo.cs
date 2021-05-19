using System;
using System.Collections.Generic;
using System.Text;
using Todos.Domain.Common;

namespace Todos.Domain.Entities
{
    public class Todo : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TodoStatus TodoStatusId { get; set; }
        public User UserId { get; set; }
    }
}
