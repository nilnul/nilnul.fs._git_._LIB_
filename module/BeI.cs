using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	public interface BeI:nilnul.BeI<ModuleI>, nilnul.obj.BeI1<ModuleI>
	{
	}
	static public class BeX
	{
		static public bool Be(
			this BeI be
			,
			nilnul.fs.folder_.git_.work_.Top folder
		) {

			return ((nilnul.obj.BeI1<ModuleI>)be).be(new nilnul.fs.git.Module(folder));
		}
		static public bool _Be_assumeWorkbase(
			this BeI be
			,
			nilnul.fs.FolderI folder
		) {

			return ((nilnul.obj.BeI1<ModuleI>)be).be(new nilnul.fs.git.Module(folder));
		}

		[Obsolete(nameof(_Be_assumeWorkbase))]
		static public bool Be(
			this BeI be
			,
			nilnul.fs.FolderI folder
		) {

			return _Be_assumeWorkbase(be,folder);
		}

		static public bool _Be_assumeWorkbaseAddress(
			this BeI be
			,
			string folder
		) {
			return Be(be, nilnul.fs.Folder.FroAddress(folder));
		}

		[Obsolete(nameof(_Be_assumeWorkbaseAddress))]
		static public bool Be_ofAddress(
			this BeI be
			,
			string folder
		) {
			return _Be_assumeWorkbaseAddress(be, (folder));
		}





	}


}
