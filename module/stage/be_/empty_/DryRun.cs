using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.be_.empty_
{
	/// <summary>
	/// nothing to commit
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class DryRun
	{
		static public bool Be(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{
			var result = nilnul.win.prog_.git.run._ResultX.Result(    //note: errCode is 1.
				gitTop, "commit --dry-run --short"
				,git
			);

			if (result.exitCode== 1)
			{
				if (
					nilnul.txt.be_.White.Singleton.be(result.err)
				){

					return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(
									result.msg
					).Count() == 0;

				}
				
			}

			if (result.exitCode == 0)
			{

				return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(
								result.msg
				).Count() == 0;
			}

			throw new nilnul.fs._git.ReportErrException(result.err);



		}

	}
}
