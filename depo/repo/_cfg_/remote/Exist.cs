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



namespace nilnul.fs.git.module.repo._cfg_.remote
{
	static public class _ExistX
	{
		static public bool Be(nilnul.fs.git.ModuleI module, _cfg_._remote.Name remoteName , nilnul.win.prog_.Git git=null) {
			return remotes._VwX.Seq(module,git).Contains(remoteName);
		}

		static public bool Be(nilnul.fs.git.ModuleI module, string remoteName , nilnul.win.prog_.Git git=null) {
			return Be(module,new _remote.Name(remoteName),git);
		}

		static public bool Be(nilnul.fs.git.Module module, _cfg_._remote.Name remoteName , nilnul.win.prog_.Git git=null) {
			return Be(module as ModuleI,remoteName,git);
		}

		static public bool Be(nilnul.fs.folder_.git_.Top module, _cfg_._remote.Name remoteName , nilnul.win.prog_.Git git=null) {
			return Be(new nilnul.fs.git.Module(module),remoteName,git);
		}

		static public bool Be(nilnul.fs.folder_.git_.Top module, string repoName , nilnul.win.prog_.Git git=null) {
			return Be(module, new _remote.Name(repoName),git);
		}

		static public bool Be(nilnul.fs.FolderI module, _cfg_._remote.Name repoName , win.prog_.Git git=null) {
			return Be(new fs.folder_.git_.Top(module), repoName,git);
		}

		static public bool Be(nilnul.fs.FolderI module, string repoName , win.prog_.Git git=null) {
			return Be(module, new _remote.Name( repoName),git);
		}
	}
}