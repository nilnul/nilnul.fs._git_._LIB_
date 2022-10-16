using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.folder.doc_.git_.ignore.make
{
	static public class _EnsureX
	{
		public static bool Ensure(nilnul.fs.FolderI element, string blob)
		{
			return nilnul.fs.file_.git_.ignore.make._EnsureX.Ensure(
				_IgnoreX.Spear(element),blob
			);
		}
		public static bool Ensure(nilnul.fs.FolderI element, IEnumerable<string> blob)
		{
			return nilnul.fs.file_.git_.ignore.make._EnsureX.Ensure(
				_IgnoreX.Spear(element),blob
			);
		}
		public static bool Ensure(nilnul.fs.address_.ShieldI element, string blob)
		{
			return Ensure(new nilnul.fs.Folder(element),blob);

		}
		public static bool Ensure(nilnul.fs.address_.ShieldI element, IEnumerable<string> blob)
		{
			return Ensure(new nilnul.fs.Folder(element),blob);

		}

		static public bool Ensure(string targetAddress,string blob)
		{
			return Ensure( nilnul.fs.address_.Shield.FroAddress(targetAddress),blob);

		}
		static public bool Ensure(string targetAddress,IEnumerable<string> blob)
		{
			return Ensure( nilnul.fs.address_.Shield.FroAddress(targetAddress),blob);

		}
	}
}