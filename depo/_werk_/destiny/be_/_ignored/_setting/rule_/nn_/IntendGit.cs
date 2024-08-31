using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_.rule_.nn_
{
	/// we need the <see cref="depo._werk_.destiny.be_._ignored._setting.IRule"/> to work.
	/// so we cannot use regex, but wildcard and range.
	/// 
	/// <summary>
	/// 
	/// </summary>
	///

	static public class _IntendGitX
	{

		public const string _INTEND_GIT_SUFFIX = "(Git";

		/// <summary>
		/// if for a project, we need a ver, the ver shall be prepend to the suffix like:
		///		nilnul.project(1(Git
		/// </summary>
		/// <remarks>
		/// not only the dir at root, but also at any underlevel;
		/// </remarks>
		/// ??:
		///		Git)
		///	eg:
		///		abc.efg(Git
		///		abc.efg(1(Git, where nilnul.txt_.Vered is defined before this project, and for "(1(Git", the nilnul.lang_._cot_ is defined later for nilnul.dev.

		public const string INTEND_GIT = "*" + _INTEND_GIT_SUFFIX + "/";


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
