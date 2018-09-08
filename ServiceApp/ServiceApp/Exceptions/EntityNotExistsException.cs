using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Exceptions
{

    [Serializable]
    public class EntityNotExistsException : Exception
    {
        public EntityNotExistsException() { }
        public EntityNotExistsException(string message) : base(message) { }
        public EntityNotExistsException(string message, Exception inner) : base(message, inner) { }
        protected EntityNotExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    } 

}
