using System;

namespace DemoDomain.Specifications
{
    public abstract class SpecificationBase<T>
    {
        public abstract string Message { get; }
        public abstract string DetailMessage { get; }
        public abstract string Code { get; }
        public abstract Func<T, bool> IsValid();
    }
}
