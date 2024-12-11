using RCIInterface.Feature.StoreProcedureModule.Interface;
using RCIInterface.Interfaces;

namespace RCIInterface.Feature.StoreProcedureModule.Handlers;

public class StoreProcedureHandlers : IStoreProcedureHandlers
{
    private readonly IOHRepository repository;

    public StoreProcedureHandlers(IOHRepository repository)
    {
        this.repository = repository;
    }
}
