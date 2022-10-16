using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab
{

	/// <summary>
	/// for gitlab.com
	/// </summary>
	public class Client
	{
		private nilnul.web.credential_._token.Data _credential;

		public nilnul.web.credential_._token.Data credential
		{
			get { return _credential; }
			set { _credential = value; }
		}

		public Client(
			nilnul.web.credential_._token.Data credential	
		)
		{
			_credential = credential;

		}

		public Client(string txt)
			:this(new web.credential_._token.Data(txt))
		{

		}






		public const string Prj_sinceRoot = "/projects";
		static void CreatePrj(string prjName)
		{


		}
	}
}
