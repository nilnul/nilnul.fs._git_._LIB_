﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directory_.unLink.dirs_
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// the dir itself is not symlink
	/// </summary>
	static public class _UnLinkX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string workDirectoryUnLink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _work_.directory._DirsX.Addresses_ofAddress(
				workDirectoryUnLink, git
			).Where(
				nilnul.fs.folder.dir.be_.symlink._AntoX._Be_assumeAddressAsParented
			);
		}
	}
}
