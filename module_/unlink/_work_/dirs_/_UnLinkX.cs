﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_.unlink._work_.dirs_
{
	static public class _UnLinkX
	{
	

		static public IEnumerable<string> Addresses_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return _DirsX.Addresses_ofAddress(module, git).Where(
				x=> nilnul.fs.folder.be_.Normal.Singleton.be_ofAddress(x)
			);
			
		}

		

	}
}
