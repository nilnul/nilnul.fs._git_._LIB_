using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.git_.cfg_.safe_
{
	/// <summary>
	/// with "-bare"
	/// </summary>
	static public class _DirecotoryInGlobalX
	{
		static public void Vod(nilnul.fs.FolderI folder, nilnul.win.prog_.Git git = null)
		{
			nilnul.win.prog_.git._RunX._Vod(folder, $@"config --global --add safe.directory ""{folder.ToString().Replace('\\','/').TrimEnd('/')}""", git);
		}
		static public void Vod_ofAddress(string folder, nilnul.win.prog_.Git git = null)
		{
			Vod(nilnul.fs.Folder.FroAddress(folder), git);
		}

	}
}
