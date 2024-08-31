using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_.vs_.next
{
	static public class _CreateX
	{
		static public void Exe(
			string prefix,
			nilnul.fs.git.ModuleI module
			,
			txt_._vered_.Name remoteKey1
			,
			nilnul.fs.git.svr.repo.Name repoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			

			var remoteKey = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NextX.NameVer(
				module
				,
				new txt_._vered_.Name(
					remoteKey1
				)
				,
				git
			);

			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				module
				,

				remoteKey.ToString()
				,

				nilnul.fs.git.svr_.vs_.prefixed.repo._UrlX.Gen(prefix,repoName)
			);

		}

		public static void Exe(
			string prefix,
			nilnul.fs.git.Module folder
			,
			txt_._vered_.Name remoteKey1
			,
			nilnul.fs.git.svr.repo.Name name
			,
			G git = null
		)
		{
			Exe(
				prefix,
				folder as ModuleI,
				remoteKey1
				,
				name
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(
			string prefix,
			nilnul.fs.git.Module folder
			,
			txt_._vered_.Name remoteKey1
			,
			string name
			,
			G git = null
		)
		{
			Exe(
				prefix,
				folder as ModuleI,
				remoteKey1
				,
				  new svr.repo.Name(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(
			string prefix
			,
			string folder
			,
			txt_._vered_.Name remoteKey1
			,
			string name
			,
			G git = null
		)
		{
			Exe(
				prefix,
				Module.FroAddress(folder)
									,
			remoteKey1

				,
				name
				,
				git
			);
		}
	}
}