using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Application.Exceptions
{
    public class ValidationException:ApplicationException
    {

        private List<string> _exceptions { get; set; }
        public ValidationException(ValidationResult validationResult)
        {
            _exceptions = new List<string>();
            
            foreach(var newException in validationResult.Errors)
            {
                _exceptions.Add($"Exception {newException.ErrorMessage} with code {newException.ErrorCode}");
            }
        }
    }
}
