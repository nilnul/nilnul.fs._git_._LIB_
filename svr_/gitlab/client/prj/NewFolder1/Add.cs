using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using nilnul.fs.git.svr_.gitlab.client.prj;
using System;

namespace nilnul.fs.git.svr_.gitlab.client.prjs
{
	[Obsolete(nameof(gitlab.client.prj.Creation))]
	public class Add: gitlab.client.prj.Creation
	{

		

		public Add(svr_.gitlab.Client gitLab):base(gitLab)
		{
		}


		
		static public string ByPrivateToken_useWebRequest(string privateToken, string _prjName__normalized)
		{
			return _CreationX._ByWebReq_assumesNormed(privateToken, _prjName__normalized);


		}

	}
}

