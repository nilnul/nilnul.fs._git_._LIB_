using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git
{
	[Obsolete()]
	public class Folder
	{

		private nilnul.fs.Git _git;

		public nilnul.fs.Git git
		{
			get { return _git; }
			set { _git = value; }
		}

	

		private nilnul.fs.address_.Folder _address;

		public nilnul.fs.address_.Folder address
		{
			get { return _address; }
			set { _address = value; }
		}




		public Folder(nilnul.win.prog_.Git git, string location)
			:this( git, new DirectoryInfo(location))
		{
			
		}

		public Folder(string location):this(
			Git.StaticInstance
			,
			location	
		)
		{

		}



		public Folder(nilnul.win.prog_.Git git, DirectoryInfo location_folder)
			:this(git,  nilnul.fs.address_.Folder.Parse( location_folder.FullName))
		{
			


		}


		public Folder(nilnul.win.prog_.Git git, nilnul.fs.address_.Folder location_folder)
			
		{
			this._git = git;

			this._address = location_folder;


		}


			public Folder( DirectoryInfo location_folder)
			:this(nilnul.win.prog_.Git.StaticInstance,location_folder.FullName)
		{



		}
	




		public _git.Result runCmd(string args) {
			return this.git.runCmd__returnResult(this.address.ToString(), args);
		}

		public void runCmd_throwErr(string args) {
			 this.git.runCmd_throwErr(this.address.ToString(), args);
		}
		public string runCmd_retMsg_throwErr(string args) {
			 return this.git.runCmd__retResult_throwErr(this.address.ToString(), args);
		}


		static public string RunCmd_retMsg_throwErr(nilnul.win.prog_.Git git, string folder,  string args) {
			 return git.runCmd__retResult_throwErr(folder, args);
		}

		static public string RunCmd_retMsg_throwErr( string folder,  string args) {
			 return RunCmd_retMsg_throwErr(nilnul.win.prog_.Git.StaticInstance,folder,args);
		}


		static public string RunCmd_retMsg_throwErr(nilnul.win.prog_.Git git, nilnul.fs.Folder folder,  string args) {
			 return git.runCmd__retResult_throwErr(folder.ToString(), args);
		}

		static public string RunCmd_retMsg_throwErr( nilnul.fs.Folder folder,  string args) {
			 return RunCmd_retMsg_throwErr(nilnul.win.prog_.Git.StaticInstance, folder, args);
		}


		static public _git.Result RunCmd(nilnul.win.prog_.Git git, string location, string args) {
			return git.runCmd__returnResult(location, args);
		}



		


	

	}
}
