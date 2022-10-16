using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.bitbucket.client.repo.size
{
	/*
	 We recommend repositories be kept under 1.0 GB to help ensure that our servers are fast and downloads are quick for our users. Bitbucket Cloud repositories have a 2.0 GB limit. When that limit is reached, you will only be able to push changes that undo the latest commits. There is also a hard limit of 5.0 GB. When that limit is reached, you will not be able to push any changes, and your repository becomes read-only.

	 */
	interface ILimit
	{
	}
}
