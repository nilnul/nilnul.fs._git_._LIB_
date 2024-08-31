using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.ver_
{
	static public class _NextX
	{
		static public nilnul.txt_.NameVer NameVer(
			nilnul.fs.git.ModuleI folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.program_.Git git = null) {

			var latest = vw._NewestOrNulX.Exe(folder, name, git);
			if (latest==null)
			{
				return new txt_.NameVer(name);
			}
			return nilnul.txt_.nameVer.convert_._NextX.Next(latest);

		}

		


		static public nilnul.txt_.NameVer NameVer(
			nilnul.fs.git.Module3 folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.program_.Git git = null)
		{

			return NameVer( folder as ModuleI,name,git);

		}

		static public nilnul.txt_.NameVer NameVer(
			nilnul.fs.folder_.git_.Top2 folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.program_.Git git = null)
		{

			return NameVer( new nilnul.fs.git.Module3(folder),name,git);

		}

		static public nilnul.txt_.NameVer _NameVer_moduleAddress(
			string folder,
			string name,
			nilnul.win.program_.Git git = null)
		{

			return NameVer( 
				nilnul.fs.git.Module3.FroAddress(folder)
				,
				new txt_._nameVer_.Name(name)
				,

				git
			);

		}



	}
}
