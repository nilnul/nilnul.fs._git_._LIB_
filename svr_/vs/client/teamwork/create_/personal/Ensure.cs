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

namespace nilnul.fs.git.svr_.vs.client.teamwork.create_.personal
{
	

		static public class _EnsureX
		{
			public static string Ret(
				nilnul.fs.git.svr_.vs.Client client
				,
				nilnul.fs.git.svr_.vs.repo.Name repoName

			)
			{
				try
				{
					return teamwork.create_._PersonalX.Create(
						 client
				,

							repoName
					).ToString(); ;
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

			public static string Ret(nilnul.fs.git.svr_.vs.Client  client, string remoteCfgKey)
			{
				return Ret(
					client,
					 vs.repo.Name.ByEncode(remoteCfgKey)
				);
			}
			public static string Ret(nilnul.fs.git.svr_.vs.client_.AccInVault client, nilnul.fs.git.svr_.vs.repo.Name remoteCfgKey)
			{
				return Ret(
					client.genOfficialClient(),
					 (remoteCfgKey)
				);
			}
			public static string Ret(nilnul.fs.git.svr_.vs.client_.AccInVault client, string remoteCfgKey)
			{
				return Ret(
					client,
					 vs.repo.Name.ByEncode(remoteCfgKey)
				);
			}

			public static nilnul._op.result_.explain_.RetTxt Result(
				nilnul.fs.git.svr_.vs.client_.AccInVault client

				,
				nilnul.fs.git.svr_.vs.repo.Name repoName

			)
			{
				try
				{
					return new _op.result_.explain_.RetTxt(
						Ret(
							client,
							nilnul.fs.git.svr_.vs.repo.Name.ByEncode(repoName)
						)
					);
				}
				catch (System.Net.WebException e)
				{

					return _op.result_.explain_.RetTxt.FroXpn(e.ToString());
				};
			}


			public static nilnul._op.result_.explain_.RetTxt Result(
				nilnul.fs.git.svr_.vs.client_.AccInVault client
				,

				string remoteCfgKey

			)
			{
				return Result(
					client,
					nilnul.fs.git.svr_.vs.repo.Name.ByEncode(remoteCfgKey)

				);
			}


		}
	}