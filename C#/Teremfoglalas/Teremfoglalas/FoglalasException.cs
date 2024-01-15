using System.Runtime.Serialization;

namespace Teremfoglalas
{
    [Serializable]
    public class FoglalasException : Exception
    {
        public FoglalasException() : base("A kért időpontban a terem nem foglalható.")
        {
        }

        protected FoglalasException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}