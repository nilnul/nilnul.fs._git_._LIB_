using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt;
using nilnul.txt.str;
using nilnul.txt.str.fro;
using nilnul.txt.str.fro._lines;



namespace nilnul.fs.git.module.repo._cfg_.remotes
{
	static public class _HasX1
	{
		static public bool Has(nilnul.fs.folder_.git_.Top module, _cfg_._remote.Name repoName , nilnul.win.prog_.Git git=null) {

			return remotes._VwX.Seq(module,git).Contains(repoName);

		}

		static public bool Has(nilnul.fs.folder_.git_.Top module, string repoName , nilnul.win.prog_.Git git=null) {

			return Has(module, new _remote.Name(repoName),git);

		}


		static public bool Has(nilnul.fs.FolderI module, _cfg_._remote.Name repoName , win.prog_.Git git=null) {
			return Has(new fs.folder_.git_.Top(module), repoName,git);
		}

		static public bool Has(nilnul.fs.FolderI module, string repoName , win.prog_.Git git=null) {
			return Has(module, new _remote.Name( repoName),git);
		}
	
	}
}
