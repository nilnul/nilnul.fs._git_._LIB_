using Amazon.CodeCommit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.svr_.amazon.client.repo.create
{
	static public class _EnsureX
	{
		public static string Ret(
			AmazonCodeCommitClient client
			,
			nilnul.fs.git.svr.repo.Name repoName
			,
			G git = null
		)
		{
			try
			{
				return _CreateX.RetTxt(
					client,
						repoName
				); ;
			}
			catch (Amazon.CodeCommit.Model.RepositoryNameExistsException
 e)
			{
				return "already created";
				////if (e.Error.GetType().Name == "WebException")
				////{
				////WebException we =e.Error;
				//HttpWebResponse response = (System.Net.HttpWebResponse)e.Response;
				//if (response.StatusCode == HttpStatusCode.BadRequest)
				//{
				//	return "BadRequest error possibly due to that the repo has already existed:  " + e.ToString();
				//}
				//else
				//{
				//	throw;
				//}
			}
		}

		public static string Ret(
						AmazonCodeCommitClient client
			,
string remoteCfgKey, G git = null)
		{
			return Ret(
				client,

				 new svr.repo.Name(remoteCfgKey)
			);
		}

		public static string Ret(
						nilnul.fs.git.svr_.amazon.client_.AccInVault client
			,
string remoteCfgKey,
G git = null)
		{
			return Ret(
				client.genAmazonClient(),

				 new svr.repo.Name(remoteCfgKey)
			);
		}

		public static nilnul._op.result_.explain_.RetTxt Result(
						AmazonCodeCommitClient client
			,

			nilnul.fs.git.svr.repo.Name repoName
			,
			G git = null
		)
		{
			try
			{
				return new _op.result_.explain_.RetTxt(
					Ret(
						client,
						(repoName)
					)
				);
			}
			catch (System.Net.WebException e)
			{

				return _op.result_.explain_.RetTxt.FroXpn(e.ToString());
			};
		}


		public static nilnul._op.result_.explain_.RetTxt Result(
			AmazonCodeCommitClient client
			,

			string remoteCfgKey
			,
			G git = null
		)
		{
			return Result(
				client,

				new nilnul.fs.git.svr.repo.Name(remoteCfgKey)
				, git
			);
		}

		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.git.svr_.amazon.client_.AccInVault client
			,

			string remoteCfgKey
			,
			G git = null
		)
		{
			return Result(
				client.genAmazonClient(),

				new nilnul.fs.git.svr.repo.Name(remoteCfgKey)
				, git
			);
		}

	}
}
