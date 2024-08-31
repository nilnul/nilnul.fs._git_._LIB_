using nilnul.dev.git;
using nilnul.web;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.url.change_
{
	static public class _EnsureAccX
	{
		static public void Void(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remote
			,
			nilnul.web.UrlI3 oldUrl

			,
			nilnul.web._url._origin._authority._credential.Acc acc
			,
			nilnul.win.prog_.Git git = null

		)
		=>
			_ChangeX.Void(
				module
				,
				remote
				,oldUrl
				,nilnul.web.url.convert_._EnsureAccX.Op(oldUrl,acc)
				,
				git
			);

		public static void Void(ModuleI module, string remote, 
			UrlI3 url
			,
			nilnul.web._url._origin._authority._credential.Acc acc
			, win.prog_.Git git)
		=> Void(
			module,
			new _remote.Name(remote), 
			url			
			,
			acc,
			git
		);
		
		
		static public void Void(
			nilnul.fs.git.ModuleI folder
			, _remote.Name remote
			,
			string oldUrl
			
						,
			nilnul.web._url._origin._authority._credential.Acc acc
,
			 nilnul.win.prog_.Git git = null)
		=>
			Void(folder , remote, nilnul.web.url._ParseX3.Parse( oldUrl), acc, git);
		
		public static void Void(ModuleI gitTop, string v
			,
			string oldUrl
			
						,
			nilnul.web._url._origin._authority._credential.Acc acc
,
			 nilnul.win.prog_.Git git = null

) => Void(gitTop, new _remote.Name(v), oldUrl, acc, git);



		static public void Void(
			nilnul.fs.git.Module folder
			, _remote.Name remote
			,
			string oldUrl
			
					,
			nilnul.web._url._origin._authority._credential.Acc acc
	,
			 nilnul.win.prog_.Git git = null)
		{
			Void(folder as nilnul.fs.git.ModuleI, remote,  oldUrl,acc,  git);
		}

		static public void Void(
			nilnul.fs.folder_.git_.Top folder
			,
			_remote.Name remote
			,
			string oldUrl
				,
			nilnul.web._url._origin._authority._credential.Acc acc
		,
			nilnul.win.prog_.Git git = null
		)
		{
			Void(new nilnul.fs.git.Module(folder), remote, oldUrl,  acc,git);
		}


		static public void Void(
			nilnul.fs.folder_.git_.Top folder,
			string remote
			,
			string oldUrl
				,
			nilnul.web._url._origin._authority._credential.Acc acc
		,
			nilnul.win.prog_.Git git = null)
		{
			Void(folder, new _remote.Name(remote), oldUrl, acc, git);
		}

		static public void Void(
			nilnul.fs.FolderI folder, _remote.Name remote
			,
			string oldUrl
				,
			nilnul.web._url._origin._authority._credential.Acc acc
		,
			 nilnul.win.prog_.Git git = null
			)
		=> Void(new fs.folder_.git_.Top(folder), remote, oldUrl, acc, git);

		static public void Void(nilnul.fs.FolderI folder, string remote,
			string oldUrl
						,
			nilnul.web._url._origin._authority._credential.Acc acc
,
			nilnul.win.prog_.Git git = null)
		=> Void(new fs.folder_.git_.Top(folder), new _remote.Name(remote), oldUrl,acc,  git);


		static public void Void(string folder, string remote,
			string oldUrl
						,
			nilnul.web._url._origin._authority._credential.Acc acc
,
			nilnul.win.prog_.Git git = null)
		=>
			 Void(fs.folder_.git_.Top.FroAddress(folder), new _remote.Name(remote), oldUrl,  acc,git);


	}


}
