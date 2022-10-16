using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.branches
{
	static public class _LsX
	{
		/*
git-ls-remote - List references in a remote repository
git ls-remote [--heads] [--tags] [--refs] [--upload-pack=<exec>]
	      [-q | --quiet] [--exit-code] [--get-url]
	      [--symref] [<repository> [<refs>…​]]

DESCRIPTION
Displays references available in a remote repository along with the associated commit IDs.

OPTIONS
-h 
--heads 
-t 
--tags 
Limit to only refs/heads and refs/tags, respectively. These options are not mutually exclusive; when given both, references stored in refs/heads and refs/tags are displayed.
--refs 
Do not show peeled tags or pseudorefs like HEAD in the output.
			 */
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_module"></param>
		/// <returns></returns>
		static public string _GitMsg(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string remote)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(_module, $"ls-remote -h {remote}");

		}


		static public IEnumerable<string> _Ls(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string remote)
		{
			return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(_module, $"ls-remote -h {remote}")

				).Select(
					y => nilnul.txts.fro_.txt_.split_._SpaceTab._DelWhite(y).ElementAt(1)
				).Select(z=> nilnul.txts.fro_.txt_.split_.Slash.Singleton.eval_delEmpty(z).ElementAt(2))
			;
		}


		static public IEnumerable<string> _Path(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string remote)
		{
			return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(_module, $"ls-remote -h {remote}")

				).Select(
					y => nilnul.txts.fro_.txt_.split_._SpaceTab._DelWhite(y).ElementAt(1)
				)
			;
		}

		static public IEnumerable<string> _Path( nilnul.fs.Folder _module, string remote)
		{
			return _Path(nilnul.win.prog_.Git.StaticInstance, _module,remote)			;
		}


		static public IEnumerable<string> _Ls( nilnul.fs.Folder _module, string remote)

		{
			return _Ls(nilnul.win.prog_.Git.StaticInstance, _module, remote);
		}

		static public string _GitMsg(nilnul.fs.Folder _module, string remote)
		{
			return _GitMsg(nilnul.win.prog_.Git.StaticInstance, _module, remote);

		}





	}
}
