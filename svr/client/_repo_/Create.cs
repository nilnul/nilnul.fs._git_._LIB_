using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client._repo_
{
	public interface  CreateI
	{
		/// <summary>
		/// create it. if the repo is already on the svr, an exception might be thrown
		/// </summary>
		/// <param name="name"></param>
		void create(nilnul.fs.git.svr.repo.Name name);
	}
}
