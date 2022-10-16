using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._commits_.commit.msg
{
	/// <summary>
	/// </summary>
	public class Amend
	{
		

		static public void Exe(string workingDir, string commitMsg)
		{
			Git.StaticInstance.runCmd_throwErr(workingDir, $@"commit --amend -m""{commitMsg.Replace(@"""", "_")}""");

		}



		static public void Exe(nilnul.fs.Folder workingDir, string commitMsg)
		{
			Git.StaticInstance.runCmd_throwErr(workingDir, $@"commit --amend -m""{commitMsg.Replace(@"""", "_")}""");

		}


		/// <summary>
		/// 	•Use single quote message delimiters to avoid potentially losing parts of your commit messages identified as variables unknowingly.
		/// 	•Escape apostrophes in the message using '\'
		/// </summary>
		/// <param name="workingDir"></param>
		/// <param name="commitMsg"></param>
		//static public void Exe_escapeApostrophe(nilnul.fs.Folder workingDir, string commitMsg)
		//{
		//	Git.StaticInstance.runCmd_throwErr(workingDir, $@"commit -m'{nilnul.txt.convert_._EscapeX._ApostropheSlashed(commitMsg)}'");

		//}


		/*
		 Use single quotes instead of double quotes
git commit -am 'Nailed it!'

Alternatively, if you need to use double quotes for whatever reason but still want a literal ! then turn off history expansion at the top of your script via set +H

		Another way to solve that is to add a space after ! like:
git commit -am "Nailed it! "

Note the space between ! and the last ".

(The space won't be included in the commit message - nilnul.win.prog_.Git trims trailing whitespace from commit messages automatically.)


	

		 
		 */



	}
}
