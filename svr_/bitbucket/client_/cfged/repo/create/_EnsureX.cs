using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.svr_.bb.client_.cfged.repo.create
{
	static public class _EnsureX
	{
		public static string Ret(
			nilnul.fs.git.svr.repo.Name repoName
			,
			G git = null
		)
		{
			try
			{
				return _CreateX.Ret(
						repoName
				); ;
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

		public static string Ret(string repoName, G git = null)
		{
			return Ret(

				 new svr.repo.Name(repoName)
			);
		}

		public static nilnul._op.result_.explain_.RetTxt Result(

			nilnul.fs.git.svr.repo.Name repoName
			,
			G git = null
		)
		{
			try
			{
				return new _op.result_.explain_.RetTxt(
					Ret(
						new nilnul.fs.git.svr.repo.Name(repoName)
					)
				);
			}
			catch (System.Net.WebException e)
			{
				return _op.result_.explain_.RetTxt.FroXpn(e.ToString());
			};
		}


		public static nilnul._op.result_.explain_.RetTxt Result(
			string remoteCfgKey
			,
			G git = null
		)
		{
			return Result(
				new nilnul.fs.git.svr.repo.Name(remoteCfgKey)
				, git
			);
		}
	}
}