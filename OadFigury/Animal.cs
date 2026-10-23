
using System;
using System.Collections.Generic;

namespace OadFigury
{
    public class Animal
    {
        public virtual string Bark() => "Some sound";
    }

    public class Dog : Animal
    {
        public override string Bark() => "Woof!";
    }
}
