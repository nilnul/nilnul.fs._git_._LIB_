using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.client
{
	/// <summary>
	/// aka: rsc
	/// </summary>
	static public class _DivisionX
	{
	
		static public string GenerateUrl(string account, string areaResources, string version)
		{
			return $"{_client_._OrgX.Stem4api(account)}{areaResources}?api-version={version}";
			
		}
		static public string GenerateUrl1_0(string account, string areaResources )
		{
			return $"{_client_._OrgX.Stem4api(account)}{areaResources}?api-version={"1.0"}";
		}


		static public string GenerateUrl2_0preview(string account, string areaResources)
		{
			return GenerateUrl(account, areaResources, "2.0-preview");
		}

		static public string GenerateUrl1_0preview(string account, string areaResources)
		{
			return GenerateUrl(account, areaResources, "1.0-preview");
		}

		
	}

	/// <summary>
	/// The request URI, in the following form: VERB https://{instance}[/{team-project}]/_apis[/{area}]/{resource}?api-version={version}
	///		where the "team-project" is optional, and we omitt it here.
	///		for non-omitted teamwork, <see cref="nameof(teamwork.Division)"/>
	/// </summary>
	public class Division : nilnul.obj.Box1<Client>
	{

		/// <summary>
		/// both area and resource.
		/// area is opitional; resource is not.
		/// this can be div, or document
		/// </summary>
		private string _areaRsc;

		public string areaRsc
		{
			get { return _areaRsc; }
			set { _areaRsc = value; }
		}

		public Division(Client val,string areaRsc0) : base(val)
		{
			_areaRsc = areaRsc0;
		}
		public string address() {
			return $"{boxed.stem4apis()}{_areaRsc}";
		}

		public string url(string version) {
			return $"{address()}?api-version={version}";
		}


	}
}
