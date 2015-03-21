namespace Auditing.Core
{
    public abstract class AuditContext
    {
        protected AuditContext(string component)
        {
            Guard.ArgumentNotNullOrEmpty(component, "component");
            Component = component;
        }

        public string Component { get; private set; }

        public abstract SystemInfo SystemInfo { get; set; }

        public abstract AuditCorrelationId AuditCorrelationId { get; set; }
    }
}
