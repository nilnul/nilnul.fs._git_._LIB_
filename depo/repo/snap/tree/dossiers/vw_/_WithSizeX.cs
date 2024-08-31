using Microsoft.VisualStudio.Services.Common.CommandLine;

namespace nilnul.fs.git.depo.repo.snap.tree.dossiers.vw_
{
	static public class _WithSizeX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo">the address of the depo.</param>
		/// <param name="snap">
		/// the id of the snap. can be in shortened form;
		/// </param>
		/// <param name="git"></param>
		/// <returns>
		/// eg: 
		///100644 blob a778...b5  534045    2312212355/图片_202346.jpg
		///100644 blob b91d...05 4376140    2fca9014.mp4
		/// ,where the 4th number is the size of each entry;
		/// </returns>
		static public string _Msg_0depo_1snap(
			string depo, string snap, nilnul.os.prog_.Git git = default
		) {

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo, $"ls-tree -l -r {snap}", git
			);
		}
	}


}
