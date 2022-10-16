using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git
{
	public class Folder
	{

		private nilnul.dev.Git _git;

		public nilnul.dev.Git git
		{
			get { return _git; }
			set { _git = value; }
		}


		public string location
		{
			get { return _folder1.address; }
		}



		public DirectoryInfo dir
		{
			get { return _folder1.dirInfo;

			}
		}

		private nilnul.win.storage.Folder _folder1;

		public nilnul.win.storage.Folder folder
		{
			get { return _folder1; }
			set { _folder1 = value; }
		}


		public string	 name
		{
			get { return _folder1.dirInfo.Name ; }
		}


		public Folder(nilnul.win.prog_.Git git, string location)
			:this( git, new DirectoryInfo(location))
		{
			
		}

		public Folder(nilnul.win.prog_.Git git, DirectoryInfo location_folder)
			:this(git, new win.storage.Folder( location_folder.FullName))
		{
			


		}


		public Folder(nilnul.win.prog_.Git git, win.storage.Folder location_folder)
			
		{
			this._git = git;

			this._folder1 = location_folder;


		}


			public Folder( DirectoryInfo location_folder)
			:this(nilnul.win.prog_.Git.StaticInstance,location_folder.FullName)
		{



		}
	


		public _folder.NoneWorkRepo noneWorkRepo()
		{
			//StringWriter output = new StringWriter();

			var result = _git.runCmd__returnResult(
							location,
			 "rev-parse --is-inside-work-tree"
				

			);

			if (result.isErr)
			{
				return _folder.NoneWorkRepo.None;
			}
			else
			{
				
				if (result.msg.ToString().Trim().ToLower() == "true")
				{
					return _folder.NoneWorkRepo.Work;
				}
				return _folder.NoneWorkRepo.Repo;

			}
		}


		public _git.Result runCmd(string args) {
			return this.git.runCmd__returnResult(this.location, args);
		}

		public void runCmd_throwErr(string args) {
			 this.git.runCmd_throwErr(this.location, args);
		}
		public string runCmd_retMsg_throwErr(string args) {
			 return this.git.runCmd__retResult_throwErr(this.location, args);
		}


		static public _git.Result RunCmd(nilnul.win.prog_.Git git, string location, string args) {
			return git.runCmd__returnResult(location, args);
		}


		public bool isInited() {
			return noneWorkRepo() != _folder.NoneWorkRepo.None;
			
		}
		public bool notBeInited() {
			return !isInited();
			
		}

		[Obsolete()]
		static public bool IsRoot(string dir)
		{

			return Enum_NoneRootRepoSub(dir) == _folder.NoneRootSubRepo.Root;


		}


		[Obsolete()]
		static public _folder.NoneRootSubRepo Enum_NoneRootRepoSub(string dir)
		{
			StringWriter output = new StringWriter();

			var errCode = nilnul.win.prog_.Git.Singleton.runCmd(
							dir,
			 "rev-parse --is-inside-work-tree"
				 ,
				 output

			);



			if (errCode != 0)
			{
				return _folder.NoneRootSubRepo.None;
			}
			else
			{
				if (output.ToString().Trim().ToLower() == "true")
				{
					if (Workspace.IsRoot(dir))
					{
						return _folder.NoneRootSubRepo.Root;
					}
					return _folder.NoneRootSubRepo.Sub;

				}
				return _folder.NoneRootSubRepo.Repo;

			}




		}


		[Obsolete()]
		public _folder.NoneRootSubRepo noneRootRepoSub()
		{
			StringWriter output = new StringWriter();

			var errCode = _git.runCmd(
							location,
			 "rev-parse --is-inside-work-tree"
				 ,
				 output

			);

			if (errCode != 0)
			{
				return _folder.NoneRootSubRepo.None;
			}
			else
			{
				if (output.ToString().Trim().ToLower() == "true")
				{
					if (Workspace.IsRoot(_folder1.address))
					{
						return _folder.NoneRootSubRepo.Root;
					}
					return _folder.NoneRootSubRepo.Sub;

				}
				return _folder.NoneRootSubRepo.Repo;

			}




		}

	}
}
