using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github
{
	public class Client:nilnul.fs.git.svr.ClientA
		,
		_client_.HeaderI
	{
		public svr_.Github svr { get; set; }

		
		/// 
		public string product4header { get; set; }

		public NetworkCredential cred { get; set; }
	}
}
