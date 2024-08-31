using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.git.module.repo._cfg_._remote;
using nilnul.obj.str;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo._cfg_.remote.urls_.push
{
	static public class _InsX1
	{
		/*
		 Sometimes you need to keep two upstreams in sync with eachother. For example, you might need to both push to your testing environment and your GitHub repo at the same time. In order to do this simultaneously in one git command, here's a little trick to add multiple push URLs to a single remote.

Once you have a remote set up for one of your upstreams, run these commands with:
git remote set-url --add --push [remote] [original repo URL]
git remote set-url --add --push [remote] [second repo URL]


Once set up,  git remote -v  should show two (push) URLs and one (fetch) URL. Something like this:
$ git remote -v
origin git@github.com:bjmiller121/original-repo.git (fetch)
origin git@github.com:bjmiller121/original-repo.git (push)
origin git@github.com:bjmiller121/second-repo.git (push)


Now, pushing to this remote will push to both upstreams simultaneiously. Fetch and pull from this remote will still pull from the original repo only.

Tip: If you always want to push to both upstreams simultaneously, you might want to use the  origin  remote. If you only sometimes want to push to both, you might use a remote name like  both  to indicate that it will push to multiple repos.

			git remote set-url --add [--push] <name> <newurl>


			git remote set-url origin --push --add user1@repo1

git remote set-url origin --push --add user2@repo2



			 */
		static public void Exe(nilnul.fs.git.ModuleI folder, _remote.Name remote, nilnul.web.UrlI3 url, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(folder,$"remote set-url --add {remote} {url}",git);

		}

		static public void Exe(nilnul.fs.git.Module folder, _remote.Name remote, nilnul.web.UrlI3 url, nilnul.win.prog_.Git git=null)
		{
			Exe(folder as nilnul.fs.git.ModuleI,remote,url,git);

		}
		static public void Exe(nilnul.fs.folder_.git_.Top folder, _remote.Name remote, nilnul.web.UrlI3 url, nilnul.win.prog_.Git git=null)
		{
			Exe(new nilnul.fs.git.Module(folder),remote,url,git);

		}

		static public void Exe(nilnul.fs.folder_.git_.Top folder, _remote.Name remote, string url, nilnul.win.prog_.Git git=null)
		{
			Exe(folder, remote, nilnul.web.url._ParseX3.Parse(url), git);
			

		}

		static public void Exe(nilnul.fs.FolderI folder, string remote, string url, nilnul.win.prog_.Git git=null)
		{
			Exe(new fs.folder_.git_.Top( folder), new _remote.Name( remote), nilnul.web.url._ParseX3.Parse(url), git);
		}

		static public void Exe(string folder, string remote, string url, nilnul.win.prog_.Git git=null)
		{
			Exe( fs.folder_.git_.Top.FroAddress( folder), new _remote.Name( remote), nilnul.web.url._ParseX3.Parse(url), git);
		}

		static  public void Exe(ModuleI gitTop, _remote.Name name, string u, win.prog_.Git git)
		{
			Exe(gitTop, name, nilnul.web.url._ParseX3.Parse(u),git);
		}

		static  public void Exe(ModuleI gitTop, string name, string u, win.prog_.Git git)
		{
			Exe(gitTop, new _remote.Name(name), nilnul.web.url._ParseX3.Parse(u),git);
		}

		public static void Vod(ModuleI module, string remoteName4umbrella, IEnumerable<string> enumerable, Git git)
		{

			enumerable.Each(
				u=>
				Exe(module,remoteName4umbrella,u,git)
			);

		}
	}
}
