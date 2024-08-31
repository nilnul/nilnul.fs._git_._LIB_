using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.git.repo.remote;

namespace nilnul.fs.git.repo._reference
{
	/// <summary>
	/// the name in the config for a remote
	/// </summary>
	public class Name : _name.txt.be.vow.En
	{
		public Name(string val) : base(val)
		{
		}

		static public Name OvBranch(_branch.Name branch) {
			return new Name($"refs/heads/{branch}");
		}

		static public Name OvBranch(string branch) {
			return OvBranch(new _branch.Name(branch));
		}
		static public Name OvRemoteBranch(nilnul.fs.git.module.repo._cfg_._remote.Name remote,  _branch.Name branch) {
			return new Name($"refs/remotes/{remote}/{branch}");
		}

		static public Name OvRemoteBranch( nilnul.fs.git.module.repo._cfg_._remote.Name remote, string branch) {
			return OvRemoteBranch(
				remote,
				
				new _branch.Name(branch)
			);
		}

		static public Name OvRemoteBranch( string remote, string branch) {
			return OvRemoteBranch(
				new module.repo._cfg_._remote.Name(
				remote),
				
				(branch)
			);
		}
		public static Name OvRemoteBranch(Branch branch)
		{
			return OvRemoteBranch(
				branch.remote
				,
				branch.branch
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="remoteBranch">like: remote1/branch1</param>
		/// <returns></returns>
		static public Name OvRemoteBranch( string remoteBranch) {
			return OvRemoteBranch(

				nilnul.fs.git.repo.remote.Branch.Parse(remoteBranch)
				
			);
		}

	}
}
