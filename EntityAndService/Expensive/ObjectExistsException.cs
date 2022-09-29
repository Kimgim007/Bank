using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAndService.Expensive
{
    internal class ObjectExistsException : Exception
    {
        public ObjectExistsException(string objectName) : base($"{objectName} already exist")
        {

        }
    }
}
