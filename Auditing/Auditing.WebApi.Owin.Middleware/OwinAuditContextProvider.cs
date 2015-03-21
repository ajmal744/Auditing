using System;
using Auditing.Core;
using Microsoft.Owin;

namespace Auditing.WebApi.Owin.Middleware
{
    public class OwinAuditContextProvider : IAuditActionContextProvider
    {
        private readonly IOwinContext context;
        private readonly string auditCorrelationId;
        private readonly ISystemInfoContextProvider systemInfoContextProvider;
        private readonly string sourceComponent;
        private AuditContext auditContext;

        public OwinAuditContextProvider(IOwinContext context, ISystemInfoContextProvider systemInfoContextProvider, string sourceComponent)
        {
            this.context = context;
            this.systemInfoContextProvider = systemInfoContextProvider;
            this.sourceComponent = sourceComponent;

            string clientAuditId = null;
            if (context.Request != null)
                clientAuditId = context.Request.Headers["X-Audit-Correlation-Id"];

            this.auditCorrelationId = clientAuditId ?? Guid.NewGuid().ToString();
        }

        public AuditContext GetContext()
        {
            return auditContext ?? (auditContext = new WebApiRequestAuditContext(this.sourceComponent)
            {
                RequestedUrl = this.context.Request.Uri.ToString(),
                RequestPath = this.context.Request.Path.Value,
                RequestQueryString = this.context.Request.QueryString.Value,
                SystemInfo = this.systemInfoContextProvider.GetSystemInfo(),
                AuditCorrelationId = new AuditCorrelationId(this.auditCorrelationId)
            });
        }
    }
}
