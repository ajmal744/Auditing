using System;
using Auditing.Core;

namespace Auditing.WebApi.Owin.Middleware.Events
{
    public class UnhandledExceptionEvent : AuditEvent
    {
        public UnhandledExceptionEvent(Exception exception)
        {
            Exception = exception;
        }

        public Exception Exception { get; private set; }
    }
}
