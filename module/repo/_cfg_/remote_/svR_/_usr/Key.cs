using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_._usr
{
	/// <summary>
	/// key of the remote settings in cfg
	/// </summary>
	static public class _KeyX
	{
		static public string Key(string svr, string usr) {
			return $"{svr}-{usr}";
		}
	}
}
