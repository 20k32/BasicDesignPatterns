using System;

namespace Prototype
{
    public interface IPrototype
    {
        IPrototype DeepCopyClone();
        IPrototype Clone();
    }
}
