using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAndService.Expensive
{
    internal class ObjectNotFoundException : Exception
    {
        public ObjectNotFoundException(string objectName) : base($"{objectName} wasn't found")
        {

        }
    }
}
