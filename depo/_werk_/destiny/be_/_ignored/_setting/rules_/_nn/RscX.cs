using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.destiny.be_._ignored._setting.rules_._nn
{
	static public class _RscX
	{
		static public IEnumerable<string> NilnulOnly()
		{
			return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(Resource1.nilnulIgnore).Select(
				x => nilnul.txt.op_.unary_.TrimStart.Instanse_.TrimWhite.op(x)
			).Where(
				line => !line.StartsWith("#")
			);
		}

		static public IEnumerable<string> RawLines()
		{
			return nilnul.txts.fro_.txt_.split_._LineX.Line(Resource1.nilnulIgnore);
		}

		/// <summary>
		/// in case we need this to be concated to another
		/// </summary>
		/// <returns></returns>
		static public string RawTxt()
		{
			return Resource1.nilnulIgnore;
		}

	}
}
