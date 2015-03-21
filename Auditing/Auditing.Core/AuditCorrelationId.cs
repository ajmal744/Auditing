namespace Auditing.Core
{
    public sealed  class AuditCorrelationId
    {
        private readonly string _correlationId;

        public AuditCorrelationId(string correlationId)
        {
            _correlationId = correlationId;
        }

        public string Id 
        {
            get { return _correlationId; }
        }

        public override string ToString()
        {
            return string.Format("CorrelationId: {0}", Id);
        }
    }
}