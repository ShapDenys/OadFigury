using System;
using System.Collections.Generic;
using System.Text;

namespace OadFigury
{
    public class Product
    {
        public virtual string Description() => "This is a product.";
    }

    public class Service : Product
    {
        public override string Description() => "This is a service.";
    }
}
