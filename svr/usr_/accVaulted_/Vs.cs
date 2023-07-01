using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.accVaulted_
{
	public interface VsI :svr.client_.AccVaultedI{
		string prefix { get; }
	}

}
