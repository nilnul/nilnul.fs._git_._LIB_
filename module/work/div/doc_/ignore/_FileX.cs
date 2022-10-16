using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.file_.git_.ignore.create
{
	static public class _ForceX
	{
		static public void Force(nilnul.fs.address_.SpearI targetAddress)
		{
			System.IO.File.WriteAllText(
				targetAddress.ToString(), 

				nilnul.fs.file_.git_.ignore.
			);
		}

		static public void Force(string targetAddress, string blob)
		{
			Force( new nilnul.fs.address_.Spear(targetAddress),blob );
		}





		static public void Create(string targetAddress)
		{
			nilnul.obj.vow_.False.Vow(System.IO.File.Exists(targetAddress));
			Force(targetAddress);
		}



		static public bool Ensure(string targetAddress)
		{
			if (!System.IO.File.Exists(targetAddress))
			{
				Force(targetAddress);
				return true;
			}
			return false;

		}

		public static bool Ensure(nilnul.fs.address_.SpearI element)
		{
			if (!System.IO.File.Exists(element.ToString()))
			{
				Force(element);
				return true;
			}
			return false;

		}
	}
}