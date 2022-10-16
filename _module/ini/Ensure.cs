using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module.ini
{
	static public class _EnsureX1
	{
		static public void Void(nilnul.fs.FolderI folder, nilnul.win.prog_.Git git =null)
		{
			if (!nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(folder))
			{
				nilnul.fs.git._module._IniX1.Ini(folder,git);
			}
		}

		public static void OfFolderAddress(string top)
		{
			Void(nilnul.fs.Folder.FroAddress(top));
			//throw new NotImplementedException();
		}
	}
}
