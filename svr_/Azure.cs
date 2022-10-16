using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_
{
	/// <remarks>
	/// for example:
	/// https://acc@dev.azure.com/org/tmp_pub/_git/tmp_pub
	///
	/// visualstudio url can be migrated into azure.
	/// </remarks>
	///
	public interface IAzure {
	}

	static public class _AzureX
	{

		public const string DOMAIN = "dev.azure.com";


		static public string Hier(string org, string prj, string repo=null) {
			return $"{DOMAIN}/{org}/{prj}/_git/{repo??prj}";
		}


		static public string AccHier(string acc, string org,string prj, string repo=null) {

			return $"{acc}@{Hier(org,prj,repo)}";
		}
		static public string AccHier(string acc, string prj, string repo=null) {

			return AccHier(acc,acc,prj,repo);
		}


		static public string SchemeAccHier(string acc, string prj, string repo=null) {
			return $"https://{AccHier(acc,prj,repo)}";
		}

		static public string SchemeAccHier(string acc, string org, string prj, string repo=null) {
			return $"https://{AccHier(acc,org, prj,repo)}";
		}

		static public string SchemeHier(string org, string prj, string repo=null) {
			return $"https://{Hier(org,prj,repo)}";
		}

	


	}
}
