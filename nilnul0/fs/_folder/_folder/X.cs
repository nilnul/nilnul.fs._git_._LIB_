using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._folder
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

			_Init(Git.StaticInstance, _folder__none);




		}


	}
}
