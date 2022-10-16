using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.Properties
{
	public class RscX
	{
		/// <summary>
		/// this rsc entr is what we use.
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<string> DotNetIgnoreLines()
		{
			return nilnul.txts.fro_.txt_.split_._LineX.Line(Resources.dotNetIgnore);


			//return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(Resources.dotNetIgnore).Select(
			//	x => nilnul.txt.op_.unary_.TrimStart.Instanse_.TrimWhite.op(x)
			//).Where(
			//	line => !line.StartsWith("#")
			//);

		}

		public static IEnumerable<string> NilnulIgnoreLines()
		{
			return nilnul.txts.fro_.txt_.split_._LineX.Line(Resources.nilnulIgnore);


			//return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(Resources.dotNetIgnore).Select(
			//	x => nilnul.txt.op_.unary_.TrimStart.Instanse_.TrimWhite.op(x)
			//).Where(
			//	line => !line.StartsWith("#")
			//);

		}

		public static string NilnulIgnore
		{
			get { 
			return (Resources.nilnulIgnore);
				 }

			//return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(Resources.dotNetIgnore).Select(
			//	x => nilnul.txt.op_.unary_.TrimStart.Instanse_.TrimWhite.op(x)
			//).Where(
			//	line => !line.StartsWith("#")
			//);

		}


	}
}
