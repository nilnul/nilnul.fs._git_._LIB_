using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vereds
{
	static public class _VwX
	{
		public static IEnumerable<nilnul.txt_.Vered> Seq(
			nilnul.fs.folder_.git_.Top folder, 
			nilnul.txt_._vered_.Name name, 
			nilnul.win.prog_.Git git =null
		)
		{
			return 
				remotes._VwX.Seq(folder,git).Select(x=>  nilnul.txt_.Vered.Parse(x) )
				;
			

		}
		public static IEnumerable<nilnul.txt_.Vered> Seq(nilnul.fs.folder_.git_.Top folder, string name, nilnul.win.prog_.Git git =null)
		{
			return Seq(folder, new nilnul.txt_._vered_.Name(name),git);

		}


		public static IEnumerable<nilnul.txt_.Vered> Seq( nilnul.fs.FolderI folder, string name, nilnul.win.prog_.Git git =null)
		{
			return Seq( new nilnul.fs.folder_.git_.Top(folder) ,name, git);

		}
		public static IEnumerable<nilnul.txt_.Vered> Seq_ofAddress(
			string folder
			, string name
			, nilnul.win.prog_.Git git =null
		)
		{
			return Seq(  nilnul.fs.Folder.FroAddress(folder) ,name, git);

		}



		
	}
}
