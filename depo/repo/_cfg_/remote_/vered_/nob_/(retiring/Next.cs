using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.nameInId_
{
	static public class _NextX
	{
		static public nilnul.txt_.NameVer NameVer(
			nilnul.fs.git.ModuleI folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.prog_.Git git = null) {

			var latest = newest._NulableX.Txt(folder, name, git);
			if (latest==null)
			{
				return new txt_.NameVer(name);
			}
			return nilnul.txt_.nameVer.op_.unary_._NextX.Next(latest);

		}

		


		static public nilnul.txt_.NameVer NameVer(
			nilnul.fs.git.Module folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.prog_.Git git = null)
		{

			return NameVer( folder as ModuleI,name,git);

		}

		static public nilnul.txt_.NameVer NameVer(
			nilnul.fs.folder_.git_.Top folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.prog_.Git git = null)
		{

			return NameVer( new nilnul.fs.git.Module(folder),name,git);

		}

		static public nilnul.txt_.NameVer _NameVer_moduleAddress(
			string folder,
			string name,
			nilnul.win.prog_.Git git = null)
		{

			return NameVer( 
				nilnul.fs.git.Module.FroAddress(folder)
				,
				new txt_._nameVer_.Name(name)
				,

				git
			);

		}



	}
}
