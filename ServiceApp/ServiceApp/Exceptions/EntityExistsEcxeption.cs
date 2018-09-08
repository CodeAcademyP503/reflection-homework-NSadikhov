using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Exceptions
{

    [Serializable]
    public class EntityExistsEcxeption : Exception
    {
        public EntityExistsEcxeption() { }
        public EntityExistsEcxeption(string message) : base(message) { }
        public EntityExistsEcxeption(string message, Exception inner) : base(message, inner) { }
        protected EntityExistsEcxeption(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    } 
   
}
