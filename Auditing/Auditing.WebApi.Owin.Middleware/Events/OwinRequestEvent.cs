using System.Collections.Generic;
using Auditing.Core;

namespace Auditing.WebApi.Owin.Middleware.Events
{
    public class OwinRequestEvent : AuditEvent
    {
        public OwinRequestEvent(int statusCode, IDictionary<string,string[]> headers)
        {
            StatusCode = statusCode;
            Headers = headers;
        }

        public int StatusCode { get; private set; }

        public IDictionary<string, string[]> Headers { get; private set; }
    }
}