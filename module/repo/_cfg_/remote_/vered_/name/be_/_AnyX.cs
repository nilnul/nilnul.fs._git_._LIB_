using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vered_.name.be_
{
	static public class _AnyX
	{
		static public bool Be(
			nilnul.fs.git.ModuleI module
			,
			nilnul.txt_._vered_.Name name
			,
			nilnul.win.prog_.Git git=null
		) {
			return remotes._VwX.Seq(module, git).Any(
				x=> nilnul.txt_._NameVerX.IsNamedAs(name,x)
			);

		}

		static public bool Be(
			nilnul.fs.git.ModuleI module
			,
			string name
			,
			nilnul.win.prog_.Git git=null
		) {
			return Be(module , new txt_._vered_.Name( name),git);

		}

		static public bool Be(
			nilnul.fs.git.Module module
			,
			nilnul.txt_._vered_.Name name
			,
			nilnul.win.prog_.Git git=null
		) {
			return Be(module as nilnul.fs.git.ModuleI, name,git);

		}


		static public bool Be(
			nilnul.fs.folder_.git_.Top module
			,
			nilnul.txt_._vered_.Name name
			,
			nilnul.win.prog_.Git git=null
		) {
			return Be( new nilnul.fs.git.Module(module),name,git);
		}


		static public bool Be(
			nilnul.fs.folder_.git_.Top module
			,
			string name
			,
			nilnul.win.prog_.Git git=null
		) {
			return Be( module, new txt_._vered_.Name( name),git);
		}

		static public bool Be(
			nilnul.fs.FolderI module
			,
			string name
			,
			nilnul.win.prog_.Git git=null
		) {
			return Be(new nilnul.fs.folder_.git_.Top( module), ( name),git);
		}



		static public bool Be_ofModuleAddress(
			string module
			,
			string name
			,
			nilnul.win.prog_.Git git=null
		) {
			return Be(nilnul.fs.Folder.FroAddress( module), ( name),git);
		}


	}
}
