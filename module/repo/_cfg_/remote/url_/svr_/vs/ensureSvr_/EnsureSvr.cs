using System;
using System.Linq;
using nilnul.win.prog_;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote.url_.svr_.vs.ensureSvr_
{
	public static class _ViaLibX
	{
		public static _op.result_.explain_.RetTxt Result(
			nilnul.fs.git.svr_.vs.client_.AccInVault client,
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


			var r = nilnul.fs.git.svr_.vs.client.teamwork.create_.personal._EnsureX.Result(
					client,
					repoName
				);


			;

			return r;

		}

		public static _op.result_.explain_.RetTxt Result(
			nilnul.fs.git.svr_.vs.client_.AccInVault client,
			ModuleI module, string v, G git=null)
		{
			return Result(client,module,new _remote.Name(v),git);
		}

		public static _op.result_.explain_.RetTxt Result(
			nilnul.fs.git.svr_.vs.client_.AccInVault client,

			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remoteName
			,
			G git = null
		)
		{
			return Result(
				client,
				folder as ModuleI,
				remoteName
				, git
			);
			//throw new NotImplementedException();
		}

		public static _op.result_.explain_.RetTxt Result(
			nilnul.fs.git.svr_.vs.client_.AccInVault client,

			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			return Result(
				client,

				folder as ModuleI,
				  new nilnul.fs.git.module.repo._cfg_._remote.Name
(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static _op.result_.explain_.RetTxt Result(
			nilnul.fs.git.svr_.vs.client_.AccInVault client,

			string folder, string name, G git = null
		)
		{
			return Result(
				client,
				Module.FroAddress(folder)
				,
				name
				,
				git
			);
		}
	}
}