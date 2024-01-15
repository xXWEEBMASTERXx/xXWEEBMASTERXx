using System.Runtime.Serialization;

namespace Teremfoglalas
{
    [Serializable]
    public class IdotartamException : Exception
    {
        public IdotartamException() : base("A lefoglalt időtartam nem pozitív, vagy nem 15-tel osztható.")
        {
        }

        protected IdotartamException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}