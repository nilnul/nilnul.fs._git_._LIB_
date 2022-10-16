using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git._module.work._ignore.div._doc.file
{
	/* extern alias obj;*/
	[Obsolete()]
	static public class _DotNetX
	{
		static public void Force(nilnul.fs.address_.SpearI targetAddress)
		{
			System.IO.File.WriteAllText(targetAddress.ToString(), git.Properties.Resources.dotNetIgnore);
		}

		static public void Force(string targetAddress)
		{
			Force( new nilnul.fs.address_.spear_.AddressVowen(targetAddress) );
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

		public static bool Ensure(SpearI element)
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