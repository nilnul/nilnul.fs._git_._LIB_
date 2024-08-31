using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.file_.git_.ignore.make
{
	[Obsolete(nameof(nilnul.fs.file_.giT_.ignore._EstablishX))]
	static public class _EnsureX
	{



		/// <summary>
		/// created
		/// </summary>
		/// <param name="element"></param>
		/// <param name="blob"></param>
		/// <returns></returns>
		public static bool Ensure(nilnul.fs.address_.SpearI element, string blob)
		{
			if (!System.IO.File.Exists(element.ToString()))
			{
				_EnforceX.Make(element,blob);
				return true;
			}
			return false;

		}

		/// <summary>
		/// created
		/// </summary>
		/// <param name="element"></param>
		/// <param name="blob"></param>
		/// <returns></returns>
		public static bool Ensure(nilnul.fs.address_.SpearI element, IEnumerable<string> blob)
		{
			if (!System.IO.File.Exists(element.ToString()))
			{
				_EnforceX.Make(element,blob);
				return true;
			}
			return false;

		}


		static public bool Ensure(string targetAddress,string blob)
		{
			return Ensure(new nilnul.fs.address_.Spear(targetAddress),blob);

		}
		static public bool Ensure(string targetAddress,IEnumerable<string> blob)
		{
			return Ensure(new nilnul.fs.address_.Spear(targetAddress),blob);

		}

	}
}