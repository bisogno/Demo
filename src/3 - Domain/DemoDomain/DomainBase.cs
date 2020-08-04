using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DemoNotification;

namespace DemoDomain
{
    public abstract class DomainBase
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public abstract bool IsValid { get; }
        internal DomainBase()
        {
        }
        public abstract void Specify();
    }
}
