using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg
{
	/// <summary>
	/// including:
	///		<see cref="nameof(fs.git.module.repo._cfg.IExclude)"/>
	///		and <see cref="nameof(fs.git.module.work.div.doc_.Ignore)"/>
	/// </summary>
	public interface IExclude0ignore
	{
	}
	static public class _Exclude0ignoreX
	{

		static public IEnumerable<string> Seq_ofBlob(string blob)
		{
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(blob).Where(
				line => !line.StartsWith("#")
			);
		}
	}
}
