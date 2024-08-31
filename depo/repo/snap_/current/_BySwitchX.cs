using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap_.current
{
	static public class _VwX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_addressAssumeModule"></param>
		/// <param name="git"></param>
		/// <returns>
		/// eg:
		///commit 2c...03 (HEAD, master)
		///Author: WANG,Youtian<wangyoutian@nilnul.com>
		///Date:   Mon Jan 2 18:06:11 2023 +0800
		/// </returns>
		static public os.proc_.finished._result.CodMsgErr _Vw_addressAssumeModule(
			string _addressAssumeModule
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(
				_addressAssumeModule
				,
				$"show HEAD" 
				,
				git
			);
		}

	}
}
