using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.repo.div
{
	static public class _RootOfRepoX
	{
		static public string Exe_ofAddress(
			string divAddress, nilnul.win.prog_.Git git =null
		) {
			return _Exe_ofShield(
				nilnul.fs.address_.shield_._AddressX1.Txt(divAddress)
				,git
			);
		}
		static public string _Exe_ofShield(
			string _divShield, nilnul.win.prog_.Git git =null
		) {
			var gitDir =nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_divShield, "rev-parse --git-dir",git
			);
			if (gitDir==".")
			{
				return _divShield;
			}
			else
			{
				return gitDir;
			}

		}


	}
}
