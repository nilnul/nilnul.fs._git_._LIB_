using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.file_.git_.ignore;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.file_.giT_.ignore
{
	static public class _EstablishX
	{

		public static bool _Establish_0spear_1blob(string element, string blob)
		{
			if (!System.IO.File.Exists(element))
			{
				_EnforceX._Vod_0spear(element,blob);
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
		public static bool Establish_1blob(nilnul.fs.address_.SpearI element, string blob)
		{
			return _Establish_0spear_1blob(element.ToString(),blob);
		}

		static public bool Establish_1blob(string targetAddress,string blob)
		{
			return Establish_1blob(new nilnul.fs.address_.Spear(targetAddress),blob);

		}

		/// <summary>
		/// created
		/// </summary>
		/// <param name="element"></param>
		/// <param name="blob"></param>
		/// <returns></returns>
		public static bool _Establish_0spear_1lines(string element, IEnumerable<string> blob)
		{
			if (!System.IO.File.Exists(element))
			{
				_EnforceX._Vod_0spear(element,blob);
				return true;
			}
			return false;
		}
		public static bool Establish_1lines(nilnul.fs.address_.SpearI element, IEnumerable<string> blob)
		{
			return _Establish_0spear_1lines(element.ToString(),blob);

		}


		static public bool Establish_1lines(string targetAddress,IEnumerable<string> blob)
		{
			return Establish_1lines(new nilnul.fs.address_.Spear(targetAddress),blob);

		}

	}
}