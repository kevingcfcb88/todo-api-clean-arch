using System;

namespace Todos.Application.Exceptions
{
    class BadRequestException:ApplicationException
    {
        public BadRequestException(string message) : base(message)
        {

        }
    }
}
