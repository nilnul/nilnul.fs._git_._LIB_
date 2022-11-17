//using nilnul.fs;
using nilnul.fs;
using nilnul.fs.address_.spear;
using nilnul.fs.folder_.git_;
using nilnul.fs.git;
using System;
using System.Diagnostics;
using System.IO;

namespace nilnul.win.prog_
{
	public class Git
	{


		/// <summary>
		/// --version to show version
		/// </summary>
		/// 



		public const string DENOTE_IN_Program = "Git";


		public static nilnul.fs._address.Dir DirInProgram = nilnul.fs._address.Dir.OvDenote(DENOTE_IN_Program);



		//public static void RunCmd_retVoid(Work work, string v)
		//{
		//	RunCmd_retVoid(work.en, v);

		//}

		public static nilnul.fs._address.Div DivInProgram = new fs._address.Div(DirInProgram);


		public static nilnul.fs.address_.ShieldI Container64 = new nilnul.fs.address_.shield_.BaseDiv(
			 nilnul.win.Programs.Container64_1
			,
			 DivInProgram
		);

		public static nilnul.fs.address_.ShieldI Container86 = new nilnul.fs.address_.shield_.BaseDiv(
			 nilnul.win.Programs.Container86_1
			,

			 DivInProgram

		);



		//public void init(string location)
		//{
		//	nilnul.win.prog._run.Result r = runCmd__returnResult(location, "init");
		//	if (r.notBeErr)
		//	{
		//		throw new _git.ReportErrException(r.err);

		//	}
		//}

		//public static int Run_retExitCode(fs.git.Module folder, string v, nilnul.win.prog_.Git git)
		//{
		//	return (git ?? Git.StaticInstance).run_retExitCode(folder, v);
		//	//throw new NotImplementedException();
		//}
		//public static int Run_retExitCode_winTitled(fs.git.Module folder, string v, nilnul.win.prog_.Git git)
		//{
		//	return (git ?? nilnul.win.prog_.git.run.).run_retExitCode_windowTitled(folder, v);
		//	//throw new NotImplementedException();
		//}

		//public static int Run_retExitCode_winTitled(string folder, string v, nilnul.win.prog_.Git git)
		//{
		//	return (git ?? nilnul.win.prog_.git.run.).run_retExitCode_windowTitled(folder, v);
		//	//throw new NotImplementedException();
		//}



		//public int run_retExitCode(Top workingDir, string v)
		//{
		//	return run_retExitCode(workingDir.ToString(), v);
		//	//throw new NotImplementedException();
		//}
		//public int run_retExitCode_windowTitled(Top workingDir, string v)
		//{
		//	return run_retExitCode_windowTitled(workingDir.ToString(), v);
		//	//throw new NotImplementedException();
		//}


		public const string GIT_INSTALLED_DIRECTORY = @"C:\Program Files (x86)\Git";


		//public string runCmd__retResult_throwErr(nilnul.fs.folder_.git_.Top folder, string v)
		//{
		//	return runCmd__retResult_throwErr(folder.ToString(), v);
		//}
		//public static string RunCmd__retMsg_throwErr(nilnul.fs.folder_.git_.Top folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__retResult_throwErr(folder.ToString(), v);
		//}



		//static public string RunCmd__retMsg_throwErr(nilnul.fs.folder_.git_.Top folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__retResult_throwErr(folder.ToString(), v);
		//}
		//public static string RunCmd__retMsg_throwErr_ofFolderShield(string folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__retResult_throwErr(folder, v);
		//}


		//public static string RunCmd__retMsg_throwErr_ofFolderAddress(string folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__retResult_throwErr(folder, v);
		//}


		//public static string RunCmd__retMsg_throwErr(nilnul.fs.git.ModuleI folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return RunCmd__retMsg_throwErr(folder.top, v, git);
		//}


		//public static string RunCmd__retMsg_throwErr(nilnul.fs.git.Module folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return RunCmd__retMsg_throwErr(folder.top, v, git);
		//}

		//public static string RunCmd__retMsg_throwErr(Work work, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return RunCmd__retMsg_throwErr(
		//		work.en
		//		,
		//		v
		//		,
		//		git
		//	);

		//}

		//public static string RunCmd__retMsg_throwErr(FolderI en, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return RunCmd__retMsg_throwErr_ofFolderShield(en.ToString(), v, git);

		//}

		//static public nilnul.win.prog_.nilnul.win.prog._run.Result RunCmd_result(nilnul.fs.git.Module folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__returnResult(folder.ToString(), v);
		//}

