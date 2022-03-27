using System;

namespace LifecycleOfTheService.Services
{
    public interface IScopedService
    {
        Guid GetID();
    }
}
