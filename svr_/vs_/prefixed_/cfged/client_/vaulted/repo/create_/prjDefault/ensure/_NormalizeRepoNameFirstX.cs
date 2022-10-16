using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.svr_.vs_.prefixed_.cfged.client_.vaulted.repo.create_.prjDefault.ensure
{

	static public class _NormalizeNameX
	{
		

		public static string Ret( string repoName, G git=null)
		{
			return _EnsureX.Ret(
				
				 vs.repo.Name.ByEncode(repoName)
			);
		}

		

		public static nilnul._op.result_.explain_.RetTxt Result(
			
			string repoName
			,
			G git=null
		)
		{
			return _EnsureX.Result(
				
				nilnul.fs.git.svr_.vs.repo.Name.ByEncode(repoName)
				,git
			);
		}
		
		public static string ResultAsTxt(
			
			string repoName
			,
			G git=null
		)
		{
			return Result(
				
				repoName
				,git
			).ToString();
		}
		
	}
}