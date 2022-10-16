using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo
{
	static public class _UrlX
	{

		public static string RepoName(
			web._url._resource._render._route.DivisionI url
		)
		{
			string repoName;
			switch (url)
			{
				case nilnul.web._url._resource._render._route.Div div:
					repoName = div.dirs.Last().name;
					break;
				case nilnul.web._url._resource._render._route.div.Document document:
					repoName = document.doc.ToString(

					);
					break;
				default:
					throw new UnexpectedTypeException($"the type:{url.GetType()} of {url} is not div or document ");
					break;
			}
			return repoName;
		}

		public static string RepoName(
			web.Url3 url
		)
		{
			return RepoName(
				url.resource.render.route.division
			);
		}


	}
}
