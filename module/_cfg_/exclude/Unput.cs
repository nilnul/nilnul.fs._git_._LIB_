﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_.exclude
{
	/// <summary>
	/// create the file if not exist;
	/// patch the ignore file to reflect dotnet ignores if exists
	/// </summary>
	static public class UnputX
	{
		
		static public void Exe(nilnul.fs.git.ModuleI top, IEnumerable<string> lines2exclude)
		{
			if (nilnul.fs.git.module._ignore_.exclude.be_.ExistsDoc.Be(top))
			{
				nilnul.fs.git.module._ignore_.exclude._DepatchX._OfModule(top, lines2exclude);

			}
			

		}


		



	}
}
