using System.Collections.Generic;

namespace nilnul.fs.git.depo._werk_.dossiers_
{
	
	/// <summary>
	/// tracked file are not shown
	/// untracked files, including those ignored, are shown;
	/// </summary>
	/// <remarks>
	/// per verification, tracked files are not shown;
	/// </remarks>
	/// 
	static public class _UntrackedX
	{
		/// <summary>
		/// For “untracked” (will include ignored files, if present):
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public os.proc_.finished._result.CodMsgErr _Result_0depo(string gitTop, nilnul.os.prog_.Git git = null)
		{
			var result = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(    
				gitTop, "ls-files --others"  ///Standard ignore rules are not automatically activated; inconsistent with <see cref="_included_.by_.LsFiles"/>;
				/// where -o can replace --others
				,
				git
			);


			return result;
		}

		static public IEnumerable<string> _GetDossiers_0depo(
			string depo
			,
			nilnul.os.prog_.Git git=null
		) {
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					depo
					,
					"ls-files --others"	//-o 

					,
					git
				)
			);
		}

	

	}

}
