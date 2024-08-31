using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;

namespace nilnul.dev.git
{
	/// <summary>
	///  a folder that's inside a module, but is not inside ".git".
	///  including:
	///		root of a module
	///		subfolder of root that's not .git
	///		descendant folder of a module that's not inside .git.
	///			this must be a descendant folder of a root.
	///		subfolder of root that's the root of another moder
	///	excluding:
	///		.git or its descendants.
	///		
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.fs.git.module.dir_.work))]
	public class Workspace
		:
		nilnul.dev.git.folder.Categorized<git.folder.category.be_.Work>
		

		,WorkspaceI
		//nilnul.be.Asserted< nilnul.dev.git.Folder, nilnul.dev.git.folder.be_.Inited>
	{



		public Workspace(git.folder.Category c):base(c)
		{

		}
		private Workspace(Folder folder):this( git.folder.Category.Eval(folder))
		{




		}

		





		[Obsolete()]
		public const string YOUR_GIT_INSTALLED_DIRECTORY = @"C:\Program Files (x86)\Git";

	

		/// <summary>
		/// git ls-files file_name --error-unmatch will exit with 1 if file is not tracked, as per http://stackoverflow.com/questions/2405305/git-how-to-tell-if-a-file-is-git-tracked-by-shell-exit-code

		/// </summary>
		/// <returns></returns>
		static public bool IsFileTracked(string file)
		{

			throw new NotImplementedException();

		}
		static public IEnumerable<string> GetRemotes(string workingDir)
		{
			return GetRemotes(workingDir, nilnul.win.debug.DebugAsTextWriter.Singleton);
		}

		
		public string getRoot()
		{
			

			///note: in ".git", the following command returns empty. 
			///		in submodule, the following command returns the root of the submodule.

			var result = this.folder.runCmd( "rev-parse --show-toplevel");
			if (result.notBeErr)
			{
				var root = result.msg.ToString().Trim();    //note backslash and slash	//.Split(new[] { '\n', '\r' },StringSplitOptions.RemoveEmptyEntries);
				return
				new DirectoryInfo(root).FullName;
			}
			else
			{
				throw new _git.ReportErrException(
					result.err
					
				);

			}


		}

		/// <summary>
		/// given a sub directory 
		/// </summary>
		/// <param name="workspaceSubDir"></param>
		/// <returns></returns>
		/// 


		static public string GetRoot(string workspaceSubDir)
		{
			StringWriter output = new StringWriter();
			StringWriter err = new StringWriter();

			///note: in ".git", the following command returns empty. 
			///		in submodule, the following command returns the root of the submodule.

			var errCode = nilnul.win.prog_.Git.RunCmd(workspaceSubDir, "rev-parse --show-toplevel", output, err);
			if (errCode == 0)
			{
				var root = output.ToString().Trim();    //note backslash and slash	//.Split(new[] { '\n', '\r' },StringSplitOptions.RemoveEmptyEntries);
				return
				new DirectoryInfo(root).FullName;
			}
			else
			{
				throw new ProcessRunException(
					string.Format(
						"Error in IsRoot({0}):{1}",
						workspaceSubDir,
						err.ToString()
					)
				);

			}


		}

		static public string _GetRoot(nilnul.win.prog_.Git git,  string _insideWork_notRepo)
		{

			

			
				return			new DirectoryInfo(


					git.runCmd__returnResult(_insideWork_notRepo, "rev-parse --show-toplevel")	///note: in ".git", the following command returns empty.  in submodule, the command returns the root of the submodule.
					.msg.ToString().Trim()
					
				).FullName;
			
			


		}


		/*
		To calculate the absolute path of the current git root directory, say for use in a shell script, use this combination of readlink and git rev-parse:
gitroot=$(readlink -f ./$(git rev-parse --show-cdup))


git-rev-parse --show-cdup gives you the right number of ".."s to get to the root from your cwd, or the empty string if you are at the root. Then prepend "./" to deal with the empty string case and use readlink -f to translate to a full path.

You could also create a git-root command in your PATH as a shell script to apply this technique:
cat > ~/bin/git-root << EOF
#!/bin/sh -e
cdup=$(git rev-parse --show-cdup)
exec readlink -f ./$cdup
EOF
chmod 755 ~/bin/git-root


(The above can be pasted into a terminal to create git-root and set execute bits; the actual script is in lines 2, 3 and 4.)

And then you'd be able to run git root to get the root of your current tree. Note that in the shell script, use "-e" to cause the shell to exit if the rev-parse fails so that you can properly get the exit status and error message if you are not in a git directory.

			
			*/

		/*
		git rev-parse --git-dir
		*/

		public bool isRoot()
		{
			return getRoot() == new DirectoryInfo(folder.location).ToString();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_locationOf_folderInModule_NotRepo"></param>
		/// <returns></returns>
		static public bool _IsRoot(nilnul.win.prog_.Git git, string _locationOf_folderInModule_NotRepo)
		{
			return nilnul.win.storage.location_.Folder._Eq_caseInsensitive( 
				_GetRoot(git,_locationOf_folderInModule_NotRepo)
				
				, 
				new DirectoryInfo(_locationOf_folderInModule_NotRepo).ToString()
				
			);

		}

		static public bool _IsRoot( string _locationOf_folderInModule_NotRepo)
		{
			return _IsRoot(nilnul.win.prog_.Git.StaticInstance, _locationOf_folderInModule_NotRepo);

		}

		static public bool IsRoot(string workspaceSubDir)
		{
			return  GetRoot(workspaceSubDir) == new DirectoryInfo(workspaceSubDir).ToString();

		}
		static public bool IsNotRoot(string workspaceSubDir)
		{
			return !IsRoot(workspaceSubDir); ;

		}

		static public IEnumerable<string> GetBranches_throws(string workingDir)
		{
			StringWriter output = new StringWriter();
			StringWriter err = new StringWriter();

			var errCode = nilnul.win.prog_.Git.RunCmd(workingDir, "branch", output, err);
			output.Flush();

			err.Flush();


			//			log.WriteLine(err.ToString());



			if (errCode != 0)
			{

				throw new ProcessRunException(err.ToString());
			}
			else
			{
				var outputBranches = output.ToString().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");



				var defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));
				var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));

				return defaultBranch.Union(nonDefaultBranch);



			}


		}


		static public IEnumerable<string> GetBranches(string workingDir, TextWriter log, TextWriter err)
		{
			try
			{
				return GetBranches_throws(workingDir);
			}
			catch (Exception e)
			{
				err.WriteLine(
					"Error in GetBranches of " + workingDir + ": " + e.Message
				);
				return new string[] { };
				//throw;
			}
		}



		static public IEnumerable<string> GetRemotes(string workingDir, TextWriter log, TextWriter err)
		{
			try
			{
				return GetRemotes_throws(workingDir);
			}
			catch (Exception e)
			{
				err.WriteLine(
					"Error in getRemotes of " + workingDir + ": " + e.Message
				);
				return new string[] { };
				//throw;
			}
		}

		static public IEnumerable<string> GetRemotes(string workingDir, TextWriter log)
		{
			try
			{
				return GetRemotes_throws(workingDir);
			}
			catch (Exception e)
			{
				log.WriteLine(
					"Error in getRemotes of " + workingDir + ": " + e.Message
				);
				return new string[] { };
				//throw;
			}
		}


		static public IEnumerable<string> GetRemotes_throws(string workingDir)
		{
			StringWriter output = new StringWriter();
			StringWriter err = new StringWriter();

			var errCode = nilnul.win.prog_.Git.RunCmd(workingDir, "remote", output, err);
			output.Flush();
			err.Flush();

			//			log.WriteLine(err.ToString());



			if (errCode != 0)
			{

				throw new ProcessRunException(err.ToString());
			}
			else
			{
				var outputRemotes = output.ToString().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");

				return outputRemotes;

			}


		}



		static public void AddCommitPush(DirectoryInfo item, TextWriter log)
		{
			Upload(item.FullName, log);

			//AddCommitPush(item.FullName);

		}

		/// <summary>
		/// only this folder, not sub folders.
		/// </summary>
		/// <param name="item"></param>
		/// <param name="errLog"></param>

		static public void Upload(string item, TextWriter errLog)
		{

			try
			{
				Add(item, errLog);
				Commit(item, errLog);
				Push(item, errLog);

			}
			catch (Exception e)
			{
				errLog.WriteLine(
					"Exception in Uploading " +
					item.ToString()
					+ ": " + e.Message
					);
			}



		}
		static public void AddCommitPush(string item)
		{


			Upload(item, nilnul.win.debug.DebugAsTextWriter.Singleton);



		}

		/// <summary>
		/// statsh the contents
		/// </summary>
		/// <param name="module"></param>
		static public void Stash(string module, TextWriter log, TextWriter err)
		{

			Git.Singleton.runCmd(
				module,
				"stash"
				,log,err

			);




		}



		//static public void DebugWriteErrorInLines(string error)
		//{
		//	DebugWriteHr();
		//	Debug.WriteLine(error);
		//	DebugWriteHr();

		//}
		//static public void DebugWriteHr()
		//{

		//	Debug.WriteLine("------------------------------");

		//}



		static public void Commit(string workingDir, TextWriter log)
		{
			RunGit(workingDir, "commit -m \"automatic push\"", log);

		}
		static public void Add(string workingDir, TextWriter log)
		{

			RunGit(workingDir, "add --all", log);





		}


		static public void Add(string workingDir)
		{

			RunGit(workingDir, "add --all");





		}


		static public void RunGit(string workingDir, string args)
		{

			Git.RunCmd(workingDir, args);
		}

		static public void RunGit(string workingDir, string args, TextWriter log)
		{

			Git.RunCmd_logErrOnly(workingDir, args, log);
		}

		static public void Push(string workingDir, TextWriter log)
		{
			try
			{
				GetRemotes(workingDir, log).ForEach(
					(remote) =>
					{
						Push(workingDir, remote, log);
					}
				);


			}
			catch (Exception e)
			{
				log.WriteLine("Error in push " + workingDir + ": " + e.Message);

				//throw;
			}

			return;

			throw new NotImplementedException();
		}

		static public void Push(string workingDir)
		{
			try
			{
				GetRemotes_throws(workingDir).ForEach(
					(remote) =>
					{
						try { Push(workingDir, remote); } catch (Exception e) { }
					}
				);


			}
			catch (Exception)
			{

				throw;
			}

			return;

			throw new NotImplementedException();
		}

		static public void Push(string workingDir, string remote, TextWriter log)
		{

			RunGit(workingDir, "push --all " + remote, log);    //all here means all branches.

		}

		static public void Push(string workingDir, string remote)
		{
			RunGit(workingDir, "push --all " + remote);

		}


	}
}
