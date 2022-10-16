using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.bb
{
	public class Client
	{


		private nilnul.web._credential.Slots _credential;

		public nilnul.web._credential.Slots credential
		{
			get { return _credential; }
			set { _credential = value; }
		}

		public Client(nilnul.web._credential.Slots credential)
		{
			_credential = credential;
		}



		public Client(string username, string password)
				: this(new web._credential.Slots(username, password))
			{

		}

		public Client(NetworkCredential credential1):this(credential1.UserName, credential1.Password)
		{
		}


	}
}