		//public static nilnul.win.prog_.nilnul.win.prog._run.Result RunCmd_result(nilnul.fs.FolderI folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__returnResult(folder.address.en.ToString(), v);
		//}



		//public static nilnul.win.prog_.nilnul.win.prog._run.Result RunCmd_result(nilnul.fs.folder_.git_.Top folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__returnResult(folder.ToString(), v);
		//}

		//internal static nilnul.win.prog_.nilnul.win.prog._run.Result RunCmd_result(ModuleI workingDir, string v, nilnul.win.prog_.Git git)
		//{
		//	return (git ?? StaticInstance).runCmd__returnResult(workingDir.ToString(), v);
		//}


		//static public nilnul.win.prog_.nilnul.win.prog._run.Result RunCmd_result(nilnul.fs.FolderI folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__returnResult(folder.ToString(), v); ;
		//}
		//[Obsolete()]
		//public static nilnul.win.prog_.nilnul.win.prog._run.Result RunCmd_result(string folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return RunCmd_result(nilnul.fs.address_.Shield.FroAddress(folder), v, git); ;
		//}

		//[Obsolete()]
		//public static nilnul.win.prog_.nilnul.win.prog._run.Result RunCmd_result(nilnul.fs.address_.Shield folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__returnResult(folder.ToString(), v); ;
		//}

		//public static nilnul.win.prog_.nilnul.win.prog._run.Result RunCmd_result(nilnul.fs.address_.ShieldI folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__returnResult(folder.ToString(), v); ;
		//}

		//public static int Run_retExitCode(string folder, string args, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).run_retExitCode(folder.ToString(), args); ;
		//}



		//public static string RunCmd__retMsg_throwErr(nilnul.fs.folder_.git_.Top folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	return (git ?? StaticInstance).runCmd__retResult_throwErr(folder.ToString(), v);
		//}

		//public static void RunCmd_retVoid(nilnul.fs.folder_.git_.Top folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	(git ?? StaticInstance).runCmd_retVoid(folder.ToString(), v);
		//}

		//public static void RunCmd_retVoid(nilnul.fs.folder_.git_.Top folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	(git ?? StaticInstance).runCmd_retVoid(folder.ToString(), v);
		//}
		//static public void RunCmd_retVoid(nilnul.fs.folder_.git_.Top folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	(git ?? StaticInstance).runCmd_retVoid(folder.ToString(), v);
		//}



		//public static void RunCmd_retVoid(nilnul.fs.git.ModuleI module, string v, nilnul.win.prog_.Git git = null)
		//{
		//	(git ?? StaticInstance).runCmd_retVoid(module.top.ToString(), v);
		//}


		//public static void RunCmd_retVoid(nilnul.fs.address_.Shield folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	(git ?? StaticInstance).runCmd_retVoid(folder.ToString(), v);

		//}

		//public static void RunCmd_retVoid(nilnul.fs.FolderI folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	(git ?? StaticInstance).runCmd_retVoid(folder.ToString(), v);

		//}

		//static public void RunCmd_retVoid(nilnul.fs.FolderI folder, string v, nilnul.win.prog_.Git git = null)
		//{
		//	(git ?? StaticInstance).runCmd_retVoid(folder.ToString(), v);

		//}


		//public static void RunCmd_retVoid(string gitTop, string v, nilnul.win.prog_.Git git = null)
		//{
		//	RunCmd_retVoid(nilnul.fs.address_.Shield.FroAddress(gitTop), v, git);
		//}




		public const string DIR_IN_Program = "Git";


		[Obsolete()]
		public const string GIT_EXE_REL_PATH = @"bin\git.exe";

		public const string DOCUMENT_SINCE_GIT = @"bin\git.exe";

		public const string DOCUMENT_SINCE_PROGRAMS = DENOTE_IN_Program + "\\" + @"bin\git.exe";


		public const string FILE = DENOTE_IN_Program + "\\" + @"bin\git.exe";




		public const string GIT_EXE_ABS_PATH = GIT_INSTALLED_DIRECTORY + "\\" + GIT_EXE_REL_PATH;


		#region static

		//[Obsolete()]
		//public int runCmd(string folder, string args)
		//{


		//	return runCmd(folder, args, TextWriter.Null, TextWriter.Null);


		//}

		//[Obsolete(nameof(RunCmd_retVoid))]
		//public void runCmd_notOutput(string folder, string args)
		//{


		//	nilnul.win.proc_.end.cod.Vod.Singleton.ofAddress(folder, this.location, args);


		//}
		//public void runCmd_retVoid(string folder, string args)
		//{


