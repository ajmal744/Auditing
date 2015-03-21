using System;
using System.Threading.Tasks;
using Auditing.Core;
using Auditing.WebApi.Owin.Middleware.Events;
using Microsoft.Owin;

namespace Auditing.WebApi.Owin.Middleware
{
    public class AuditOwinRequestMiddleware : OwinMiddleware
    {
        private readonly IAuditRepository _auditRepository;

        public AuditOwinRequestMiddleware(OwinMiddleware next, IAuditRepository auditRepository) : base(next)
        {
            _auditRepository = auditRepository;
        }

        public override async Task Invoke(IOwinContext context)
        {
            var auditor = new Auditor(this._auditRepository, new OwinAuditContextProvider(context, new SystemInfoContextProvider(new AssemblyFileVersionProvider()), context.));

            auditor.Write(new OwinRequestStartedEvent());
            try
            {
                await Next.Invoke(context);
            }
            catch (Exception ex)
            {
                auditor.Write(new UnhandledExceptionEvent(ex));
                throw;
            }

            auditor.Write(new OwinRequestEvent(context.Response.StatusCode, context.Response.Headers));
        }
    }
}
