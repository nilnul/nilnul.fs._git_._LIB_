using nilnul.dev.git.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	public class Branch
	{

		
		static public void MoveBranch2Head() { }

		static public void _Commit(nilnul.win.prog_.Git git, string module, string _msg_noQuotationMark) {
			git.runCmd_throwErr(
				module
				,
				$"commit -m \"{_msg_noQuotationMark}\""

				);
		}

		static public void _Commit_allowEmpty(nilnul.win.prog_.Git git, string module, string _msg_noQuotationMark) {
			git.runCmd_throwErr(
				module
				,
				$"commit --allow-empty  -m\"{_msg_noQuotationMark}\""

				);
		}


		static public void _Commit( string module, string _msg_noQuotationMark) {
			_Commit(module, _msg_noQuotationMark);
		}

		public static void AddAll_n_Commit(Folder folderGit, string v)
		{

			AddAll_n_Commit(folderGit.git, folderGit.address.ToString(), v);
			//throw new NotImplementedException();
		}

		static public void _Commit( Folder folder, string _msg_noQuotationMark) {

			_Commit(folder.git,folder.address.ToString(), _msg_noQuotationMark);
		}


		static public void AddAll_n_Commit(nilnul.win.prog_.Git git, string module,string commitMsg) {
			Head._AddAll(git, module);
			_Commit_allowEmpty(git, module, commitMsg);
		}

		public static void _Commit_allowEmpty(Folder folder, string v)
		{
			_Commit_allowEmpty(folder.git,folder.address.ToString(), v);
			
		}
	}
}
