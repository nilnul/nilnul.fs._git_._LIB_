using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.svr_.azure.client.teamwork.create_.personal
{


	static public class _EnsureX
	{
		public static string Ret(
			nilnul.fs.git.svr_.azure.Client client
			,
			nilnul.fs.git.svr_.azure.repo.Name repoName

		)
		{
			try
			{
				return teamwork.create_._PersonalX._Create_teamNameAssumeNormalized(
					 client
					,
					repoName
				).ToString();
			}
			catch (
				Microsoft.TeamFoundation.Core.WebApi.ProjectAlreadyExistsException TF200019
			)
			{
				return $"{repoName} already exists:{TF200019.ToString()}";
			}
			catch (System.Net.WebException e)
			{
				//if (e.Error.GetType().Name == "WebException")
				//{
				//WebException we =e.Error;
				HttpWebResponse response = (System.Net.HttpWebResponse)e.Response;
				if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					return "BadRequest error possibly due to that the repo has already existed:  " + e.ToString();
				}
				else
				{
					throw;
				}
			}
		}

		public static string Ret(nilnul.fs.git.svr_.azure.Client client, string repoName)
		{
			return Ret(
				client,
				 azure.repo.Name.Of_byEncode(repoName)
			);
		}

		public static string Ret(nilnul.fs.git.svr_.azure.client_.Vaulted client, nilnul.fs.git.svr_.azure.repo.Name remoteCfgKey)
		{
			return Ret(
				client.genAzureClient(),
				 (remoteCfgKey)
			);
		}
		public static string Ret(nilnul.fs.git.svr_.azure.client_.Vaulted client, string remoteCfgKey)
		{
			return Ret(
				client,
				 azure.repo.Name.Of_byEncode(remoteCfgKey)
			);
		}

		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			nilnul.fs.git.svr_.azure.repo.Name repoName

		)
		{
			try
			{
				return new _op.result_.explain_.RetTxt(
					Ret(
						client,
							//nilnul.fs.git.svr_.azure.repo.Name.ByEncode(
							repoName
					//)
					)
				);
			}
			catch (System.Net.WebException e)
			{

				return _op.result_.explain_.RetTxt.FroXpn(e.ToString());
			};
		}


		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.git.svr_.azure.client_.Vaulted client
			,

			string remoteCfgKey

		)
		{
			return Result(
				client,
				nilnul.fs.git.svr_.azure.repo.Name.Of_byEncode(remoteCfgKey)

			);
		}


	}
}