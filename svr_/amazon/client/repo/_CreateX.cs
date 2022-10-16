using Amazon.CodeCommit;
using Amazon.CodeCommit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.amazon.client.repo
{
	static public class _CreateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="note"></param>
		/// <returns>there is a repo number limit of 1k, which can be adjusted by requesting in support center.</returns>
		static public CreateRepositoryResponse Ret(
			AmazonCodeCommitClient client
			,
			nilnul.fs.git.svr.repo.Name name, string note = null)
		{
			return client.CreateRepository(
				new CreateRepositoryRequest() { RepositoryName = name, RepositoryDescription = note }
			);
		}

		static public CreateRepositoryResponse Ret(AmazonCodeCommitClient client, string name, string note = null)
		{
			return Ret(client,new svr.repo.Name(name), note);
		}

		static public CreateRepositoryResponse Ret(nilnul.fs.git.svr_.amazon.client_.AccInVault  client, string name, string note = null)
		{
			return Ret(
				new AmazonCodeCommitClient()
				,
				new svr.repo.Name(name)
				,
				note);
		}



		static public string RetTxt(AmazonCodeCommitClient client, string name, string note = null)
		{

			return nilnul.fs.git.svr_.aws.acc.repo._create._ResponseX.Phrase(
				Ret(client,name, note)
			);
		}
	}
}