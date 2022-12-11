using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder_.git_
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
	public class Work
		:
		nilnul.fs.folder.be_.git_.work.vow.En
	{

		public Work(FolderI val) : base(val)
		{
		}

		public Work(ShieldI shiled) : this(new Folder(shiled))
		{
		}



		/// <summary>
		/// git ls-files file_name --error-unmatch will exit with 1 if file is not tracked, as per http://stackoverflow.com/questions/2405305/git-how-to-tell-if-a-file-is-git-tracked-by-shell-exit-code




		public static Work FroShield(string obj)
		{
			return new Work(
					nilnul.fs.Folder.FroShield(obj)
				);
		}
		public static Work FroAddress(string address)
		{
			return new Work(
				nilnul.fs.Folder.FroAddress(address)
			);
		}



		/// <summary>
		/// note: this will return the tgt if the folder is a link
		/// </summary>
		/// <param name="git"></param>
		/// <returns>
		/// the physical, not the symlink, path
		/// </returns>
		public nilnul.fs.address_.ShieldI getRoot(nilnul.win.prog_.Git git = null)
		{

			///note: in ".git", the following command returns empty. 
			///		in submodule, the following command returns the root of the submodule.

			var result = nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(this.en.address.en, "rev-parse --show-toplevel", git);

			/// for repo (whichi is not bare), "" is returned. and errCode is 0.
			/// for bareRepo (work), the base address is returned


			if (result.notBeErr)
			{
				string root = result.msg.ToString().Trim();    //note backslash and slash	//.Split(new[] { '\n', '\r' },StringSplitOptions.RemoveEmptyEntries);
				return nilnul.fs.address_.Shield.FroAddress(root);
			}
			else
			{
				throw new nilnul.win.prog_._git.ReportErrException(
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


		public static string GetRoot(string workspaceSubDir)
		{


			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(workspaceSubDir, "rev-parse --show-toplevel");



		}

		public static nilnul.fs.address_.Shield _GetRoot(nilnul.win.prog_.Git git, string _insideWork_notRepo)
		{




			return nilnul.fs.address_.Shield.FroAddress(

				nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(_insideWork_notRepo, "rev-parse --show-toplevel")  ///note: in ".git", the following command returns empty.  in submodule, the command returns the root of the submodule.
					

			);




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
			return nilnul.fs.address_.shield.Eq.Singleton.Equals(getRoot(), en.address.en);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_locationOf_folderInModule_NotRepo"></param>
		/// <returns></returns>
		public static bool _IsRoot(nilnul.win.prog_.Git git, string _locationOf_folderInModule_NotRepo)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.Equals(

				_GetRoot(git, _locationOf_folderInModule_NotRepo)

				,
				nilnul.fs.address_.Shield.FroAddress(_locationOf_folderInModule_NotRepo)

			);

		}

		public static bool _IsRoot(string _locationOf_folderInModule_NotRepo)
		{
			return _IsRoot(nilnul.win.prog_.Git.StaticInstance, _locationOf_folderInModule_NotRepo);

		}

		public static bool IsRoot(string workspaceSubDir)
		{
			return GetRoot(workspaceSubDir) == new DirectoryInfo(workspaceSubDir).ToString();

		}
		public static bool IsNotRoot(string workspaceSubDir)
		{
			return !IsRoot(workspaceSubDir); ;

		}

		public static IEnumerable<string> GetBranches_throws(string workingDir)
		{


			string msg = nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(workingDir, "branch");

			IEnumerable<string> outputBranches = msg.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");



			IEnumerable<string> defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));
			IEnumerable<string> nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));

			return defaultBranch.Union(nonDefaultBranch);



		}


	}


	//public static IEnumerable<string> GetBranches(string workingDir, TextWriter log, TextWriter err)
	//{
	//	try
	//	{
	//		return GetBranches_throws(workingDir);
	//	}
	//	catch (Exception e)
	//	{
	//		err.WriteLine(
	//			"Error in GetBranches of " + workingDir + ": " + e.Message
	//		);
	//		return new string[] { };
	//		//throw;
	//	}
	//}



	//public static IEnumerable<string> GetRemotes(string workingDir, TextWriter log, TextWriter err)
	//{
	//	try
	//	{
	//		return GetRemotes_throws(workingDir);
	//	}
	//	catch (Exception e)
	//	{
	//		err.WriteLine(
	//			"Error in getRemotes of " + workingDir + ": " + e.Message
	//		);
	//		return new string[] { };
	//		//throw;
	//	}
	//}

	//public static IEnumerable<string> GetRemotes(string workingDir, TextWriter log)
	//{
	//	try
	//	{
	//		return GetRemotes_throws(workingDir);
	//	}
	//	catch (Exception e)
	//	{
	//		log.WriteLine(
	//			"Error in getRemotes of " + workingDir + ": " + e.Message
	//		);
	//		return new string[] { };
	//		//throw;
	//	}
	//}


	//public static IEnumerable<string> GetRemotes_throws(string workingDir)
	//{
	//	StringWriter output = new StringWriter();
	//	StringWriter err = new StringWriter();

	//	int errCode = nilnul.win.prog_.Git.RunCmd(workingDir, "remote", output, err);
	//	output.Flush();
	//	err.Flush();

	//	//			log.WriteLine(err.ToString());



	//	if (errCode != 0)
	//	{

	//		throw new ProcessRunException(err.ToString());
	//	}
	//	else
	//	{
	//		IEnumerable<string> outputRemotes = output.ToString().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");

	//		return outputRemotes;

	//	}


	//}



	//public static void AddCommitPush(DirectoryInfo item, TextWriter log)
	//{
	//	Upload(item.FullName, log);

	//	//AddCommitPush(item.FullName);

	//}

	///// <summary>
	///// only this folder, not sub folders.
	///// </summary>
	///// <param name="item"></param>
	///// <param name="errLog"></param>

	//public static void Upload(string item, TextWriter errLog)
	//{

	//	try
	//	{
	//		Add(item, errLog);
	//		Commit(item, errLog);
	//		Push(item, errLog);

	//	}
	//	catch (Exception e)
	//	{
	//		errLog.WriteLine(
	//			"Exception in Uploading " +
	//			item.ToString()
	//			+ ": " + e.Message
	//			);
	//	}



	//}
	//public static void AddCommitPush(string item)
	//{


	//	Upload(item, nilnul.win.debug.DebugAsTextWriter.Singleton);



	//}

	///// <summary>
	///// statsh the contents
	///// </summary>
	///// <param name="module"></param>
	//public static void Stash(string module, TextWriter log, TextWriter err)
	//{

	//	nilnul.win.prog_.git.run_._LogX._ExitCode(
	//		module,
	//		"stash"
	//		, log, err

	//	);




	//}



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



	//public static void Commit(string workingDir, TextWriter log)
	//{
	//	RunGit(workingDir, "commit -m \"automatic push\"", log);

	//}
	//public static void Add(string workingDir, TextWriter log)
	//{

	//	RunGit(workingDir, "add --all", log);





	//}


	//public static void Add(string workingDir)
	//{

	//	RunGit(workingDir, "add --all");





	//}


	//public static void RunGit(string workingDir, string args)
	//{

	//	Git.RunCmd(workingDir, args);
	//}

	//public static void RunGit(string workingDir, string args, TextWriter log)
	//{

	//	Git.RunCmd_logErrOnly(workingDir, args, log);
	//}

	//public static void Push(string workingDir, TextWriter log)
	//{
	//	try
	//	{
	//		GetRemotes(workingDir, log).ForEach(
	//			(remote) =>
	//			{
	//				Push(workingDir, remote, log);
	//			}
	//		);


	//	}
	//	catch (Exception e)
	//	{
	//		log.WriteLine("Error in push " + workingDir + ": " + e.Message);

	//		//throw;
	//	}

	//	return;

	//	throw new NotImplementedException();
	//}

	//public static void Push(string workingDir)
	//{
	//	try
	//	{
	//		GetRemotes_throws(workingDir).ForEach(
	//			(remote) =>
	//			{
	//				try { Push(workingDir, remote); } catch (Exception e) { }
	//			}
	//		);


	//	}
	//	catch (Exception)
	//	{

	//		throw;
	//	}

	//	return;

	//	throw new NotImplementedException();
	//}

	//public static void Push(string workingDir, string remote, TextWriter log)
	//{

	//	RunGit(workingDir, "push --all " + remote, log);    //all here means all branches.

	//}

	//public static void Push(string workingDir, string remote)
	//{
	//	RunGit(workingDir, "push --all " + remote);

	//}


}
