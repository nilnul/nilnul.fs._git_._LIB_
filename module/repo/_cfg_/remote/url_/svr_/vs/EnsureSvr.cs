﻿using System;
using System.Linq;
using nilnul.win.prog_;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote.url_.svr_.vs
{
	public static class _EnsureSvrX
	{
		public static string Json(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remoteName
			,
			nilnul.win.prog_.Git git = null
		)
		{

			nilnul.web._url._resource._render._route.DivisionI division = nilnul.web.url._ParseX3.Parse(
				nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(
					module
					,

					remoteName
					,
					git

				)
			).route.division;

			string repoName;

			switch (division)
			{
				case nilnul.web._url._resource._render._route.Div div:
					repoName = div.dirs.Last().name;
					break;
				case nilnul.web._url._resource._render._route.div.Document document:
					repoName = document.doc.ToString(

					);
					break;
				default:
					throw new UnexpectedTypeException($"the type:{division.GetType()} of {division} is not div or document ");
					break;
			}


			string r = nilnul.fs.git.svr_.vs_.prefixed_.cfged.client_.vaulted.repo.create_.prjDefault._EnsureX.ResultAsTxt_repoNameAlreadyNormal(
					repoName
				);


			;

			return r;

		}

		public static string Json(ModuleI module, string v, G git)
		{
			return Json(module,new _remote.Name(v),git);
		}

		public static string Json(
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remoteName
			,
			G git = null
		)
		{
			return Json(
				folder as ModuleI,
				remoteName
				, git
			);
			//throw new NotImplementedException();
		}

		public static string Json(
			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			return Json(
				folder as ModuleI,
				  new nilnul.fs.git.module.repo._cfg_._remote.Name
(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static string Json(string folder, string name, G git = null)
		{
			return Json(
				Module.FroAddress(folder)
				,
				name
				,
				git
			);
		}
	}
}