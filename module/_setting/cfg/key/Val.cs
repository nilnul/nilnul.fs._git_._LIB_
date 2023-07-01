using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.key
{
	static public class _ValX
	{
		

		public static string Txt(Folder folder,string name, Git git=null)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"config {name}", git);

			
		}

		public static string Txt(ModuleI module, string kEY, Git git)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module, $"config {kEY}", git);


		}
	}
}
