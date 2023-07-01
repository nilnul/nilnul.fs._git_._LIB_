using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.usr.teamwork
{
	/// <summary>
	/// the repos under a teamwork.
	/// </summary>
	///  in gitlab, a teamwork corresponds to one repo. and repo is a sibling term with respect to teamwork when it comes to URL component sequence.
	/// in azure, a teamspace corresponds to multiple repos. and repo is placed under teamspace when it comes to URL component sequencing.
	public interface IRepos
	{
	}
}
