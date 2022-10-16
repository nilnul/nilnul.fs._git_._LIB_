using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.div
{
	static public class _RootX
	{
		/*
	   Show the absolute path of the top - level directory.*/
		static public string Exe_ofAddress(string div, nilnul.win.prog_.Git git=null)
		{
			return ( nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				div,
				"rev-parse --show-toplevel"
				,git
			));
		}
	}
}
