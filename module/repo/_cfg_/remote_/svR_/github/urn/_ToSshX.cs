using System;
using System.Linq;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svR_.github.urn
{
	static public class _ToSshX
	{
		static public void TestMethod1(
			string module
			,
			string remote
		)
		{


			var urn = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(
				module,remote
			);

			if (fs.git.module.repo._cfg_.remote_.svR_.github.urn.be_.ssh.Anto.Singleton.be(urn))
			{
				var url = nilnul.web.url_.SchemedNodewise.Parse(urn);

				// https://gitlab.com/waan/wmple_.161113.git

				const string ending = ".git";

				var repoName = url.nodewise.resource0nul.render.route.division.denotes.Last().ToString();
				nilnul.bit.vow_.True1.Vow(
					repoName.EndsWith(".git")
				);

				repoName=repoName.Substring(0, repoName.Length - ending.Length);

				var usr = url.nodewise.resource0nul.render.route.division.denotes.First();

				var urnGenerated = fs.git.svr_.github.repo.urn_._SshX._Urn_assumesUsrRepo(
					usr
					,
					repoName
				); ;

				fs.git.module.repo._cfg_.remote.url._AssignX.ByRemoteCmd(
					module
					,
					remote
					,
					urnGenerated
				);


			}

	
		}
	}
}
