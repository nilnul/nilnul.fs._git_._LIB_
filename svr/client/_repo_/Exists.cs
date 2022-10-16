using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client._repo_
{
	public interface  ExistsI
	{
		/// <summary>
		/// check whether the repo is there or not
		/// </summary>
		/// <param name="name"></param>
		bool exists(nilnul.fs.git.svr.repo.Name name);
	}
}
