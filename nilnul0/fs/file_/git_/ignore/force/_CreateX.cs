using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.file_.git_.ignore.make
{
	static public class _CreateX
	{

		public static void Create(nilnul.fs.address_.SpearI element, string blob)
		{
			nilnul.obj.vow_.False.Vow(System.IO.File.Exists(element.ToString()));
			_EnforceX.Make(element,blob);
			

		}
		public static void Create(nilnul.fs.address_.SpearI element, IEnumerable<string> blob)
		{
			nilnul.obj.vow_.False.Vow(System.IO.File.Exists(element.ToString()));
			_EnforceX.Make(element,blob);
			

		}


		static public void Create(string targetAddress,string blob)
		{
			Create(
				new nilnul.fs.address_.Spear(targetAddress),blob
			);
		}

		static public void Create(string targetAddress,IEnumerable<string> blob)
		{
			Create(
				new nilnul.fs.address_.Spear(targetAddress),blob
			);
		}


	}
}