using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_.repo.be_
{
	public class _BareX
	{
		[Obsolete()]
		static public bool _Be_ofAddress(string _repoAddress, Git git=null) {
			return nilnul.fs.git.repo.be_._BareX._Be_ofAddress(_repoAddress,git);
		}

		static public bool _Be_assumeRepoAddress(string _repoAddress, Git git=null) {
			return nilnul.fs.git.repo.be_._BareX._Be_assumeRepoAddress(_repoAddress,git);
		}

		[Obsolete()]
		static public bool _Be(nilnul.fs.FolderI _repoAddress, Git git=null) {
			return _Be_ofAddress(_repoAddress.ToString(), git );
		}

		static public bool _Be_assumeRepo(nilnul.fs.FolderI _repoAddress, Git git=null) {
			return _Be_assumeRepoAddress(_repoAddress.ToString(), git );
		}


	}
}
