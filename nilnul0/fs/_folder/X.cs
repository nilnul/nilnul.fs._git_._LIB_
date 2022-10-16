using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git._folder
{
	public static class X
	{

		static public void _Init(
		Git git,


		string _folder__none

	)
		{

			git.runCmd_throwErr(_folder__none, "init");




		}

		static public void _Init(

		string _folder__none

	)
		{

			_Init(nilnul.win.prog_.Git.StaticInstance, _folder__none);




		}


	}
}
