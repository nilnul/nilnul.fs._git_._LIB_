using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.bak
{
	[Obsolete()]
	public class Cfg
	{

		public string remotePrefix { get; internal set; }

		private string _branchPrefix="nilnulBak";

		public string branchPrefix
		{
			get { return _branchPrefix; }
			set { _branchPrefix = value; }
		}

		public Cfg(string branchPrefix, string remotePrefix)
		{
			_branchPrefix = branchPrefix;
			this.remotePrefix = remotePrefix;
		}

		public Cfg():this(
			"nilnulBak"
			,
			""	
		)
		{

		}

		

		public string genRemote(string svc)
		{
			return $"{remotePrefix}_{svc}";
		}

		public string gen4vs() {
			return genRemote(
				svrs.Name.Vs	
			);
		}

		public string gen4bb() {
			return genRemote(
				svrs.Name.BitBucket
			);
		}

		public string gen4Coding() {
			return genRemote(
				svrs.Name.Codeing
			);
		}

		public string gen4OsChina() {
			return genRemote(
				svrs.Name.OsChina
			);
		}
		public string gen4GitLab() {
			return genRemote(
				svrs.Name.GitLab
			);
		}
		public string gen4csdn() {
			return genRemote(
				svrs.Name.Csdn
			);
		}




		static public Cfg StaticInstance = new Cfg(
			"bak"
			, "bak"

		);




		public bool thin;

	}
}
