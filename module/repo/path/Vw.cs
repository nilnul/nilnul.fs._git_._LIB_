using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.git.module.repo.path
{
	static public class _VwX
	{

		/// <summary>
		/// </summary>
		/// <param name="git"></param>
		/// <returns>
		/// such as ".git"
		/// </returns>
		static public string Path_assumeWorktop(string workTop, nilnul.win.prog_.Git git = null)
		{

			win.prog._run.Result result = nilnul.win.prog_.git.run._ResultX1.Result_ofAddress(workTop, "rev-parse --git-dir", git);

			if (result.notBeErr)
			{
				string root = result.msg.ToString().Trim();
				return (root);
			}
			else
			{
				throw new nilnul.win.prog_._git.ReportErrException(
					result.err
				);
			}
		}
	}
}