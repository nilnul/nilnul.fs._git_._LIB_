using System;

namespace nilnul.os.prog_.git.run_
{
	[Serializable]
	public class Xpn4GitRun : Exception,IXpn
	{
		public Xpn4GitRun() { }
		public Xpn4GitRun(string message) : base(message) { }
		public Xpn4GitRun(string message, Exception inner) : base(message, inner) { }
		protected Xpn4GitRun(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
