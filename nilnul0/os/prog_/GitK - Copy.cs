using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs
{
	/// <summary>
	/// the git system that is for versioning control
	/// </summary>
	public class GitK
		
	{


		public const string DIR_IN_Program = "Git";


		public static nilnul.fs.address_.ShieldI GitFolder64 = new nilnul.fs.address_.shield_.BaseDir(
			 nilnul.win.Programs.Container64
			,
			 
				 fs._address.Dir.OvDenote(DIR_IN_Program)
			
		);

		public static nilnul.fs.address_.ShieldI GitFolder86 = new nilnul.fs.address_.shield_.BaseDir(
			 nilnul.win.Programs.Folder86
			,
			 

				 fs._address.Dir.OvDenote(DIR_IN_Program)
			
		);



		public const string STEM_since_Base = @"cmd";
		public const string DOC = "gitk.exe";

		public static nilnul.fs._address.Document DocumentInGitFolder = new fs._address.Document(
			  fs._address.div_._DivisionX.Fro(
				 fs._address.DivisionA.Parse(
				STEM_since_Base
				 )
			)
			,
			DOC
		);


		public static nilnul.fs.address_.SpearI Address64 = new nilnul.fs.address_.spear_.ParentDocument(

			GitFolder64
			,
			DocumentInGitFolder
			
		);

		public static nilnul.fs.address_.SpearI Address86 = new nilnul.fs.address_.spear_.ParentDocument(

			GitFolder86
			,
			DocumentInGitFolder
			
		);





		#region static


		public void runCmd_notOutput(string folder, string args) {


			 nilnul.win.proc_.end.cod.Vod.Singleton.ofAddress(folder, this.location, args);


		}


		public void runCmd_notOutput(nilnul.fs.Folder folder, string args) {


			 nilnul.win.proc_.end.cod.Vod.Singleton.vod( this.location, args, folder);


		}



		private nilnul.win.prog._run.Result runCmd__returnResult(DirectoryInfo folder, string args)
		{

			return nilnul.win.proc_.timeout_.end.Result.Singleton.result( this.location, args, folder);


		}


		

		public nilnul.win.prog._run.Result runCmd__returnResult(nilnul.fs.Folder folder, string args)
		{

					return nilnul.win.proc_.timeout_.end.Result.Singleton.result( 
						this.location, args, folder
					);
	


		}


		public nilnul.win.prog._run.Result runCmd__returnResult(string folder, string args) {

			
					return nilnul.win.proc_.timeout_.end.Result.Singleton.ofAddress(this.location, args, folder);

			
		}

		public void runCmd_throwErr(DirectoryInfo folder_none,string args)
		{

			var r = runCmd__returnResult(folder_none, args);

			if (r.beErr)
			{
				throw new Exception(r.msg + $"{Environment.NewLine}err:" + r.err);

			}

		}




		public void runCmd_throwErr(
			string folder, string args
		) {
			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new Exception(r.msg + $"{Environment.NewLine}err:" + r.err);

			}
		}

		public string runCmd__retResult_throwErr(DirectoryInfo folder, string args)
		{

			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new Exception(r.msg + $"{Environment.NewLine}err:" +r.err);

			}
			return r.msg;

		}

		public string runCmd__retResult_throwErr(nilnul.fs.Folder folder, string args)
		{

			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new Exception(r.msg + $"{Environment.NewLine}err:" +r.err);

			}
			return r.msg;

		}

		public string runCmd__retResult_throwErr(
			string folder, string args
		) {


			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new Exception(r.msg + $"{Environment.NewLine}err:" + r.err);

			}
			return r.msg;
		}
	

		
	







	


		static public int RunCmd(string dir, string args)
		{
			return nilnul.win.proc_.end.Cod.Singleton.ofAddress(StaticInstance.location,args, dir);



		}

		#endregion
		
		/// <summary>
		/// the absolute pathe of nilnul.win.prog_.Git command file.
		/// </summary>

		private string _location;

		public string location
		{
			get { return _location; }
			set { _location = value; }
		}


		public GitK(string location)
		{
			_location = location;

		}



		public GitK()
			:this(
				Address64
				 )
		{

		}

		public GitK(nilnul.fs.address_.SpearI address64)
		{
			this._location = address64.ToString();
		}

		public override string ToString()
		{
			return _location;
		}
		#region static extension

		

		static public GitK CreateFor64Bit()
		{

			return new GitK(
				Address64

				
			);
		}

		public  void runCmd_throwErr(nilnul.fs.Folder folder, string v)
		{
			runCmd_throwErr((DirectoryInfo) folder, v);
		}
		#endregion



		static public readonly GitK Singleton = SingletonByDefault<GitK>.Instance;

		static public GitK StaticInstance = Singleton;
	}
}
