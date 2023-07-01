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


		///docs.gitlab.com/ee/user/profile/personal_access_tokens.html
		/// <summary>
		/// Though required, GitLab usernames are ignored when authenticating with a personal access token. There is an issue for tracking to make GitLab use the username.
		/// </summary>
		/// <remarks>
		/// password: don't use password. it may pose security risk, and it might be not working. use token instead.
		/// </remarks>
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
		 void CreatePrj(string prjName)
		{


		}
	}
}
