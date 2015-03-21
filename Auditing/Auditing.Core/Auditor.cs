namespace Auditing.Core
{
    public class Auditor : IAuditor
    {
        private readonly IAuditActionContextProvider auditActionContextProvider;
        private readonly IAuditRepository auditRepository;

        public Auditor(IAuditRepository auditRepository, IAuditActionContextProvider auditActionContextProvider)
        {
            this.auditRepository = auditRepository;
            this.auditActionContextProvider = auditActionContextProvider;
        }

        public void Write(AuditEvent auditEvent)
        {
            WriteAuditData(new AuditMessage(this.auditActionContextProvider.GetContext(), auditEvent));
        }

        private void WriteAuditData(AuditMessage auditMessage)
        {
            this.auditRepository.Add(auditMessage);
        }
    }
}
