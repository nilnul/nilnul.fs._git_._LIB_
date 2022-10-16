using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest.nulable.url
{
	static public class _IsInPlaceX
	{
		static public bool IsInPlace(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._cfg_._remote.key_._vered.Name key
			,
			string url
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var newestKey = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(module, key,git);
			if (
				newestKey == null
				||
				!nilnul.txt.eq_.Trim.Singleton.Equals(
					nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(module, key, git)
					, url
				)
			)
			{
				
				return true;

			}
			return false;
		}
		static public bool IsInPlace(
			nilnul.fs.git.ModuleI module
			,
			string key
			,
			string url
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return IsInPlace(module
				,
				new _remote.key_._vered.Name(key)
				,
				url
				,
				git
			);
		}
		static public bool IsInPlace(
			string module
			,
			string key
			,
			string url
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return IsInPlace(
				nilnul.fs.git.Module.FroAddress(
					module
				)
				,
				(key)
				,
				url
				,
				git
			);
		}

	}
}
