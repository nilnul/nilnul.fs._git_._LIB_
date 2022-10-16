using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg
{
	/// <summary>
	/// path for .git/config
	/// </summary>
	public class _FileX
	{
		static public nilnul.fs.File GetFile(nilnul.fs.Folder gitTop) {

			return nilnul.fs.folder._DocumentX.CreateFroContainerDocument(gitTop, ".git/config");

		}
	}
}
