using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git
{
	/// <summary>
	/// direcories (file or folder) from the perspective of Git.
	/// </summary>
	/// 

	public  class Dir
	{
		//public const string YOUR_GIT_INSTALLED_DIRECTORY = @"C:\Program Files (x86)\Git";


			[Obsolete()]

		static public bool IsWorkSpace(string dir)
		{

			return Enum_DirWorkRepo(dir) == Dir_Workspace_Repo.Workspace;


		}
			[Obsolete()]
		static public bool IsRoot(string dir)
		{

			return Enum_NoneRootRepoSub(dir) == None_Root_Repo_Sub.Root;


		}
			[Obsolete()]
		static public bool IsSub(string dir)
		{

			return Enum_NoneRootRepoSub(dir) == None_Root_Repo_Sub.Sub;


		}

				[Obsolete()]
	static public bool IsNone(string dir)
		{

			return Enum_DirWorkRepo(dir) == Dir_Workspace_Repo.None;


		}
			[Obsolete()]

		public enum Dir_Workspace_Repo
		{
			None,
			Workspace
				, Repo
		}
			[Obsolete()]
		public enum None_Root_Repo_Sub
		{
			/// <summary>
			/// not in any workspace
			/// </summary>
			None,	

			/// <summary>
			/// the root of a workspace
			/// </summary>
			Root	//the root workspace
			,
			/// <summary>
			/// inside the .git dir (root or sub)
			/// </summary>
			Repo	//inside the .git dir, root or sub 
			,

			/// <summary>
			/// inside a sub folder of workspace
			/// </summary>
			Sub	//sub dir of root workspace
		}
			[Obsolete()]
		static public None_Root_Repo_Sub Enum_NoneRootRepoSub(DirectoryInfo dirInfo) {
			return Enum_NoneRootRepoSub(dirInfo.FullName);

		}
			[Obsolete()]
		static public None_Root_Repo_Sub Enum_NoneRootRepoSub(string dir)
		{
			StringWriter output = new StringWriter();

			var errCode = win.ProcessX.RunCmd(
				dir,
				Git.Location64Bit
				,
			 "rev-parse --is-inside-work-tree"
				 ,
				 output
			);



			if (errCode != 0)
			{
				return None_Root_Repo_Sub.None;
			}
			else
			{
				if (output.ToString().Trim().ToLower() == "true")
				{
					if (Workspace.IsRoot(dir))
					{
						return None_Root_Repo_Sub.Root;
					}
					return None_Root_Repo_Sub.Sub;

				}
				return None_Root_Repo_Sub.Repo;

			}




		}

				[Obsolete()]
	static public Dir_Workspace_Repo Enum_DirWorkRepo(string dir)
		{
			StringWriter output = new StringWriter();

			var errCode =  win.ProcessX.RunCmd(
				dir,
				Git.GIT_EXE_ABS_PATH
				,
			 "rev-parse --is-inside-work-tree"
				 ,
				 output
			);



			if (errCode != 0)
			{
				return Dir_Workspace_Repo.None;
			}
			else
			{
				if (output.ToString().Trim().ToLower() == "true")
				{

					return Dir_Workspace_Repo.Workspace;

				}
				return Dir_Workspace_Repo.Repo;

			}


		}
				[Obsolete()]

		static public bool IsRepo(string dir)
		{

			return Enum_DirWorkRepo(dir) == Dir_Workspace_Repo.Repo;


		}




		//	private static void OutputDataHandler(object sendingProcess,
		//DataReceivedEventArgs outLine)
		//	{
		//		// Collect the net view command output. 
		//		if (!String.IsNullOrEmpty(outLine.Data))
		//		{
		//			// Add the text to the collected output.
		//			//netOutput.Append(Environment.NewLine + "  " + outLine.Data);
		//			Debug.Write(Environment.NewLine + "  " + outLine.Data);
		//		}
		//	}

				[Obsolete()]

		private static void ErrorDataHandler(object sendingProcess,
			DataReceivedEventArgs errLine)
		{
			// Write the error text to the file if there is something 
			// to write and an error file has been specified. 

			if (!String.IsNullOrEmpty(errLine.Data))
			{

				// Write redirected errors to the file.
				Debug.WriteLine("--------------error----------------------");
				Debug.WriteLine(errLine.Data);
				Debug.WriteLine("--------------error end----------------------");

			}



			//	}

		}
	}
}
