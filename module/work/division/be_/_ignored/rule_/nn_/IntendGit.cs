using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_.rule_.nn_
{
	static public class _IntendGitX
	{
		public const string _INTEND_GIT_SUFFIX = "(Git";

		public const string INTEND_GIT = "**/*" + _INTEND_GIT_SUFFIX + "/";


		static public bool IsIntend_ofDenote(nilnul.NotNull2<string> shield)
		{
			return shield.val.EndsWith(_INTEND_GIT_SUFFIX);
		}

		static public bool IsIntend(nilnul.fs.address_.ShieldI shield)
		{
			return (shield.stem.div.dirs.LastOrDefault().denote.ToString() ?? "").EndsWith(_INTEND_GIT_SUFFIX);
		}

		static public bool IsIntend_ofShieldAddress(string shieldAddress)
		{
			return IsIntend(nilnul.fs.address_.shield_._AddressX1.Create(shieldAddress));
		}

	}
}
