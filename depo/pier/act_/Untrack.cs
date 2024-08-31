using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage.act_
{
	/*
git rm --cached README
		 */
	static public class _UntrackX
	{

		/*If you already have a file checked in, and you want to ignore it, nilnul.win.prog_.Git will not ignore the file if you add an ignore rule later.In those cases, you must untrack the file first, by running the following command in your terminal:
$ git rm --cached FILENAME

			*/

		static public void Untrack(nilnul.fs.Folder gitTop, string document, nilnul.win.prog_.Git git=null) {

			 nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				gitTop
				,
				$"rm --cached {document}"
			);
		}

		/// <summary>
		/// git rm -r --cached **/*.jar
		///** may be not necessary
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="ext"></param>
		/// <param name="git"></param>
		static public void UntrackExt(nilnul.fs.Folder gitTop, string ext, nilnul.win.prog_.Git git=null) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				gitTop
				,
				//$@"rm -r --cached /*.{ext}"	//exception: /*.jfm is outside repo
				$@"rm -r --cached **/*.{ext}"	//exception: /*.jfm is outside repo
				,git


			);
		}



	}
}
