using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._dst.denote.op_.unary_.git_
{
	static public class _IntendGitX
	{
		static public string _Append(string denote) {
			return denote + nilnul.fs.git.module._ignore_.rule_.nn_._IntendGitX._INTEND_GIT_SUFFIX;
		}

		static public string _Ensure(string denote) {
			return be_.git_.IntendGit.Singleton._be(denote) ?denote : _Append(denote);
		}

		static public nilnul.fs._address._dst.Denote _Append(nilnul.fs._address._dst.Denote denote) {
			return new Denote( _Append(denote));
		}

		static public nilnul.fs._address._dst.Denote _Op(nilnul.fs._address._dst.Denote denote) {
			return new Denote( _Ensure(denote));
		}



	}
}
