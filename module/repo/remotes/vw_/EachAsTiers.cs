using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remotes.vw_
{
	static public class _EachAsTiersX
	{
		static public IEnumerable<string[]> _Strung_assumeModuleAddress(
				string module
			)
		{
			return nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq_ofAddress(
				module
			).Select(y => y.Split('-'));
		}
		static public IEnumerable<nilnul.txt_.Vered3[]> _VeredsEs_assumeModuleAddress(
			string module
		)
		{
			return _Strung_assumeModuleAddress(module).Select(
				x=>x.Select(
					z =>		nilnul.txt_.Vered3.Parse(z)
				).ToArray()
			);
		}
	}
}
