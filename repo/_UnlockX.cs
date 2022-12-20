using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo
{
	/*
	 https://stackoverflow.com/questions/13635429/git-rename-from-index-lock-to-index-failed

	Git 2.10 (Q3 2016, 4 years later) should improve the situation on Windows

See commit 05d1ed6 (23 Aug 2016) by Ben Wijen (Ben).

mingw: ensure temporary file handles are not inherited by child processes
When the index is locked and child processes inherit the handle to said lock and the parent process wants to remove the lock before the child process exits, on Windows there is a problem: it won't work because files cannot be deleted if a process holds a handle on them.

The symptom:

Rename from 'xxx/.git/index.lock' to 'xxx/.git/index' failed.
Should I try again? (y/n)
Spawning child processes with bInheritHandles==FALSE would not work because no file handles would be inherited, not even the hStdXxx handles in STARTUPINFO (stdin/stdout/stderr).

Opening every file with O_NOINHERIT does not work, either, as e.g. git-upload-pack expects inherited file handles.

This leaves us with the only way out: creating temp files with the O_NOINHERIT flag. This flag is Windows-specific, however.
For our purposes, it is equivalent to O_CLOEXEC (which does not exist on Windows), so let's just open temporary files with the O_CLOEXEC flag and map that flag to O_NOINHERIT on Windows.

answered Aug 26, 2016 at 6:17
	 */
	/*This isn't a common problem. It happens when you try to run two Git commands simultaneously in the same repo (and even then it may not happen, depending on the commands.)*/

	/*The problem was insufficient permissions.*/
	/// <summary>
	/// 
	/// </summary>
	static public class _UnlockX
	{
		public const string LOCK_ENDING = repo.be_._LockenX.LOCK_ENDING;// ".lock";

		public static void _ByRename_addressAssumeRepo(string  en)
		{
			new System.IO.DirectoryInfo(en).EnumerateFiles(en).Where( d=>d.Name.EndsWith(LOCK_ENDING)).Each(
				d=>
				nilnul.fs.file._RenameX.Rename(
					 d.FullName
					,
					$"{d}{nilnul.time_.datetime.lex_.alnum_.NonyearCollapse.Singleton.phrase()}"
				)
			);
		}

		[Obsolete(nameof(_ByRename_addressAssumeRepo))]
		public static void _ByRename_assumeAddress(string  en)
		{
			_ByRename_addressAssumeRepo(en);
		}

		public static void _ByRename(FolderI en)
		{
			nilnul.fs.folder._DocsX.Denotes(en).Where( d=>d.en.EndsWith(LOCK_ENDING)).Each(
				d=>
				nilnul.fs.file._RenameX.Rename(
					new nilnul.fs.address_.spear_.ParentDoc(en.address.en,d)
					,
					$"{d}{nilnul.time_.datetime.lex_.alnum_.NonyearCollapse.Singleton.phrase()}"
				)
			);
		}



		static public void _ByRename_assumeAddressAsFolder(string repobase) {
			 _ByRename( nilnul.fs.Folder.FroAddress(repobase));
		}

		public static void _ByRename(fs.folder_.git_.Repo folder)
		{
			 _ByRename(folder.en);
		}

		static public void _ByRename(nilnul.fs.git.RepoI repobase) {
			 _ByRename(repobase.folder);
		}

	}
}
