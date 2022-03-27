using System;

namespace LifecycleOfTheService.Services
{
    public class SomeService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public SomeService()
        {
           id = Guid.NewGuid();
        }
        public Guid GetID()
        {
            return id;
        }
    }
}
