namespace RCIInterface.Interfaces;

public interface IOHRepository
{
    void ExecuteProcedure(string storeProcedureName, params string[] parameters);
    IQueryable<TResult> GetStoredProcedureResult<TResult>(string storeProcedureName, params object[] parameters);
}
