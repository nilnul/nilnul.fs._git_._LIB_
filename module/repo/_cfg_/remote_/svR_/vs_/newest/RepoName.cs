using System;
using System.Linq;
using nilnul.win.prog_;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_.vs_.newest
{
	public static class _RepoNameX
	{
		public static string Txt(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remoteName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			nilnul.web._url._resource._render._route.DivisionI routeDivision = nilnul.web.url._ParseX3.Parse(
				nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(
					module
					,
					nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NewestX.Txt(
						module,
						nilnul.txt_._NameVerX.GetName(remoteName)
						, git
					)
					,
					git

				)
			).route.division;

			string repoName;
			switch (routeDivision)
			{
				case nilnul.web._url._resource._render._route.Div div:
					repoName = div.dirs.Last().name;
					break;
				case nilnul.web._url._resource._render._route.div.Document document:
					repoName = document.doc.ToString();
					break;
				default:
					throw new UnexpectedTypeException($"the type:{routeDivision.GetType()} of {routeDivision} is not div or document ");
					break;
			}
			return repoName;
		}

		internal static string Txt(ModuleI module, string v, G git)
		{
			return Txt(module,new _remote.Name(v),git);
		}

		public static string Txt(
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remoteName
			,
			G git = null
		)
		{
			return Txt(
				folder as ModuleI,
				remoteName
				, git
			);
			//throw new NotImplementedException();
		}

		public static string Txt(
			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			return Txt(
				folder as ModuleI,
				  new nilnul.fs.git.module.repo._cfg_._remote.Name
(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static string Txt(string folder, string name, G git = null)
		{
			return Txt(
				Module.FroAddress(folder)
				,
				name
				,
				git
			);
		}
	}
}