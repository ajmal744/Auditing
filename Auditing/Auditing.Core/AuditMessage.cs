using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditing.Core
{
    public class AuditMessage
    {
        public AuditMessage(AuditContext context, AuditEvent auditEvent)
        {
            Context = context;
            Event = auditEvent;
            CreatedDateTime = DateTime.UtcNow;
            CallerThreadId = Thread.CurrentThread.ManagedThreadId;
            StackTrace = Environment.StackTrace;
        }

        public AuditContext Context { get; private set; }

        public AuditEvent Event { get; private set; }

        public DateTime CreatedDateTime { get; private set; }

        public string StackTrace { get; private set; }

        public int CallerThreadId { get; private set; }

        public override string ToString()
        {
            return
                string.Format(
                    @"CreatedDateTime: {0}, Context: {{{1}}}, Event: {{{2}}}, CallerThreadId: {{{3}}}",
                    CreatedDateTime,
                    Context,
                    Event,
                    CallerThreadId,
                    StackTrace);
        }
    }
}
