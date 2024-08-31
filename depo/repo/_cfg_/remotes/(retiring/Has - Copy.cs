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



namespace nilnul.fs.git.module._cfg_.remotes
{
	[Obsolete()]
	static public class _HasX
	{
		static public bool Has(nilnul.fs.folder_.git_.Top module, _cfg_._remote.Name repoName , nilnul.win.prog_.Git git=null) {

			return remotes.Vw.GetRemotes_throws(module,git).Contains(repoName);

		}

		static public bool Has(nilnul.fs.folder_.git_.Top module, string repoName , nilnul.win.prog_.Git git=null) {

			return Has(module, new _remote.Name(repoName),git);

		}


		static public bool Has(nilnul.fs.Folder module, _cfg_._remote.Name repoName , nilnul.win.prog_.Git git=null) {
			return Has(new fs.folder_.GitTop(module), repoName,git);
		}

		static public bool Has(nilnul.fs.Folder module, string repoName , nilnul.win.prog_.Git git=null) {
			return Has(module, new _remote.Name( repoName),git);
		}
	
	}
}
