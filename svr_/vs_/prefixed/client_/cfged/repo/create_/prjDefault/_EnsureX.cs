using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.svr_.vs_.prefixed.client_.cfged.repo.create_.prjDefault
{

	static public class _EnsureX
	{
		public static string Ret(
			//nilnul.fs.git.ModuleI gitTop
			//, 
			nilnul.fs.git.svr_.vs.repo.Name repoName
			,
			G git=null
		)
		{
			try
			{
				return _PrjDefaultX.Ret(
						repoName
				);;
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
					throw ;
				}
			}
		}

		public static string Ret( string remoteCfgKey, G git=null)
		{
			return Ret(
				
				 vs.repo.Name.ByEncode(remoteCfgKey)
			);
		}

		public static nilnul._op.result_.explain_.RetTxt Result(
			
			nilnul.fs.git.svr_.vs.repo.Name repoName
			,
			G git=null
		)
		{
			try
			{
				return new _op.result_.explain_.RetTxt( 
					Ret(
						nilnul.fs.git.svr_.vs.repo.Name.ByEncode(repoName)
					)
				);
			}
			catch (System.Net.WebException e)
			{

				return _op.result_.explain_.RetTxt.FroXpn( e.ToString());
			} ;
		}


		public static nilnul._op.result_.explain_.RetTxt Result(
			
			string remoteCfgKey
			,
			G git=null
		)
		{
			return Result(
				
				nilnul.fs.git.svr_.vs.repo.Name.ByEncode(remoteCfgKey)
				,git
			);
		}
		
		
	}
}