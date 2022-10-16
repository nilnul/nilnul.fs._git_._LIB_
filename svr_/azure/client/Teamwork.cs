using nilnul.fs.git.svr_.azure.client_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.client
{
	public class Teamwork
		:
		nilnul.obj.Box1<Client>
	{
		private string _teamProject;

		public string teamProject
		{
			get { return _teamProject; }
			set { _teamProject = value; }
		}

		public Teamwork(Client val, string teamProject0) : base(val)
		{
			_teamProject = teamProject0;
		}

		public Teamwork(string org, string teamProj):this( Client.CreateFroVault(org),teamProj)
		{
		}

		public Teamwork(Vaulted boxed1, string teamProj):
			this(new Client(boxed1.org,boxed1.cred0nul?.Password), teamProj)
		{
		}


		public Client client {
			get {
				return boxed;
			}
		}


		/// <summary>
		/// usable in browser for the dashboard of the project. the dashboard includes not only repos, but also other settings.
		/// eg:
		///		https://dev.azure.com/{org}/t220213232433s1722438
		/// </summary>
		/// <returns></returns>
		public static string Spear(string org, string teamwork) { 
			return $"{Client.Stem(org)}{teamwork}";
		}

		public string spear() {
			return $"{boxed.stem()}{_teamProject}";
		}
	
		public static object Stem(string org, string team)
		{
			return $"{Spear(org,team)}/";

		}

		public string stem() {
			return $"{spear()}/";
		}

		public string spear4apis() {
			return $"{stem()}/_apis";
		}
		public string stem4apis() {
			return $"{spear4apis()}/";
		}



	}
}
