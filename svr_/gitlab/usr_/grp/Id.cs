using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitLabApiClient;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.fs.git.svr_.gitlab.usr_.grp
{
	static public class _IdX
	{

		static public async Task<int?> AsId0nulAsyn(string grp)
		{
			var client = new nilnul.fs.git.svr_.gitlab.client_.AccInVault(grp);

			var token = client.getToken();

			var lib = new GitLabClient(
				nilnul.fs.git.svr_.gitlab._ApiX.SPEAR
				,
				token
			);

			var searched = await lib.Groups.SearchAsync(grp);

			var id = searched.Where(x => x.Name == grp).SingleOrDefault()?.Id;
			return id;
		}
		static public  int? AsId0nul(string grp)
		{
			return AsId0nulAsyn(grp).Result;
		}


	}
}
