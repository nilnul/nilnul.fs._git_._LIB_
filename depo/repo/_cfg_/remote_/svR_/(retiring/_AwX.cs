using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.wellknown_
{
	[Obsolete()]
	static public class _AwX
	{


		static public _remote.Name GetNewestKeyAsName()
		{
			return new _remote.Name(GetNewestKey());
		}



		static public string GetNewestKey()
		{
			return GetKeys().Last();
		}


		static public IEnumerable<string> GetKeys()
		{
			return nilnul.fs.git.Properties.Settings.Default.moduleRemoteKeysAw.Cast<string>();
		}
	}


}
