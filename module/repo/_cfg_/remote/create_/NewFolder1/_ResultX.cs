﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.txt_;
using nilnul.web;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo._cfg_._remote.create_
{
	//extern alias web;
	//extern alias fs;
	static public class _ResultX
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
		public static os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.ModuleI folder,
			Name remoteName,
			nilnul.web.UrlI3 url, 
			nilnul.win.prog_.Git git=null)
		{
			return nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(
				folder
				,
				$"remote add {remoteName} {url}"
				,git
			);
		}

		public static os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.ModuleI folder,
			string remoteName,
			string url, 
			nilnul.win.prog_.Git git=null)
		{
			return Result(
				folder
				, 
				new Name(remoteName) 
				, 
				 nilnul.web.url._ParseX3.Parse(url)
				,
				git
			);
		}

		public static os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.git.Module folder,
			Name remoteName,
			nilnul.web.UrlI3 url, 
			nilnul.win.prog_.Git git=null)
		{
			return Result(folder as ModuleI, remoteName,url,git);
		}

		public static os.proc_.finished._result.CodMsgErr Result(
			nilnul.fs.folder_.git_.Top folder,
			Name remoteName,
			nilnul.web.UrlI3 url, 
			nilnul.win.prog_.Git git=null)
		{
			return Result( 
				new Module(folder)
				,
				remoteName
				,
				url
				,
				git
				
			);
		}

		public static os.proc_.finished._result.CodMsgErr Result(nilnul.fs.folder_.git_.Top folder, Name remoteName,string  url, nilnul.win.prog_.Git git=null)
		{
			return Result(folder,remoteName, nilnul.web.url._ParseX3.Parse(url) );
		}

		public static os.proc_.finished._result.CodMsgErr Result(nilnul.fs.folder_.git_.Top folder, string v, UrlI3 url, win.prog_.Git git)
		{
			return Result(folder, new Name(v),url,git);
		}

		public static os.proc_.finished._result.CodMsgErr Result(nilnul.fs.folder_.git_.Top folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			return Result(
				folder,
				new Name(remoteName)
				,
				nilnul.web.url._ParseX3.Parse(url)
			);
			
		}


		public static os.proc_.finished._result.CodMsgErr Result(nilnul.fs.FolderI folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			return Result( new nilnul.fs.folder_.git_.Top(folder) ,remoteName,url,git);
		}

		public static os.proc_.finished._result.CodMsgErr Result(ModuleI folder, string v, UrlI3 url, win.prog_.Git git)
		{
			return Result(folder,new Name(v),url,git);
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