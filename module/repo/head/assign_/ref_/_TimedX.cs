using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo.head.assign_.ref_
{
	/*es, you can do this.

git symbolic-ref HEAD refs/heads/otherbranch
If you need to commit on this branch, you'll want to reset the index too otherwise you'll end up committing something based on the last checked out branch.

git reset*/
	static public class _TimedX
	{
		



		static public void Exe( nilnul.fs.folder_.git_.work_.Top module, git.repo._reference.Name _ref, nilnul.win.prog_.Git git = null)
		{
			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void
			nilnul.os.prog_.git.run_.timed_.ended.result._Vow_codOkX.Vow
				(module, "symbolic-ref HEAD " +  _ref,git);

		}


		static public void Exe( nilnul.fs.folder_.git_.Top module, git.repo._reference.Name _ref, nilnul.win.prog_.Git git = null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(module, "symbolic-ref HEAD " +  _ref,git);

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
