using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module._work_.div.doc_.ignore._patch
{
	public class _RscX
	{
		static public IEnumerable<string> Seq_ofBlob(string blob)
		{
			return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(blob).Select(
				x => nilnul.txt.op_.unary_.TrimStart.Instanse_.TrimWhite.op(x)
			).Where(
				line => !line.StartsWith("#")
			);
		}

		static public IEnumerable<string> Seq_ofNilnul() {
			return Seq_ofBlob(
				nilnul.fs.git.Properties.RscX.NilnulIgnore

				//nilnul.fs.git.Properties.Resources.nilnulIgnore
			);
		}

		static public IEnumerable<string> Seq_ofNilnulWithWin() {
			return Seq_ofNilnul(
			).Concat(
				Seq_ofBlob(Properties.Resources.ignore4windows)
			);
		}


	}
}
