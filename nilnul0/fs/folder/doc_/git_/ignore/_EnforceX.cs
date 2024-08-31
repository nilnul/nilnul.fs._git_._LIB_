using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder.doc_.git_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.folder.doc_.giT_.ignore
{
	static public class _EnforceX
	{
		public static void _Enforce_0folder(string element, string blob)
		{
			 nilnul.fs.file_.git_.ignore._EnforceX._Vod_0spear(
				_IgnoreX._Address_0folder(element),blob
			);
		}
		public static void Enforce(nilnul.fs.FolderI element, string blob)
		{
			 nilnul.fs.file_.git_.ignore._EnforceX.Make(
				_IgnoreX.Spear(element),blob
			);
		}


		public static void Enforce(nilnul.fs.address_.ShieldI element, string blob)
		{
			 Enforce(new nilnul.fs.Folder(element),blob);

		}
		static public void Enforce(string targetAddress,string blob)
		{
			 Enforce( nilnul.fs.address_.Shield.FroAddress(targetAddress),blob);

		}
		public static void _Enforce_0folder(string element, IEnumerable<string> blob)
		{
			nilnul.fs.file_.git_.ignore._EnforceX._Vod_0spear(
				_IgnoreX._Address_0folder(element)
				,
				blob
			);
		}


		public static void Enforce(nilnul.fs.FolderI element, IEnumerable<string> blob)
		{
			nilnul.fs.file_.git_.ignore._EnforceX.Make(
				_IgnoreX.Spear(element),blob
			);
		}


		public static void Enforce(nilnul.fs.address_.ShieldI element, IEnumerable<string> blob)
		{
			 Enforce(new nilnul.fs.Folder(element),blob);

		}

		static public void Enforce(string targetAddress,IEnumerable<string> blob)
		{
			Enforce( nilnul.fs.address_.Shield.FroAddress(targetAddress),blob);

		}
	}
}