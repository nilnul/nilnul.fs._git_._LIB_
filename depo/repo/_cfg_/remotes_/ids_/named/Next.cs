using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remotes_.ids_.named
{
	[Obsolete( nameof(remote_.nameInId_._NextX))]
	static public class _NextX
	{
		static public nilnul.txt_.NameVer NameVer(
			nilnul.fs.folder_.git_.Top folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.prog_.Git git = null) {

			var latest = _NewestOrNulX.Exe(folder, name, git);
			if (latest==null)
			{
				return new txt_.NameVer(name);
			}
			return nilnul.txt_.nameVer.convert_._NextX.Next(latest);

		}
		static public string Txt(
			nilnul.fs.folder_.git_.Top folder,
			nilnul.txt_._nameVer_.Name name,
			nilnul.win.prog_.Git git = null) {

			
			return NameVer(folder, name,git).ToString();

		}


	}
}
