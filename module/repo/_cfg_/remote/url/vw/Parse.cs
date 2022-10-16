using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.remote.url
{
	public class Parse
	{
		public const string BareRepoEnding = ".git";

		static public string GetSprout(string url) {
			return url.Substring(
				url.LastIndexOf('/')	
			);
		}

		//static public nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.Brand GetBrand(string url) {

		//	var url1=nilnul.web.url._ParseX3.Parse(url);
		//	var host = url1.origin.authority.socket.host;
		//	switch (host)
		//	{
		//		case nilnul.web._url._origin._authority._socket.host_.named_.DomainedI domained:
		//			return domained.domain.brand;
		//			break;
		//		default:
		//			break;
		//	}

		//	return url1.origin.authority.socket.host.brand;
		//}

		static public string GetRepoNameFroVs(string url) {
			return GetSprout(url);
		}

		/// <summary>
		/// if ended with ".git", ".git" would be removed; otherwise, intact.
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		static public string GetRepoName(string url) {
			var tip = GetSprout(url);
			var bareIndex = tip.LastIndexOf(BareRepoEnding);

			if (bareIndex >=0 )
			{
				return tip.Substring(0, bareIndex);
			}
			return tip;
		}
	}
}
