using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.division.be_._ignored.rules_
{
	/// <summary>
	/// the dotnet part is about develop, and shall be deferred to nilnul.dev, as until then will we know what to be ignored.
	/// </summary>
	static public class _Dotnet0nilnulX
	{
		static public IEnumerable<string> NilnulOnly()
		{
			return nilnul.fs.git.depo._werk_.destiny.be_._ignored._setting.rules_._nn._RscX.NilnulOnly().Select(
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
			return nilnul.fs.git.Properties.Resources.dotNetIgnore+"\n\r"+nilnul.fs.git.depo._werk_.destiny.be_._ignored._setting.rules_._nn.Resource1.nilnulIgnore;
		}


		
	}
}
