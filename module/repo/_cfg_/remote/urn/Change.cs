using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.urn
{
	static public class _ChangeX
	{
		/*
		 $ git remote set-url sofake https://github.com/octocat/Spoon-Knife

		Changes URLs for the remote. Sets first URL for remote <name> that matches regex <oldurl> (first URL if no <oldurl> is given) to <newurl>. If <oldurl> doesn’t match any URL, an error occurs and nothing is changed. 


With --push, push URLs are manipulated instead of fetch URLs.


With --add, instead of changing existing URLs, new URL is added.


With --delete, instead of changing existing URLs, all URLs matching regex <url> are deleted for remote <name>. Trying to delete all non-push URLs is an error.


Note that the push URL and the fetch URL, even though they can be set differently, must still refer to the same place. What you pushed to the push URL should be what you would see if you immediately fetched from the fetch URL. If you are trying to fetch from one place (e.g. your upstream) and push to another (e.g. your publishing repository), use two separate remotes.


		 */

		static public void _Void_urlsAreTxt(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remote
			,
			string oldUrl
			,
			string newUrl
			,
			nilnul.win.prog_.Git git = null

		)
		{

			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				module
				,
				$"remote set-url -- {remote} {newUrl} {oldUrl}"
				,
				git
			);
		}


		static public void Void(
			nilnul.fs.git.Module folder
			, _remote.Name remote
			,
			string oldUrl
			,
			 string newUrl
			,
			 nilnul.win.prog_.Git git = null)
		{
			_Void_urlsAreTxt(folder as nilnul.fs.git.ModuleI, remote, oldUrl, newUrl, git);
		}

		static public void Void(
			nilnul.fs.folder_.git_.Top folder
			,
			_remote.Name remote
			,
			string oldUrl
			,
			 string newUrl
			,
			nilnul.win.prog_.Git git = null
		)
		{
			Void(new nilnul.fs.git.Module(folder), remote, oldUrl, newUrl, git);
		}

		static public void Void(
			nilnul.fs.folder_.git_.Top folder,
			string remote
			,
			string oldUrl
			,
			 string newUrl
			,
			nilnul.win.prog_.Git git = null)
		{
			Void(folder, new _remote.Name(remote), oldUrl, newUrl, git);
		}

		static public void Void(
			nilnul.fs.FolderI folder, _remote.Name remote
			,
			string oldUrl
			,
			 string newUrl
			,
			 nilnul.win.prog_.Git git = null
			)
		=> Void(new fs.folder_.git_.Top(folder), remote, oldUrl, newUrl, git);

		public static void Void(ModuleI gitTop, string v
			,
			string oldUrl
			,
			 string newUrl
			,
			 nilnul.win.prog_.Git git = null

		) => _Void_urlsAreTxt(gitTop, new _remote.Name(v), oldUrl, newUrl, git);

		static public void Void(
			nilnul.fs.FolderI folder
			,
			string remote,
			string oldUrl
			,
			 string newUrl
		, nilnul.win.prog_.Git git = null
			)
		=> Void(new fs.folder_.git_.Top(folder), new _remote.Name(remote), oldUrl, newUrl, git);


		static public void Void(
			string folder,
			string remote,
			string oldUrl
			,
			 string newUrl
		, nilnul.win.prog_.Git git = null
		)
		=>
			 Void(fs.folder_.git_.Top.FroAddress(folder), new _remote.Name(remote), oldUrl, newUrl, git);


	}


}
