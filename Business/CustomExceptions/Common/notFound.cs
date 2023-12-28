using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.CustomExceptions.Common
{
    public class notFound : Exception
    {
        public notFound()
        {
        }

        public notFound(string? message) : base(message)
        {
        }

     
    }
}