		//	//nilnul.win.proc_.end.cod.Vod.Singleton.ofAddress(folder, this.location, args);
		//	nilnul.win.proc_.end.cod.Vod.Singleton.ofAddress(folder, this.location, args);


		//}


		//public int run_retExitCode(string folder, string args)
		//{
		//	return nilnul.win.prog.run._ExitCodeX.OfAddress(this.location, args, folder);
		//}

		//public int run_retExitCode_windowTitled(string folder, string args)
		//{
		//	return nilnul.win.prog.run._ExitCodeX.OfAddress(this.location, args, folder);
		//}



		//public void runCmd_retVoid_nowait(string folder, string args)
		//{


		//	nilnul.win.proc_.end.cod.Vod.Singleton.ofAddress(folder, this.location, args);
		//	//nilnul.win.proc.run_._WaitX.RunCmd_noOutput(folder, this.location, args);


		//}



		//public int runCmd_retErrCode(string workingDir, string args)
		//{


		//	return nilnul.win.prog.run._ExitCodeX.OfAddress(workingDir, this.location, args);


		//}


		//public int runCmd_retErrCode(string args)
		//{


		//	return nilnul.win.prog.run._ExitCodeX.OfAddress("",this.location, args);


		//}




		//public void runCmd_notOutput(nilnul.fs.Folder folder, string args)
		//{


		//	nilnul.win.proc_.end.cod.Vod.Singleton.ofAddress(folder, this.location, args);


		//}

		//public void runCmd_notOutput_nowait(nilnul.fs.Folder folder, string args)
		//{


		//	nilnul.win.proc_.end.cod.Vod.Singleton.ofAddress(folder, this.location, args);


		//}



		//private nilnul.win.prog._run.Result runCmd__returnResult(DirectoryInfo folder, string args)
		//{

		//	return nilnul.win.prog.run_.noUi_.redir_.both_.errAsyn_.stdSyn_.timeout.result._CrashedRetX.OfAddress(folder,location,args);


		//}



		//public nilnul.win.prog._run.Result runCmd__returnResult(nilnul.fs.Folder folder, string args)
		//{
		//	return nilnul.win.prog.run_.noUi_.redir_.both_.errAsyn_.stdSyn_.timeout.result._CrashedRetX.OfAddress(folder.ToString(), location, args);

		//}

		//public nilnul.win.prog._run.Result runCmd__returnResult(nilnul.fs.Folder folder, string args)
		//{

		//	StringWriter output = new StringWriter();
		//	StringWriter err = new StringWriter();


		//	var errCode = runCmd(folder, args, output, err);

		//	output.Flush();
		//	err.Flush();

		//	return new nilnul.win.prog._run.Result(errCode, output.ToString(), err.ToString());


		//}


		//public nilnul.win.prog._run.Result runCmd__returnResult(string folder, string args)
		//{

		//	return nilnul.win.prog.run_.noUi_.redir_.both_.errAsyn_.stdSyn_.timeout.result._CrashedRetX.OfAddress(folder,location,args);

		//}

		//public void runCmd_throwErr(DirectoryInfo folder_none, string args)
		//{

		//	nilnul.win.prog._run.Result r = runCmd__returnResult(folder_none, args);

		//	if (r.beErr)
		//	{
		//		throw new _git.ReportErrException(r.msg + $"{Environment.NewLine}err:" + r.err);

		//	}

		//}




		//public void runCmd_throwErr(
		//	string folder, string args
		//)
		//{
		//	nilnul.win.proc_.end.cod.Vod.Singleton.ofAddress(folder, location, args);
		//}

		//public string runCmd__retResult_throwErr(DirectoryInfo folder, string args)
		//{

		//	nilnul.win.prog._run.Result r = runCmd__returnResult(folder, args);

		//	if (r.beErr)
		//	{
		//		throw new _git.ReportErrException(r.msg + $"{Environment.NewLine}err:" + r.err);

		//	}
		//	return r.msg;

		//}

		//public string runCmd__retResult_throwErr(nilnul.fs.Folder folder, string args)
		//{

		//	return nilnul.win.prog.run.result._MsgX.Msg(folder.ToString(), location, args);

		//}

		//public string runCmd__retResult_throwErr(
		//	string folder, string args
		//)
		//{
		//	return nilnul.win.prog.run.result._MsgX.Msg(folder, location,args);
		//}






		//public static int RunCmd(string dir, string args)
		//{

		//	return nilnul.win.prog.run._ExitCodeX.OfAddress(dir,StaticInstance.location,args);



		//}

		#endregion

		/// <summary>
		/// the absolute pathe of nilnul.win.prog_.Git command file.
		/// </summary>

		private string _location;

