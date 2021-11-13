using FluentValidation.Results;
using System.Collections.Generic;

namespace MongoPOC.Api.Extensions
{
    public static class DictionaryExtensions
    {
        public static Dictionary<string, string> ToDictionary(this List<ValidationFailure> validationFailures)
        {
            var dict = new Dictionary<string, string>();

            foreach (var validationFailure in validationFailures)
            {
                dict.Add(validationFailure.PropertyName, validationFailure.ErrorMessage);
            }

            return dict;
        }
    }
}
