using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.head.set_
{
	/*stackoverflow.com/questions/1282639/switch-git-branch-without-files-checkout
	 * 
	 * Yes, you can do this.

git symbolic-ref HEAD refs/heads/otherbranch
If you need to commit on this branch, you'll want to reset the index too otherwise you'll end up committing something based on the last checked out branch.

git reset*/
	/*
	 Use echo "ebff34ffb665de0694872dceabe0edeaf50ec5a9" > .git/HEAD followed by git reset to point to a ref instead of a branch. – 
cadorn
 Oct 18, 2012 at 19:03

Directly writing to the HEAD file is less dependable. What if you are in a subdir? For detached head (head pointing to SHA1 directly), try this: git update-ref HEAD refs/heads/otherbranch

git update-ref is useful, but it also moves the tip of the current branch. – 
tomekwi

	 */
	static public class _ReferenceX
	{
		



		static public void Exe( nilnul.fs.folder_.git_.work_.Top module, git.repo._reference.Name _ref, nilnul.win.prog_.Git git = null)
		{
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX.Void(module, "symbolic-ref HEAD " +  _ref,git);

		}


		static public void Exe( nilnul.fs.folder_.git_.Top module, git.repo._reference.Name _ref, nilnul.win.prog_.Git git = null)
		{
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX.Void(module, "symbolic-ref HEAD " +  _ref,git);

		}


		static public void Exe( nilnul.fs.FolderI module, string _ref, nilnul.win.prog_.Git git = null)
		{
			Exe(new fs.folder_.git_.work_.Top( module), new git.repo._reference.Name(  _ref),git);

		}


		static public void Exe( string module, string _ref, nilnul.win.prog_.Git git = null)
		{
			Exe( new fs.folder_.git_.work_.Top( module), new git.repo._reference.Name(  _ref),git);

		}

	
		static public void Exe( nilnul.fs.git.Module module, string _ref, nilnul.win.prog_.Git git = null)
		{
			Exe(module.top1, new git.repo._reference.Name(  _ref),git);

		}

	




	}
}
