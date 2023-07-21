using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Exceptions
{
    public class ValidationException:ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();
        public ValidationException(ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                Errors.Add(item.ErrorMessage);
            }
        }
    }
}
