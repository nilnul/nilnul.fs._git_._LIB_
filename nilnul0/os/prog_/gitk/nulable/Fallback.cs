using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.gitk.nulable
{
	public class Fallback
	{
		static public nilnul.NotNull2<nilnul.os.prog_.Gitk> NotNul(nilnul.os.prog_.Gitk git = null)
		{
			return git ?? nilnul.os.prog_.Gitk.StaticInstance;
		}
		static public nilnul.NotNull2<nilnul.os.prog_.Gitk> NotNul()
		{
			return  nilnul.os.prog_.Gitk.StaticInstance;
		}


	}
}
