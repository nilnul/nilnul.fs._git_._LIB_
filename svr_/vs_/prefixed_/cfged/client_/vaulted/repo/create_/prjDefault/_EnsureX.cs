using System;
using System.Diagnostics;
using System.Net;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.svr_.vs_.prefixed_.cfged.client_.vaulted.repo.create_.prjDefault
{

	static public class _EnsureX
	{
		public static string Ret(
			//nilnul.fs.git.ModuleI gitTop
			//, 
			nilnul.fs.git.svr_.vs.repo.Name repoName
			,
			G git = null
		)
		{

			try
			{
				return _PrjDefaultX.Ret(
						repoName
				) ?? ""; ;
			}
			catch (System.Net.WebException e)
			{

				//if (e.Error.GetType().Name == "WebException")
				//{
				//WebException we =e.Error;
				if (e.Response == null)//{"未能解析此远程名称: '****.visualstudio.com'"}
				{
					Trace.TraceError( "Response is null:  " + e.ToString());
					throw;
				}
				HttpWebResponse response = (System.Net.HttpWebResponse)e.Response;
				if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					return "BadRequest error possibly due to that the repo has already existed:  " + e.ToString();
				}
				else
				{
					Trace.TraceError($"{typeof(_EnsureX)}.{nameof(Ret)}(repoName:{repoName}, {nameof(git)}:{git}) with WebException caught:{e}");
					throw;
				}
			}
			catch (Exception ex)
			{
				Trace.TraceError($"{typeof(_EnsureX)}.{nameof(Ret)}(repoName:{repoName}, {nameof(git)}:{git}):{ex}");
				throw;
			}
		}

		public static string Ret_repo2Normal(string repoName, G git = null)
		{
			return Ret(

				 vs.repo.Name.ByEncode(repoName)
			);
		}

		public static string Ret_repoNameAlreadyNormalized(string repoName, G git = null)
		{
			return Ret(

				 new vs.repo.Name(repoName)
			);
		}


		public static nilnul._op.result_.explain_.RetTxt Result(

			nilnul.fs.git.svr_.vs.repo.Name repoName
			,
			G git = null
		)
		{
			try
			{
				return new _op.result_.explain_.RetTxt(
					Ret(
						(repoName)
					) ?? ""
				);
			}
			catch (System.Net.WebException e)
			{

				return _op.result_.explain_.RetTxt.FroXpn(e.ToString());
			};
		}


		public static nilnul._op.result_.explain_.RetTxt Result_repoName2Normal(

			string repoName
			,
			G git = null
		)
		{
			return Result(

				nilnul.fs.git.svr_.vs.repo.Name.ByEncode(repoName)
				, git
			);
		}

		public static nilnul._op.result_.explain_.RetTxt Result_repoNameAlreadyNormal(

			string repoName
			,
			G git = null
		)
		{
			return Result(

				new nilnul.fs.git.svr_.vs.repo.Name(repoName)
				, git
			);
		}


		public static string ResultAsTxt_repoName2Normal(

			string repoName
			,
			G git = null
		)
		{
			return Result_repoName2Normal(

				repoName
				, git
			).ToString();
		}

		public static string ResultAsTxt_repoNameAlreadyNormal(

			string repoName
			,
			G git = null
		)
		{
			return Result_repoNameAlreadyNormal(

				repoName
				, git
			).ToString();
		}

	}
}