		public string location
		{
			get => _location;
			set => _location = value;
		}


		public Git(string location)
		{

			_location = location;

		}

		public Git() : this(
					 nilnul.win.prog_.Git.Location64Bit
					 )
		{

		}
		public override string ToString()
		{
			return _location;
		}
		#region static extension

		public static string Location64Bit = Path.Combine(
					$"{nilnul.win.Locations.ProgramFilesLocation}",
					DIR_IN_Program
			,
					GIT_EXE_REL_PATH
				);

		public static string Base32Bit = Path.Combine(
					$"{nilnul.win.Programs.Container86_1}",
					DENOTE_IN_Program

		);

		public static string Base64Bit = Path.Combine(
					$"{nilnul.win.Programs.Container64_1}",
					DENOTE_IN_Program

		);

		public static string File32Bit => Path.Combine(
					$"{Base32Bit}",
					DOCUMENT_SINCE_GIT

				);

		public static string File64Bit => Path.Combine(
					$"{Base64Bit}",
					DOCUMENT_SINCE_GIT

				);

		public static nilnul.win.prog_.Git CreateFor64Bit()
		{

			return new nilnul.win.prog_.Git(

				File64Bit
			);
		}

		public static nilnul.win.prog_.Git Create32Bit()
		{

			return new nilnul.win.prog_.Git(

				File32Bit
			);
		}
		//public void runCmd_throwErr(nilnul.fs.Folder folder, string v)
		//{
		//	runCmd_throwErr(nilnul.fs.folder.to_._InfoX.To(folder), v);
		//}
		#endregion




		public static nilnul.win.prog_.Git Singleton => nilnul.obj_.Singleton<Git>.Instance;


		public static nilnul.win.prog_.Git StaticInstance = CreateFor64Bit();


		public static nilnul.win.prog_.Git Injected;

		static public void Inject()
		{
			var searched = _Address0nul_searchWithoutHint();
			if (searched is not null)
			{
				Injected = new Git(
					searched
				);

			}
		}
		static Git()
		{
			Inject();
		}

		static public void Reinject(string address)
		{
			

			if (
				System.IO.Path.GetExtension(address).ToLower() != ".exe"
				&&
				System.IO.Path.GetExtension(address).ToLower() != ".com"

			)
			{
				//continue
			}
			else
			{
				if (
					nilnul.fs.address_.spear.BeX1.Be_ofAddress(
						nilnul.fs.address_.spear.be_.File.Singleton, address)
					)
				{
					Injected = new Git(
						address
					);
				}
			}



		}

		/// <summary>
		/// for user given hint, implement that in another type on base of this.
		/// </summary>
		/// <returns></returns>
		public static string _Address0nul_searchWithoutHint()
		{
			if (!Environment.Is64BitOperatingSystem)
			{
				var expected32 = File32Bit;
				if (

						nilnul.fs.address_.spear.BeX1.Be_ofAddress(
						nilnul.fs.address_.spear.be_.File.Singleton
						, expected32
					)
				)
				{
					return expected32;
				}

				Trace.TraceError(
					$"{typeof(nilnul.win.prog_.Git).FullName}.{nameof(_Address0nul_searchWithoutHint)}: this is not a 64bit system, but we failed to find git in 32bit program_ folder. "
				);

				return null;
			}

			//search the 64bit first.
			var expected = File64Bit;
			if (nilnul.fs.address_.spear.BeX1.Be_ofAddress(
						nilnul.fs.address_.spear.be_.File.Singleton
						, expected
					))
			{
				return expected;
			}

			Trace.TraceError(
				$"{typeof(nilnul.win.prog_.Git).FullName}.{nameof(_Address0nul_searchWithoutHint)}: this is a 64bit system, but we failed to find git in 64bit program_ folder. We will continue to find in 32bit system."
			);

			if (
				nilnul.fs.address_.spear.BeX1.Be_ofAddress(
					nilnul.fs.address_.spear.be_.File.Singleton
					,
					File32Bit
				)
			)
			{
				return File32Bit;
			}

			return null;


		}


		public static string _Address0nul_search(string addressHinted)
		{
			if (

				System.IO.Path.GetExtension(addressHinted).ToLower() != ".exe"
				&&
				System.IO.Path.GetExtension(addressHinted).ToLower() != ".com"

			)
			{
				//continue

			}
			else
			{
				if (
					nilnul.fs.address_.spear.BeX1.Be_ofAddress(
						nilnul.fs.address_.spear.be_.File.Singleton
						, addressHinted
					)
				)
				{
					return addressHinted;
				}
			}
			return _Address0nul_searchWithoutHint();


		}



	}
}
