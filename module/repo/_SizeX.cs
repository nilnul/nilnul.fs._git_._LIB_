using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	/// <summary>
	/// only unpacked objects to help decide whether to repack?
	/// </summary>
	static public class _SizeX
	{

		public const int milisecondsNeeded = 30 * 60 * 1000;        //if timeout, the returned code is -1.
																	//todo: make the process cancellable by a UI to view dangling process

		/*
		 For nilnul.win.prog_.Git, you can use the following command:

git count-objects -v 
This should return a result similar to this:

$ git count-objects -v 
count: 0
size: 0
in-pack: 478
packs: 1
size-pack: 92
prune-packable: 0
garbage: 0
The size-pack value is the size of your repository when it is pushed to a remote server like Bitbucket. The size-pack value is in kilobytes.  So, in the above example the repository is not even 1 MB.  
		 */
		/*
		git count-objects -vH
		  appends unit Human readable
			*/

		/// <summary>
		/// human readable
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <returns></returns>

		public static os.proc_.finished._result.CodMsgErr Result4human(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git = null, int? life = null)
		{
			return nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(module, "count-objects -vH", git, life ?? milisecondsNeeded);

		}

		/// <summary>
		/// this will return 0 if gc-ed (packed).
		/// </summary>
		/// <param name="module"></param>
		/// <param name="git"></param>
		/// <param name="life"></param>
		/// <returns></returns>
		///
		//[Obsolete("this will return 0 if gc-ed (packed)")]
		public static int Kb(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git = null
			, int? life = null
		)
		{
			var msg = nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
					//nilnul.win.prog_.git.run_.timeout.result._MsgX.Msg
					nilnul.os.prog_.git.run_.exit_.onDue.result_.stdSyn._MsgX.Msg

					(
						module
						,
						"count-objects -v"
						,
						git
						, life ?? milisecondsNeeded

					)
				);

			return int.Parse(
					msg.First(
						l => l.StartsWith("size-pack")
					).Split(
						new[] { ':' }
						,
						StringSplitOptions.RemoveEmptyEntries
					).Last().Trim()
				)
				+
				int.Parse(
					msg.First(
						l => l.StartsWith("size")
					).Split(
						new[] { ':' }
						,
						StringSplitOptions.RemoveEmptyEntries
					).Last().Trim()
				)
			;


		}

		//[Obsolete("this will return 0 if gc-ed (packed)")]

		public static int Kb_ofWorkDivAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
			, int? life = null
		)
		{
			return Kb(
				nilnul.fs.git.Module.OvInnerDivAddress(module), git, life

);
		}

		public static int Kb_addressAssumeModule(
			string module
			,
			nilnul.win.prog_.Git git = null
			,
			int? life = null
		)
		{
			return Kb(
				nilnul.fs.git.Module.FroAddress(module), git, life

);
		}


	}
}
