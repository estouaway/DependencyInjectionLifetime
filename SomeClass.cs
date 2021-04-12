using System;

namespace DependencyInjectionLifetime
{
    class SomeClass : ITransientClass, ISingletonClass, IScopedClass
    {
        string _something;
        public SomeClass() : this(Guid.NewGuid().ToString())
        {

        }
        public SomeClass(string something)
        {
            _something = something;
        }
        public string Something => _something;
    }
}
