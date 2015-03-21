using System;

namespace Auditing.Core
{
    public class AuditMessage
    {
        public AuditMessage(AuditContext context, AuditEvent auditEvent)
        {
            Context = context;
            Event = auditEvent;
            CreatedDateTime = DateTime.UtcNow;            
        }

        public AuditContext Context { get; private set; }

        public AuditEvent Event { get; private set; }

        public DateTime CreatedDateTime { get; private set; }

        public override string ToString()
        {
            return
                string.Format(
                    @"CreatedDateTime: {0}, Context: {1}, Event: {2}",
                    CreatedDateTime,
                    Context,
                    Event);
        }
    }
}
