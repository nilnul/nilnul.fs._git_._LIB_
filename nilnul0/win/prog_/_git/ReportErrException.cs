using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_._git
{

	[Serializable]
	public class ReportErrException : Exception
	{
		public ReportErrException() { }
		public ReportErrException(string message) : base(message) { }
		public ReportErrException(string message, Exception inner) : base(message, inner) { }
		protected ReportErrException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
