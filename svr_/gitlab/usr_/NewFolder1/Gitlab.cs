using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_
{
	/// <summary>
	/// for gitlab.com
	/// </summary>
	///
	[Obsolete(nameof(gitlab.Client))]
	public class Gitlab
	{
		private nilnul.web.credential_._token.Data _credential;

		public nilnul.web.credential_._token.Data credential
		{
			get { return _credential; }
			set { _credential = value; }
		}

		public Gitlab(
			nilnul.web.credential_._token.Data credential	
		)
		{
			_credential = credential;

		}

		public Gitlab(string txt)
			:this(new web.credential_._token.Data(txt))
		{

		}




		public const string Prj_sinceRoot = "/projects";
		static  void CreatePrj(string prjName)
		{


		}
	}
}
