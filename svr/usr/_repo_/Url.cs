using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client._repo_
{
	public interface  UrlI
	{
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		nilnul.web.Url4 url(nilnul.fs.git.svr.repo.Name name);
	}
}
