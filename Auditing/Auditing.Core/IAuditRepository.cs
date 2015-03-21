namespace Auditing.Core
{
    public interface IAuditRepository
    {
        void Add(AuditMessage audit);
    }
}
