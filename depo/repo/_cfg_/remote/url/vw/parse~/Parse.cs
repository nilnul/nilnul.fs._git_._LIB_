using System;

namespace nilnul.dev.git.module.cfg.remote.url
{
	/// <summary>
	/// parse the url to get: such as repoName
	/// </summary>
	/// 
	[Obsolete()]
	public class Parse
	{
		public const string BareRepoEnding = ".git";

		public static string GetSprout(string url)
		{
			return url.Substring(
				url.LastIndexOf('/')
			);
		}

		//public static nilnul.web._url._origin._authority._socket.host_.named_._domained._domain.Brand GetBrand(string url)
		//{

		//	web.Url3 url1 = nilnul.web.url._ParseX3.Parse(url);
		//	web._url._origin._authority._socket.HostI1 host = url1.origin.authority.socket.host;

		//	switch (host)
		//	{
		//		case nilnul.web._url._origin._authority._socket.host_.NamedI named:
		//			switch (named)
		//			{
		//				case nilnul.web._url._origin._authority._socket.host_.named_.DomainedI domained:
		//					return domained.domain.brand;
		//					break;
		//				default:
		//					throw new UnexpectedTypeException($"{url} is of type {typeof(nilnul.web._url._origin._authority._socket.host_.NamedI)} but not {typeof(nilnul.web._url._origin._authority._socket.host_.named_.DomainedI)}, such that no Brand can be retrieved.");
		//					break;
		//			}
		//			break;
		//		default:
		//			throw new UnexpectedTypeException($"{url} is not of type {typeof(nilnul.web._url._origin._authority._socket.host_.NamedI)} (may be of type IP?), so no Brand can be retrieved.");
		//			break;
		//	}
		//}

		public static string GetRepoNameFroVs(string url)
		{
			return GetSprout(url);
		}

		/// <summary>
		/// if ended with ".git", ".git" would be removed; otherwise, intact.
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		public static string GetRepoName(string url)
		{
			string tip = GetSprout(url);
			int bareIndex = tip.LastIndexOf(BareRepoEnding);

			if (bareIndex >= 0)
			{
				return tip.Substring(0, bareIndex);
			}
			return tip;
		}
	}
}
