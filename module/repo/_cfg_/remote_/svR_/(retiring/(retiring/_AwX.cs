using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_
{

	static public class _AwX
	{


		public static string NAME_TXT = nilnul.fs.git.Properties.Settings.Default.moduleRemoteKeysAw.Cast<string>().Last();

		static public nilnul.fs.git.module._cfg_._remote.Name Name = new _remote.Name(NAME_TXT);


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
