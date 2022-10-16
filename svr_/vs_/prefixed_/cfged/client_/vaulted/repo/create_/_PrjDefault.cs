using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using nilnul.fs.git.svr_.vs.repo;

namespace nilnul.fs.git.svr_.vs_.prefixed_.cfged.client_.vaulted.repo.create_
{
	static public class _PrjDefaultX
	{
		static public string Ret(
			 string username, string password, nilnul.fs.git.svr_.vs.repo.Name prjName, string version= "2.0-preview"
		)
		{
			return prefixed.client_.cfged.repo.create_._PrjDefaultX.Ret(
				_PrefixedX.Cfged
				,
				username
				,
				password
				,
				prjName
				,
				version
			);
		}


		public static string Ret( vs_.prefixed.Client client, Name prjName, string version)
		{
			return Ret( client.credential.username,client.credential.password,prjName,version);
		}

		static public string Ret(
			nilnul.fs.git.svr_.vs.repo.Name prjName, string version = "2.0-preview"
		)
		{
			return Ret(
				 prefixed.client_._CfgedX.GetClient(), prjName,version
			);
		}
		static public string Ret_prjNameNotNormalized(
			 string username, string password, string prjName, string version
		)
		{
			return Ret( username, password, nilnul.fs.git.svr_.vs.repo.Name.ByEncode(prjName), version);
		}

		static public string Ret_prjNameAlreadyNormalized(
			 string username, string password, string prjName, string version
		)
		{
			return Ret( username, password, new nilnul.fs.git.svr_.vs.repo.Name(prjName), version);
		}

	}
}