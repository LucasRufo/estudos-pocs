using System.Collections.Generic;
using System.Linq;

namespace MongoPOC.Api.Models
{
    public class Return
    {
        public bool HasError { get { return Errors.Any(); } }
        public Dictionary<string, string> Errors { get; } = new Dictionary<string, string>();
        public object ReturnObject { get; set; }

        public Return()
        {
            ReturnObject = null;
        }

        public Return(object returnObject)
        {
            ReturnObject = returnObject;
        }

        public Return(Dictionary<string, string> errors, object returnObject)
        {
            Errors = errors;
            ReturnObject = returnObject;
        }

        public Return(Dictionary<string, string> errors)
        {
            Errors = errors;
            ReturnObject = null;
        }

        public Return(string key, string error)
        {
            AddError(key, error);
            ReturnObject = null;
        }

        public void AddError(string key, string error)
        {
            Errors.Add(key, error);
        }
    }
}