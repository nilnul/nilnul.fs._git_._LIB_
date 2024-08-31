using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.fs.folder_.git_;
using nilnul.fs.git;
using nilnul.win.prog._run;
using nilnul.win.prog_;

namespace nilnul.os.prog_.git.run_.exit_.onDue.result
{
	public class _Vow_codOkX
	{
		public static void _Vow_0worksite(
			string _workingDir,
			string argument,
			nilnul.win.prog_.Git git = null
			)
		{
			//nilnul.win.prog._run.result._Void_throwErrX.Void
			proc_.finished._result.CodMsgErr r = _ResultX._Result_assumeAddress(
				_workingDir
				,
				argument
				,
				git
			);

			if (r.beErr)
			{
				throw new Exception($"when running git {argument} @ {_workingDir}: {r.ToString()}");
			}
			//nilnul.os.proc_.finished._result.data._Vow_codOkX.Vow
			//	(
			//	r
			//);
		}


		public static void Vow(
			nilnul.fs.address_.ShieldI tgtShield,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			_Vow_0worksite(
				tgtShield.ToString()
				,
				arg
				,
				git
			);
		}

		public static void OfAddress(
			string  module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			 Vow(
				nilnul.fs.address_.Shield.FroAddress(module)
				,
				arg
				,
				git

			);


		}
		public static void _Vow_0worksite(
			string module
			,
			Args1 args1
			,
			win.prog_.Git git
		)
		{
			_Vow_0worksite(module, args1.ToString(), git);
		}

		public static void OfAddress(
			string module
			,
			Args1 args1
			,
			win.prog_.Git git
		)
		{
			OfAddress(module, args1.ToString(), git);
		}


		public static void OfAddress(
			string module
			, IEnumerable<Arg1> enumerable
			, win.prog_.Git git)
		{
			OfAddress(
				module
				,
				new nilnul.win.prog._run.Args1(enumerable)
				,
				git
			);
		}

		public static void _Vow_0worksite(
			string module
			,
			IEnumerable<Arg1> enumerable
			,
			win.prog_.Git git
		)
		{
			_Vow_0worksite(
				module
				,
				new nilnul.win.prog._run.Args1(enumerable)
				,
				git
			);
		}

		public static void _Vow_0worksite(
			string module
			,
			IEnumerable<string> enumerable
			,
			win.prog_.Git git
		)
		{
			_Vow_0worksite(
				module
				,
				enumerable.Select(x=> new Arg1(x))
				,
				git
			);
		}

		public static void _Vow_0worksite(
			string module
			,
			win.prog_.Git git
			,
			IEnumerable<string> enumerable
		)
		{
			_Vow_0worksite(
				module
				,
				enumerable
				,
				git
			);
		}

		public static void _Vow_0worksite(
			string module
			,
			win.prog_.Git git
			,
			params string[] enumerable
		)
		{
			_Vow_0worksite(
				module
				,
				git
				,
				(IEnumerable<string>)enumerable
			);
		}



		public static void OfAddress(
			string module
			,
			IEnumerable<string> args
			,
			nilnul.win.prog_.Git git = null
			)
		{
			OfAddress(
			   module
			   ,
			   args.Select(a => new nilnul.win.prog._run.Arg1(a))
			   ,
			   git
		   );
		}



		public static void Vow(
			nilnul.fs.FolderI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			Vow(
				(module).address.en
				,
				arg,git
			);
		}
		public static void Vow(nilnul.fs.folder_.git_.work_.Top module, string v, Git git=null)
		{
			Vow((module).folder, v,git);
		}

		public static void Vow(Top module, string v, Git git=null)
		{
			Vow((module).folder, v,git);
		}

		public static void Vow(
			nilnul.fs.git.ModuleI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			Vow(module.top1, arg,git);
		}

		public static void Vow(
			nilnul.fs.git.Module module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			Vow((ModuleI)module,arg,git);
		}

	}
}
