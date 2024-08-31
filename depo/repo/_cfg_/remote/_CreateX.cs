using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.txt_;
using nilnul.web;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo._cfg_.remote
{
	//extern alias web;
	//extern alias fs;
	static public class _CreateX
	{
		/*
		 You may encounter these errors when trying to add a remote.
Remote name already exists
This error means you've tried to add a remote with a name that already exists in your local repository:
$ git remote add origin https://github.com/octocat/Spoon-Knife
fatal: remote origin already exists.
		 */

		///// <exception cref="">
		/////  url is required
		///// </exception>
		//[Obsolete("url is required",true)]
		//static  void WithoutUrl(Folder folder, string remote)
		//{
		//	folder.runCmd_throwErr($"remote add {remote}");

		//}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="remoteName"></param>
		/// <param name="url"></param>
		/// <param name="git"></param>
		/// <exception cref="">
		/// exit code:3 # remote already exists.
		/// </exception>
		public static void RetVoid(
			nilnul.fs.git.ModuleI folder,
			repo._cfg_._remote.Name remoteName,
			nilnul.web.UrlI3 url, 
			nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				folder
				,
				$"remote add {remoteName} {url}"
				,git
			);
		}

		public static void _Vod_assumeModuleAddress1Remote1Urn(
			string folder,
			string remoteName,
			string url, 
			nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.cod.vow_._NilX.OfAddress(
				folder
				,
				$"remote add {remoteName} {url}"
				,
				git
			);
		}
		public static void _Vod_assumeUrn(
			nilnul.fs.git.ModuleI folder,
			repo._cfg_._remote.Name remoteName,
			string url, 
			nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				folder
				,
				$"remote add {remoteName} {url}"
				,git
			);
		}



		public static void RetVoid(
			nilnul.fs.git.ModuleI folder,
			string remoteName,
			string url, 
			nilnul.win.prog_.Git git=null)
		{
			RetVoid(
				folder
				, 
				new repo._cfg_._remote.Name(remoteName) 
				, 
				 nilnul.web.url._ParseX3.Parse(url)
				,
				git
			);
		}

		public static void _Vod_assumeUrn(
			nilnul.fs.git.ModuleI folder,
			string remoteName,
			string url, 
			nilnul.win.prog_.Git git=null)
		{
			_Vod_assumeUrn(
				folder
				, 
				new repo._cfg_._remote.Name(remoteName) 
				, 
				(url)
				,
				git
			);
		}

		public static void RetVoid(
			nilnul.fs.git.Module folder,
			nilnul.fs.git.module.repo._cfg_._remote.Name remoteName,
			nilnul.web.UrlI3 url, 
			nilnul.win.prog_.Git git=null)
		{
			RetVoid(folder as ModuleI, remoteName,url,git);
		}
		public static void _Vod_assumeUrn(
			nilnul.fs.git.Module folder,
			nilnul.fs.git.module.repo._cfg_._remote.Name remoteName,
			string url, 
			nilnul.win.prog_.Git git=null)
		{
			_Vod_assumeUrn(folder as ModuleI, remoteName,url,git);
		}


		public static void RetVoid(
			nilnul.fs.folder_.git_.Top folder,
			repo._cfg_._remote.Name remoteName,
			nilnul.web.UrlI3 url, 
			nilnul.win.prog_.Git git=null)
		{
			RetVoid( 
				new Module(folder)
				,
				remoteName
				,
				url
				,
				git
				
			);
		}

		public static void _Vod_assumeUrn(
			nilnul.fs.folder_.git_.Top folder,
			repo._cfg_._remote.Name remoteName,
			string url, 
			nilnul.win.prog_.Git git=null)
		{
			_Vod_assumeUrn( 
				new Module(folder)
				,
				remoteName
				,
				url
				,
				git
				
			);
		}

		public static void RetVoid(nilnul.fs.folder_.git_.Top folder, repo._cfg_._remote.Name remoteName,string  url, nilnul.win.prog_.Git git=null)
		{
			RetVoid(folder,remoteName, nilnul.web.url._ParseX3.Parse(url) );
		}

		public static void RetVoid(nilnul.fs.folder_.git_.Top folder, string v, UrlI3 url, win.prog_.Git git)
		{
			RetVoid(folder, new repo._cfg_._remote.Name(v),url,git);
		}

		public static void RetVoid(nilnul.fs.folder_.git_.Top folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			RetVoid(
				folder,
				new repo._cfg_._remote.Name(remoteName)
				,
				nilnul.web.url._ParseX3.Parse(url)
			);
			
		}

		public static void _Vod_assumeUrn(nilnul.fs.folder_.git_.Top folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			_Vod_assumeUrn(
				folder,
				new repo._cfg_._remote.Name(remoteName)
				,
				(url)
			);
			
		}

		public static void RetVoid(nilnul.fs.FolderI folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			RetVoid( new nilnul.fs.folder_.git_.Top(folder) ,remoteName,url,git);
		}
		public static void _Vod_assumeUrn(nilnul.fs.FolderI folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			_Vod_assumeUrn( new nilnul.fs.folder_.git_.Top(folder) ,remoteName,url,git);
		}

		public static void Vod_moduleOfAddress(string folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			RetVoid(  nilnul.fs.Folder.FroAddress(folder) ,remoteName,url,git);
		}

		public static void _Vod_moduleOfAddress_assumeUrn(string folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			_Vod_assumeUrn(  nilnul.fs.Folder.FroAddress(folder) ,remoteName,url,git);
		}


		public static void RetVoid(ModuleI folder, string v, UrlI3 url, win.prog_.Git git)
		{
			RetVoid(folder,new repo._cfg_._remote.Name(v),url,git);
		//	throw new NotImplementedException();
		}

		///*
		// 			 git config --add remote.origin.url git@host.com:user/repo.git
		//	seems exception.
		//	 */
		//[Obsolete("exception",true)]
		//static  void WithoutUrl_byCfg(Folder folder, string remote)
		//{
		//	folder.runCmd_throwErr($"config --add remote {remote}");
		//}
	}
}