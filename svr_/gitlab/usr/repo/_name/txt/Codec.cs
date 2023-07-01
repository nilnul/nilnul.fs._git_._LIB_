using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.repo._name
{




	// _abc -> 0_abc   ;
	// 0_abc -> 00_abc ,
	// or 0_abc -> 10_abc

	class MyClass
	{
		public static void MethodName()
		{


			var head = Regex.Replace(
						intendedName
						,
						"^[-_.0]"
						,
						@"0$1"
					);  // _abc -> 0_abc   ;  0_abc -> 00_abc 
			var mid = Regex.Replace(
				head
				,
				"([-_.])(0*)([-_.])"
				,
				"$10$2$3"
			);  // abc_.   -> abc_0.   ; abc_0.  -> abc_00.

			var last = Regex.Replace(
				mid
				,
				"[-_.0]$"
				,
				"$10"
			);

			return new Name(
				last

			);

		}


	}

	
}
