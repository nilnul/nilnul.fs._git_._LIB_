using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.win.prog_.gitBash_
{
	/// <summary>
	/// bash.exe in "bin\"
	/// </summary>
	public class BinExe

	{




		public const string DIV = @"bin";
		public const string DOC = "bash.exe";




		public static nilnul.fs._address.Document Document = new nilnul.fs._address.Document(DIV, DOC);


		public static nilnul.fs.address_.SpearI Address64 = new nilnul.fs.address_.spear_.ParentDocument(

			Git.Container64
			,
			Document

		);

		public static nilnul.fs.address_.SpearI Address86 = new nilnul.fs.address_.spear_.ParentDocument(

		Git.Container86
		,
		Document

	);





		#region static


		public void runCmd_notOutput(string folder, string args) {


			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(folder, this.location, args);


		}


		public void runCmd_notOutput(nilnul.fs.Folder folder, string args) {


			nilnul.win.proc_.started.Vod.Singleton.vod(this.location, args, folder );


		}



		private nilnul.win.prog._run.Result runCmd__returnResult(DirectoryInfo folder, string args)
		{

			//StringWriter output = new StringWriter();
			//StringWriter err = new StringWriter();


			//var errCode = runCmd(folder, args, output, err);

			//output.Flush();
			//err.Flush();

			return nilnul.win.proc_.timeout_.end.Result.Singleton.result( this.location, args, folder);


		}

		public nilnul.win.prog._run.Result runCmd__returnResult(nilnul.fs.Folder folder, string args) {
			return runCmd__returnResult((nilnul.fs.FolderI)folder,args);
		}

		public nilnul.win.prog._run.Result runCmd__returnResult(nilnul.fs.FolderI folder, string args)
		{
			return nilnul.win.proc_.timeout_.end.Result.Singleton.result(location,args, folder);

		}



		//public nilnul.win.prog._run.Result runCmd__returnResult(nilnul.fs.Folder folder, string args)
		//{

		//	StringWriter output = new StringWriter();
		//	StringWriter err = new StringWriter();


		//	var errCode = runCmd(folder, args, output, err);

		//	output.Flush();
		//	err.Flush();

		//	return new nilnul.win.prog._run.Result(errCode, output.ToString(), err.ToString());


		//}


		public nilnul.win.prog._run.Result runCmd__returnResult(string folder, string args) {

			return nilnul.win.proc_.timeout_.end.Result.Singleton.ofAddress(location,args, folder);


		}

		public void runCmd_throwErr(DirectoryInfo folder_none, string args)
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
				throw new Exception(r.msg + $"{Environment.NewLine}err:" + r.err);

			}
			return r.msg;

		}

		public string runCmd__retResult_throwErr(nilnul.fs.Folder folder, string args)
		{

			var r = runCmd__returnResult(folder, args);

			if (r.beErr)
			{
				throw new Exception(r.msg + $"{Environment.NewLine}err:" + r.err);

			}
			return r.msg;

		}

		public string runCmd__retResult_throwErr(
			string folder, string args
		) {
			return nilnul.win.proc_.timeout_.end.result.Msg.Singleton.ofAddress(location,args,folder);
		}
	


	

	


		static public int RunCmd(string dir, string args)
		{

			return nilnul.win.proc_.end.Cod.Singleton.ofAddress(StaticInstance.location,args, dir);



		}

		#endregion
		
		/// <summary>
		/// the absolute pathe of  command file.
		/// </summary>

		private string _location;

		public string location
		{
			get { return _location; }
			set { _location = value; }
		}


		public BinExe(string location)
		{
			_location = location;

		}



		public BinExe()
			:this(
				Address64.ToString()
				 )
		{

		}

		public BinExe(nilnul.fs.address_.Spear address64)
		{
			this._location = address64.ToString();
		}

		public override string ToString()
		{
			return _location;
		}
		#region static extension

		

		static public BinExe CreateFor64Bit()
		{

			return new BinExe(
				Address64.ToString()

				
			);
		}

		public  void runCmd_throwErr(nilnul.fs.Folder folder, string v)
		{
			runCmd_throwErr(nilnul.fs.folder.to_._InfoX.To(folder) , v);
		}
		#endregion



		static public readonly BinExe Singleton = SingletonByDefault<BinExe>.Instance;

		static public BinExe StaticInstance = Singleton;
	}
}
