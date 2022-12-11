using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git.nulable
{
	public class Fallback
	{
		static public nilnul.NotNull2<nilnul.win.prog_.Git> NotNul(nilnul.win.prog_.Git git = null)
		{
			return git ?? nilnul.win.prog_.Git.StaticInstance;
		}
	}
}
