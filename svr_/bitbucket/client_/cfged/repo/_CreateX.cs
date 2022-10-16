using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bb.client_.cfged.repo
{
	static public class _CreateX
	{


		static public string Ret(string prjName)
		{

			return bb.client.repo._CreateX.ByBasicUser_useWebRequest(
				
				Cfged.Singleton.credential.username
				,
				Cfged.Singleton.credential.password,
				prjName
			);
		}
		static public string Result(string prjName)
		{
			try
			{
				return Ret(
					prjName
				);

			}
			catch (Exception e)
			{
				return e.Message;

				//throw;
			}
		}

		
	}
}