﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_.unlink._work_.directory
{
	/// <summary>
	/// not repo;
	/// not submodule
	/// </summary>
	static public class _DivsX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string workDirectory
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var directory in _DirectoriesX.Addresses_ofAddress(workDirectory))
			{
				yield return directory;
			}
			yield return workDirectory;
		}
	}
}
