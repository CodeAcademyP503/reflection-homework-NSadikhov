using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Core.Generators
{
    public class NameGenerator : IGenerator
    {
        public string Generate()
        {
            StringBuilder stringBuilder = new StringBuilder("user_");
            string datePart = DateTime.Now.ToString("yyyyMMddhhmmss");
            stringBuilder.Append(datePart);
            return stringBuilder.ToString();
        }
    }
}
