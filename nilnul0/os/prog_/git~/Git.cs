using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.fs.folder_;

namespace nilnul.fs
{
	/// <summary>
	/// the git system that is for versioning control
	/// </summary>
	/// 
	//[Obsolete( nameof(nilnul.win.prog_.Git))]
	public class Git

	{


		public void init(string location)
		{
			var r = runCmd__returnResult(location, "init");
			if (r.notBeErr)
			{
				throw new _git.ReportErrException(r.err);

			}
		}


		public const string GIT_INSTALLED_DIRECTORY = @"C:\Program Files (x86)\Git";

		public string runCmd__retResult_throwErr(GitTop folder, string v)
		{
			return runCmd__retResult_throwErr(folder.ToString(),v);
		}
		static public string RunCmd__retMsg_throwErr(GitTop folder, string v, Git git=null)
		{
			return (git??StaticInstance).runCmd__retResult_throwErr(folder.ToString(),v);
		}

		static public void RunCmd_retVoid(GitTop folder, string v, Git git=null)
		{
			 (git??StaticInstance).runCmd_retVoid(folder.ToString(),v);
		}



		public const string DIR_IN_Program = "Git";

		public const string DST_IN_Program = "Git";

		[Obsolete()]
		public const string GIT_EXE_REL_PATH = @"bin\git.exe";

		public const string DOCUMENT_SINCE_GIT = @"bin\git.exe";

		public const string DOCUMENT_SINCE_PROGRAMS = DST_IN_Program + "\\" + @"bin\git.exe";


		public const string FILE = DST_IN_Program + "\\" + @"bin\git.exe";




		public const string GIT_EXE_ABS_PATH = GIT_INSTALLED_DIRECTORY + "\\" + GIT_EXE_REL_PATH;


		#region static

		[Obsolete()]
		public int runCmd(string folder, string args)
		{


			return runCmd(folder, args, TextWriter.Null, TextWriter.Null);


		}

		[Obsolete(nameof(RunCmd_retVoid))]
		public void runCmd_notOutput(string folder, string args)
		{


			nilnul.win.ProcessX.RunCmd_noOutput(folder, this.location, args);


		}

		public void runCmd_retVoid(string folder, string args)
		{


			nilnul.win.ProcessX.RunCmd_noOutput(folder, this.location, args);


		}


		public int runCmd_retErrCode(string workingDir, string args)
		{


			return nilnul.win.ProcessX.RunCmd_retErrCode(workingDir, this.location, args);


		}


		public int runCmd_retErrCode(string args)
		{


			return nilnul.win.ProcessX.RunOfProgramArgs_retErrCode(this.location, args);


		}




		public void runCmd_notOutput(nilnul.fs.Folder folder, string args)
		{


			nilnul.win.ProcessX.RunCmd_noOutput(folder, this.location, args);


		}



		private _git.Result runCmd__returnResult(DirectoryInfo folder, string args)
		{

			StringWriter output = new StringWriter();
			StringWriter err = new StringWriter();


			var errCode = runCmd(folder, args, output, err);

			output.Flush();
			err.Flush();

			return new _git.Result(errCode, output.ToString(), err.ToString());


		}






		public _git.Result runCmd__returnResult(nilnul.fs.Folder folder, string args)
		{

			StringWriter output = new StringWriter();
			StringWriter err = new StringWriter();


			var errCode = runCmd((DirectoryInfo)folder, args, output, err);

			output.Flush();
			err.Flush();

			return new _git.Result(errCode, output.ToString(), err.ToString());


		}


		public _git.Result runCmd__returnResult(string folder, string args)
		{

			StringWriter output = new StringWriter();
			StringWriter err = new StringWriter();


			var errCode = runCmd(folder, args, output, err);

			output.Flush();
			err.Flush();

			return new _git.Result(errCode, output.ToString(), err.ToString());


		}

		public void runCmd_throwErr(DirectoryInfo folder_none, string args)
		{

			var r = runCmd__returnResult(folder_none, args);

			if (r.beErr)
			{
				throw new _git.ReportErrException(r.msg + $"{Environment.NewLine}err:" + r.err);

			}

		}




