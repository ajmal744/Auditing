namespace Auditing.Core
{
    public interface IAuditActionContextProvider
    {
        AuditContext GetContext();
    }
}
