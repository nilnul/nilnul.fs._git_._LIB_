using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using nilnul.fs;
using nilnul.fs.folder_.git_;
using nilnul.fs.git;
using nilnul.win.prog._run;

namespace nilnul.os.prog_.git.run_.exit.cod.vow_
{
	//[Obsolete(nameof(prog_.git.run.result._Void_throwErrX))]   Note: exitCode can be got simpler than result as the latter requires async, Noshell(or shell?)
	public class _NilX
	{

		public static void _Vod_ofAddress_ofArgs(string module, params string[] args)
		{
			_Vod_0nulable_1address_2args(null, module, args);

			//nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
			//   run_.exit._CodX._Cod_ofDir9args(module, args)
		 //  );
		}
		public static void _Vod_0address_1args(string module, params string[] args)
		{
			_Vod_0nulable_1address_2args(
				null,
				module,args
			); 
			
		}
		public static void _Vod_0nulable_1address_2args(nilnul.os.prog_.Git git, string module, params string[] args)
		{
			_Vod_0nulable_1address(git,module, args.Select(a => new Arg1(a)));

			//nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
			//   run_.exit._CodX._Cod_1address_2args(git, module, args)
		 //  );
		}

		public static void _Vod_0nulable_1address(nilnul.os.prog_.Git git, string module, IEnumerable< Arg1> args)
		{


			_Vod_0address_2nulable(
				module,new nilnul.win.prog._run.Args1( args),git
			);
		}

		public static void _Vod_0address_2nulable(string module, Args1 args1, Git git=null)
		{
			_Vod_0address_1argument(module, args1.ToString(), git);
		}

		public static void _Vod_ofAddress_ofArg(string module, string args, nilnul.win.prog_.Git git = null)
		{
			_Vod_0address_1argument(module, args, git);

			//nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
			//   run_.exit._CodX._Cod_ofDir9argument9cmd(module, args, git)
		 //  );

		}


		public static void _Vod_0address_1argument(string module, string argument, nilnul.win.prog_.Git git = null)
		{

			int obj = run_.exit._CodX._Cod_ofDir9argument9cmd(module, argument, git);
			if (obj != 0)
			{
				throw new Exception($"when running git {argument} @ {module}: {obj}");

			}

			//nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
			//	obj
			//);
		}




		public static void Void(
			nilnul.fs.address_.ShieldI module,
			string arg,
			string xpn
			,
			nilnul.win.prog_.Git git = null
		)
		{
			new nilnul.num.integer_.int32.be_.nil.Vow(xpn).vow(
				run_.exit._CodX._Cod_1argument(module, arg, git)
			);
		}

		public static void Void(ModuleI module
			,
			string v1
			,
			string v2
			,
			nilnul.win.prog_.Git git = null

		)
		{
			Void(
				module.top1.en.address.en, v1, v2
				, git
			);
		}

		public static void Void(
			nilnul.fs.address_.ShieldI module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			_Vod_0address_1argument(module.ToString(),arg,git);

			//nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
			//	run_.exit._CodX._Cod_1argument(module, arg, git)
			//);
		}

		public static void Void(FolderI en, string v, Git git = null)
		{
			Void(en.address.en, v, git);
		}

		public static void Void(
			Top module
			, string v
			,
			nilnul.win.prog_.Git git = null
			)
		{
			Void(module.en, v, git);
		}

		public static void Void(
			fs.folder_.git_.work_.Top module
			, string v
			,
			nilnul.win.prog_.Git git = null
			)
		{
			Void(module.en, v, git);
		}

		public static void OfAddress(
			string module,
			string arg,
			nilnul.win.prog_.Git git = null
			)
		{
			Void(
			   nilnul.fs.address_.Shield.FroAddress(module)
			   ,
			   arg
			   ,
			   git

		   );


		}



		public static void Void(ModuleI folder, string v, Git git = null)
		{
			Void(folder.top, v, git);
		}

		public static void OfAddress(
			string module,
			string arg,
			string xpn
			,
			nilnul.win.prog_.Git git = null
			)
		{
			Void(
			   nilnul.fs.address_.Shield.Parse(module)
			   ,
			   arg
			   , xpn
			   ,
			   git

		   );


		}

	}
}
