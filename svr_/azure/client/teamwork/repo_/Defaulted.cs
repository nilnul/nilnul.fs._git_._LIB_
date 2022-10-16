using nilnul.fs.git.svr_.azure.client_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.client.teamwork.repo_
{
	/// <summary>
	/// in each teamspace, there is a defaulted repo, and optional many others
	/// </summary>
	public class Defaulted
		:
		nilnul.obj.Box1<Teamwork>
	{
		public Defaulted(Teamwork val) : base(val)
		{
		}

		public Defaulted(Vaulted boxed1,string teamProj):this(
			new Teamwork(boxed1,teamProj)
		)
		{
		}

		public Defaulted(string org,string teamProj):this(new Teamwork(org,teamProj))
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// eg:
		///		https://dev.azure.com/{org}/_git/t220213232433s1722438N8h
		/// </returns>
		public string spear4browser()
		{
			return $"{boxed.client.stem()}_git/{boxed.teamProject}";
		}

		/// <summary>
		/// there is no ".git" trailing.
		/// </summary>
		/// <param name="org"></param>
		/// <param name="teamwork"></param>
		/// <returns> here we don't add username to the url</returns>
		static public string Spear4git(string org, string teamwork) {
			return $"{Teamwork.Stem(org,teamwork)}_git/{teamwork}";

		}

		/// <summary>
		/// eg:
		///		https://username@dev.azure.com/{org}/t13232433s1722438N8h/_git/t13232433s1722438N8h
		/// </summary>
		/// <returns></returns>
		public string spear4git()
		{
			return $"{boxed.stem()}_git/{boxed.teamProject}";
		}

	}
}