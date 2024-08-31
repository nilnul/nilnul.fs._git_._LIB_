using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module.ini
{
	[Obsolete()]
	static public class _EnsureX
	{
		static public void Void(nilnul.fs.Folder folder)
		{
			if (!nilnul.fs.folder.be_.GitTop.Singleton.be(folder))
			{
				nilnul.fs.folder.git_._IniX.Ini(folder);
			}
		}
	}
}
