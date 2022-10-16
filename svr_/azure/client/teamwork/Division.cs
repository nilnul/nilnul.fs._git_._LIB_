using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.client.teamwork
{
	

	/// <summary>
	/// The request URI, in the following form: VERB https://{instance}[/{team-project}]/_apis[/{area}]/{resource}?api-version={version}
	/// </summary>
	public class Division : nilnul.obj.Box1<Teamwork>
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

		public Division(Teamwork val,string areaRsc0) : base(val)
		{
			_areaRsc = areaRsc0;
		}
		public string address() {
			return $"{boxed.stem4apis()}{_areaRsc}";
		}

		public string url(string version) {
			return $"{address()}?api-version-{version}";
		}


	}
}
