using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_
{
	static public class _NewestX
	{
		public static string Txt(
			nilnul.fs.git.ModuleI folder,
			nilnul.txt_._vered_.Name name,
			nilnul.win.prog_.Git git = null
		)
		{
			
			return
				nilnul.txt.str_.started.aggregate_._VerLatestX._Latest(

					remote_.vered_.name._VwX.Exe(folder,name,git) 
				)
			;

		}

		public static string Txt(
			nilnul.fs.git.ModuleI folder,
			string name,
			nilnul.win.prog_.Git git = null
		)
		{
			
			return
				Txt(folder, new txt_._vered_.Name( name),git)
			;

		}


		public static string Txt(
			nilnul.fs.git.Module folder,
			nilnul.txt_._vered_.Name name,
			nilnul.win.prog_.Git git = null
		)
		{
			return
				Txt(folder as nilnul.fs.git.ModuleI, name,git)
			;

		}

		public static string Txt(
			nilnul.fs.folder_.git_.Top folder,
			nilnul.txt_._vered_.Name name,
			nilnul.win.prog_.Git git = null
		)
		{
			return
				Txt( new nilnul.fs.git.Module(folder),name,git)
			;

		}


		public static string Txt(
			nilnul.fs.folder_.git_.Top folder,
			string name,
			nilnul.win.prog_.Git git = null
		)
		{
			return
				Txt( folder,new txt_._vered_.Name( name),git)
			;

		}

		


		public static string Txt(nilnul.fs.FolderI folder, string name, nilnul.win.prog_.Git git = null)
		{
			return Txt(new nilnul.fs.folder_.git_.Top(folder), name, git);

		}
		public static string Txt(string folder, string name, nilnul.win.prog_.Git git = null)
		{
			return Txt( nilnul.fs.folder_.git_.Top.FroAddress(folder), name, git);

		}

	}
}
