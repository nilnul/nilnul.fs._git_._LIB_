using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git
{
	public class Boxed : nilnul.obj.Box<nilnul.win.prog_.Git>
	{
		public Boxed(Git val) : base(val??nilnul.win.prog_.Git.StaticInstance)
		{
		}

		public Boxed():this( nilnul.win.prog_.Git.StaticInstance)
		{

		}
	}
}
