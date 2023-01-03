using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage
{
	/*
	 git ls-files --stage
	 */
	static public class _FilesX
	{
		/// <summary>
		/// Without the -s option the git ls-files output is simply a list of file names and paths that are currently part of the index.
		/// </summary>
		/// <param name="module"></param>
		/// <returns></returns>
		static public string Show(string module) {

			return nilnul.win.prog_.git.run.result._MsgX.OfAddress(module, "ls-files");
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <returns>
		/// 		/// 100644 e69de29bb2d1d6434b8b29ae775ad8c2e48c5391 0   reset_lifecycle_file
		/// </returns>
		static public os.proc_.finished._result.CodMsgErr _ResultOnDue_addressAssumeModule(string module) {

			return nilnul.os.prog_.git.run_.exit_.onDue._ResultX._Result_assumeAddress(module, "ls-files -s");
		}


	}
}
