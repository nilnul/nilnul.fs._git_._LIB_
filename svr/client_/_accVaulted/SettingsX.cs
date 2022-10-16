using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_._accVaulted
{
	public class SettingsX
	{
		/// <summary>
		/// prefix for the key used to retrieve password stored in WinVault. Empty or including colon.
		/// </summary>
		static public string Prefix { get {
				var t = Settings1.Default.prefix;
				return string.IsNullOrWhiteSpace(t) ? "" : (t+":");
			}
		}
	}
}
