﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net.Http;
using System.Net;
using System.IO;
using nilnul.dev.git.svr_.gitlab;

namespace nilnul.fs.git.svr_.gitlab.acc_.token._repo
{
	static public class _CreateX
	{
		/// <summary>
		/// "." will be replaced with "-" for the dir, but not the name.
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="name">
		/// the server reports an error if not normalized
		/// 
		/// must be normalized as the server will not do it automatically
		/// for creation, the name is converted by the server
		/// </param>
		/// <returns></returns>

		static public string Txt(nilnul.web._url._query._entry.Term privateToken, gitlab.repo.Name name)
		{
			var url = _PrjsX.Address(privateToken);// $"{Projects.UrlBase_v3}?private_token={privateToken}";	//it seems sometimes UrlBase works, sometime UrlBase_v3 works

			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "POST";

			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new
				{
					name = name

				});

				streamWriter.Write(json);
				//streamWriter.Flush();

			}

			var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using (
				var streamReader = new StreamReader(httpResponse.GetResponseStream())
			)
			{
				var result = streamReader.ReadToEnd();
				return result;
			}



		}


		[Obsolete()]
		static public string Result(nilnul.web._url._query._entry.Term privateToken, nilnul.fs.git.svr_.gitlab.repo.Name prj)
		{
			try
			{
				return Txt(
					privateToken
					,
					prj
				);

			}
			catch (Exception e)
			{
				return e.Message;

				//throw;
			}
		}
		static public nilnul._op.result_.explain_.RetTxt Result1(nilnul.web._url._query._entry.Term privateToken, nilnul.fs.git.svr_.gitlab.repo.Name prj)
		{
			try
			{
				return new _op.result_.explain_.RetTxt(
						Txt(
						privateToken
						,
						prj
					)
				);

			}
			catch (Exception e)
			{
				return  _op.result_.explain_.RetTxt.FroXpn( e.ToString());
				//throw;
			}
		}


	}
}
