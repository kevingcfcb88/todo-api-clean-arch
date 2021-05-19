using System;

namespace Todos.Domain.Common
{
    public class BaseEntity
    {
        public bool Status { get; set; }
        public DateTime Created_at { get; set; }
        public string Created_by { get; set; }
        public DateTime Modified_at { get; set; }
        public string Modified_by { get; set; }
    }
}
