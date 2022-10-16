using Amazon.CodeCommit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.aw_.ohio.client_.cfged.repo
{
	static public class _CreateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="note"></param>
		/// <returns>there is a repo number limit of 1k, which can be adjusted by requesting in support center.</returns>
		static public CreateRepositoryResponse Ret(nilnul.fs.git.svr.repo.Name name, string note = null)
		{
			return _CfgedX.Ensure().CreateRepository(new CreateRepositoryRequest() { RepositoryName = name, RepositoryDescription = note });
		}

		static public CreateRepositoryResponse Ret(string name, string note = null)
		{
			return Ret(new svr.repo.Name(name), note);
		}


		static public string RetTxt(string name, string note = null)
		{

			return nilnul.fs.git.svr_.aws.acc.repo._create._ResponseX.Phrase(
				Ret(name, note)
			);
		}
	}
}