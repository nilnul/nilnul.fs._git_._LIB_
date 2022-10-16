using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.ver_.newest
{
	static public class _VwX
	{
		public static string Exe(
			nilnul.fs.git.ModuleI folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.program_.Git git = null
		)
		{
			return
				nilnul.txt.aggregate_.VerLatestOrNul.Singleton.aggregate(
					_VwX.Exe(folder,name,git) 
				)
			;

		}

		public static string Exe(
			nilnul.fs.git.Module3 folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.program_.Git git = null
		)
		{
			return
				Exe(folder as nilnul.fs.git.ModuleI, name,git)
			;

		}

		public static string Exe(
			nilnul.fs.folder_.git_.Top2 folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.program_.Git git = null
		)
		{
			return
				Exe( new nilnul.fs.git.Module3(folder),name,git)
			;

		}


		public static string Exe(
			nilnul.fs.folder_.git_.Top2 folder,
			string name,
			nilnul.win.program_.Git git = null
		)
		{
			return
				Exe( folder,new txt_._nameVer_.Name( name),git)
			;

		}

		


		public static string Exe(nilnul.fs.FolderI3 folder, string name, nilnul.win.program_.Git git = null)
		{
			return Exe(new nilnul.fs.folder_.git_.Top2(folder), name, git);

		}
		public static string Exe(string folder, string name, nilnul.win.program_.Git git = null)
		{
			return Exe( nilnul.fs.folder_.git_.Top2.FroAddress(folder), name, git);

		}

	}
}
