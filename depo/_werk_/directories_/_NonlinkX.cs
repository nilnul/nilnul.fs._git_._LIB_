using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.directories_
{
	/// supersede: <see cref="nilnul.fs.folder_.giT_.work_.top.directories_.nonlink_._NontopX"/>
	/// <summary>
	/// the depo might be link; but the directory is not link at any level.
	/// </summary>
	static public class _NonlinkX
	{

		static public IEnumerable<string> Addresses_ofAddress(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var child in nilnul.fs.git.module._work_.dirs_._UnLinkX1._Addresses_addressAssumeModule(module))
			{
				foreach (var item in directory_.nonlink.divs_._OmnihardX.Addresses_ofAddress(child))
				{
					yield return item;
				}
			}
		}
	}
}