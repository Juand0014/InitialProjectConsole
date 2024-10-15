using UContactStats.Feature.StoreProcedureModule.Interface;
using UContactStats.Interfaces;

namespace UContactStats.Feature.StoreProcedureModule.Handlers;

public class StoreProcedureHandlers : IStoreProcedureHandlers
{
    private readonly IOHRepository repository;

    public StoreProcedureHandlers(IOHRepository repository)
    {
        this.repository = repository;
    }
}
