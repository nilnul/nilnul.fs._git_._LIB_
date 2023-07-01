using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client._repo_
{
	public interface  EnsureI
	{
		/// <summary>
		/// if the repo is not there, create it
		/// </summary>
		/// <param name="name"></param>
		void ensure(nilnul.fs.git.svr.repo.Name name);
	}
}
