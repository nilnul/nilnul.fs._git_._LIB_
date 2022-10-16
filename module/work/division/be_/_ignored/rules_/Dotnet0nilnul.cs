using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.division.be_._ignored.rules_
{
	static public class _Dotnet0nilnulX
	{
		static public IEnumerable<string> NilnulOnly()
		{
			return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(nilnul.fs.git.module.work.div.doc_.ignore.patch_._nn._rules.Resource1.TextFile1).Select(
				x => nilnul.txt.op_.unary_.TrimStart.Instanse_.TrimWhite.op(x)
			).Where(
				line => !line.StartsWith("#")
			);
		}

		static public IEnumerable<string> MergeWithDotNetIgnore()
		{
			return nilnul.fs.git.Properties.RscX.DotNetIgnoreLines().Where(
				line => !line.StartsWith("#")
			).Concat(NilnulOnly());
		}


		static public string Txt() {
			return nilnul.fs.git.Properties.Resources.dotNetIgnore+"\n\r"+nilnul.fs.git.module.work.div.doc_.ignore.patch_._nn._rules.Resource1.TextFile1;
		}


		
	}
}
