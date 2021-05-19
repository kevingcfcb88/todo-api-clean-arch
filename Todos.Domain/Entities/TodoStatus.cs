using System;
using Todos.Domain.Common;

namespace Todos.Domain.Entities
{
    public class TodoStatus : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}