		public void runCmd_throwErr(
			string folder, string args
		)
		{
			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new _git.ReportErrException(r.msg + $"{Environment.NewLine}err:" + r.err);

			}
		}

		public string runCmd__retResult_throwErr(DirectoryInfo folder, string args)
		{

			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new _git.ReportErrException(r.msg + $"{Environment.NewLine}err:" + r.err);

			}
			return r.msg;

		}

		public string runCmd__retResult_throwErr(nilnul.fs.Folder folder, string args)
		{

			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new _git.ReportErrException(r.msg + $"{Environment.NewLine}err:" + r.err);

			}
			return r.msg;

		}

		public string runCmd__retResult_throwErr(
			string folder, string args
		)
		{
			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new _git.ReportErrException(r.msg + $"{Environment.NewLine}err:" + r.err);

			}
			return r.msg;
		}
		public int runCmd(string folder, string args, TextWriter output)
		{

			return runCmd(folder, args, output, TextWriter.Null);


		}

		private int runCmd(DirectoryInfo folder, string args, StringWriter output, StringWriter err)
		{

			return runCmd(
				folder,
				args,
				(object sendingProcess, DataReceivedEventArgs outLine) =>
				{
					if (outLine.Data != null)
					{
						output.WriteLine(outLine.Data);
					}
				}
				 ,
				(object sendingProcess, DataReceivedEventArgs errLine) =>
				{
					if (errLine.Data != null)
					{
						err.WriteLine(errLine.Data);

					}
				}
			);


			//throw new NotImplementedException();
		}
		public int runCmd(nilnul.fs.Folder dir, string args, TextWriter output, TextWriter err)
		{

			return runCmd(
				dir,
				args,
				(object sendingProcess, DataReceivedEventArgs outLine) =>
				{
					if (outLine.Data != null)
					{
						output.WriteLine(outLine.Data);
					}
				}
				 ,
				(object sendingProcess, DataReceivedEventArgs errLine) =>
				{
					if (errLine.Data != null)
					{
						err.WriteLine(errLine.Data);

					}
				}
			);

		}

		public int runCmd(string dir, string args, TextWriter output, TextWriter err)
		{

			return runCmd(
				dir,
				args,
				(object sendingProcess, DataReceivedEventArgs outLine) =>
				{
					if (outLine.Data != null)
					{
						output.WriteLine(outLine.Data);
					}
				}
				 ,
				(object sendingProcess, DataReceivedEventArgs errLine) =>
				{
					if (errLine.Data != null)
					{
						err.WriteLine(errLine.Data);

					}
				}
			);


		}


		static public int RunCmd(string dir, string args, TextWriter output, TextWriter err)
		{
			return RunCmd(
				dir,
				args,
				(object sendingProcess, DataReceivedEventArgs outLine) =>
				  {
					  if (outLine.Data != null)
					  {
						  output.WriteLine(outLine.Data);
					  }
				  }
				 ,
				(object sendingProcess, DataReceivedEventArgs errLine) =>
				{
					if (errLine.Data != null)
					{
						err.WriteLine(errLine.Data);

					}
				}
			);
		}
		static public int RunCmd(nilnul.fs.Folder dir, string args, TextWriter output, TextWriter err)
		{
			return RunCmd(
				dir,
				args,
				(object sendingProcess, DataReceivedEventArgs outLine) =>
				  {
					  if (outLine.Data != null)
					  {
						  output.WriteLine(outLine.Data);
					  }
				  }
				 ,
				(object sendingProcess, DataReceivedEventArgs errLine) =>
				{
					if (errLine.Data != null)
					{
						err.WriteLine(errLine.Data);

					}
				}
			);
		}


		static public int RunCmd(string dir, string args, StringWriter output, StringWriter err)
		{
			return RunCmd(
				dir,
				args,
				(object sendingProcess, DataReceivedEventArgs outLine) =>
				  {
					  if (outLine.Data != null)
					  {
						  output.WriteLine(outLine.Data);
					  }
				  }
				 ,
				(object sendingProcess, DataReceivedEventArgs errLine) =>
				{
					if (errLine.Data != null)
					{
						err.WriteLine(errLine.Data);

					}
				}
			);
		}


		public int runCmd_logErrOnly(string dir, string args, TextWriter err)
		{

			return runCmd(dir, args, TextWriter.Null, err);

		}
		static public int RunCmd_logErrOnly(string dir, string args, TextWriter err)
		{

			return nilnul.win.ProcessX.RunCmd_bookErrOnly(dir, GIT_EXE_ABS_PATH, args, nilnul.win.process.DataReceivedHanlerX.Create(err));


		}
		static public int RunCmd(string dir, string args, DataReceivedEventHandler output, TextWriter err)
		{

			return nilnul.win.ProcessX.RunCmd(dir, GIT_EXE_ABS_PATH, args, output, nilnul.win.process.DataReceivedHanlerX.Create(err));


		}

		static public int RunCmd(nilnul.fs.Folder dir, string args, DataReceivedEventHandler output, TextWriter err)
		{

			return nilnul.win.ProcessX.RunCmd(dir.ToString(), GIT_EXE_ABS_PATH, args, output, nilnul.win.process.DataReceivedHanlerX.Create(err));


		}


		public int runCmd(string dir, string args, DataReceivedEventHandler output, DataReceivedEventHandler err)
		{
			return nilnul.win.ProcessX.RunCmd(dir, this.location, args, output, err);


		}

		public int runCmd(nilnul.fs.Folder dir, string args, DataReceivedEventHandler output, DataReceivedEventHandler err)
		{
			return nilnul.win.ProcessX.RunCmd(dir.ToString(), this.location, args, output, err);


		}


		public int runCmd(DirectoryInfo dir, string args, DataReceivedEventHandler output, DataReceivedEventHandler err)
		{
			return nilnul.win.ProcessX.RunCmd(dir, this.location, args, output, err);


		}



		static public int RunCmd(string dir, string args, DataReceivedEventHandler output, DataReceivedEventHandler err)
		{
			return nilnul.win.ProcessX.RunCmd(dir, Git.StaticInstance.location, args, output, err);
		}
		static public int RunCmd(nilnul.fs.Folder dir, string args, DataReceivedEventHandler output, DataReceivedEventHandler err)
		{
			return nilnul.fs.Git.StaticInstance.runCmd(dir.ToString(), args, output, err);
		}


		static public int RunCmd(string dir, string args)
		{

			var exitCode = RunCmd(dir, args, TextWriter.Null, TextWriter.Null);

			return exitCode;



		}

		#endregion

		/// <summary>
		/// the absolute pathe of Git command file.
		/// </summary>

		private string _location;

		public string location
		{
			get { return _location; }
			set { _location = value; }
		}


		public Git(string location)
		{
			_location = location;

		}

		public Git()
			: this(
				 Git.Location64Bit
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
					DST_IN_Program

		);

		public static string Base64Bit = Path.Combine(
					$"{nilnul.win.Programs.Container64_1}",
					DST_IN_Program

		);

		public static string File32Bit
		{
			get
			{
				return Path.Combine(
					$"{Base32Bit}",
					DOCUMENT_SINCE_GIT

				);
			}
		}

		public static string File64Bit
		{
			get
			{
				return Path.Combine(
					$"{Base64Bit}",
					DOCUMENT_SINCE_GIT

				);
			}
		}

		static public Git CreateFor64Bit()
		{

			return new Git(

				File64Bit
			);
		}

		static public Git Create32Bit()
		{

			return new Git(

				File32Bit
			);
		}
		public void runCmd_throwErr(Folder folder, string v)
		{
			runCmd_throwErr((DirectoryInfo)folder, v);
		}
		#endregion



		static public readonly Git Singleton = SingletonByDefault<Git>.Instance;

		static public Git StaticInstance = CreateFor64Bit();



	}
}
