namespace Auditing.Core
{
    interface IAuditor
    {
        void Write(AuditEvent auditEvent);
    }
}
