using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Application.Exceptions
{
    public class ValidationException:ApplicationException
    {

        private List<string> Exceptions { get; set; }
        public ValidationException(ValidationResult validationResult)
        {
            Exceptions = new List<string>();
            
            foreach(var newException in validationResult.Errors)
            {
                Exceptions.Add($"Exception {newException.ErrorMessage} with code {newException.ErrorCode}");
            }
        }
    }
}
