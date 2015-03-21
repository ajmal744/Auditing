using Auditing.Core;

namespace Auditing.WebApi.Owin.Middleware
{
    public class WebApiRequestAuditContext : AuditContext
    {
        public WebApiRequestAuditContext(string component)
            : base(component)
        {
        }

        public string RequestedUrl { get; set; }

        public string RequestPath { get; set; }

        public string RequestQueryString { get; set; }
        
        public override SystemInfo SystemInfo { get; set; }

        public override AuditCorrelationId AuditCorrelationId { get; set; }

        public override string ToString()
        {
            return
                string.Format(
                    "RequestedUrl: {0}, RequestPath: {1}, RequestQueryString: {2}, SystemInfo: {3}, AuditCorrelationId: {4}",
                    RequestedUrl,
                    RequestPath,
                    RequestQueryString,
                    SystemInfo,
                    AuditCorrelationId);
        }
    }
}
