using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git.nulable
{
	public class Fallback
	{
		static public nilnul.NotNull2<nilnul.os.prog_.Git> NotNul(nilnul.os.prog_.Git git = null)
		{
			return git ?? nilnul.os.prog_.Git.StaticInstance;
		}
		static public nilnul.NotNull2<nilnul.os.prog_.Git> NotNul()
		{
			return  nilnul.os.prog_.Git.StaticInstance;
		}


	}
}
