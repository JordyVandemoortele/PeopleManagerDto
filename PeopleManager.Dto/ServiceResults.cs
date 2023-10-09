namespace Vives.Services.Model
{
    public class ServiceResults
    {
        public IList<ServiceMessage> Messages { get; set; } = new List<ServiceMessage>();

        public bool isSucces => Messages.All(m => m.Type != ServiceMessageType.Error);
    }
    public class ServiceResults<T>: ServiceResults
    {
        public T? Result { get; set; }
    }
}
