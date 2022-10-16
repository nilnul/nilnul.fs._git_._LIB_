using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_.repo_.embeded
{
	/// <summary>
	/// the rt of the module
	/// </summary>
	public class _ModuleRtX
	{
		[Obsolete(nameof(_Shield_assumeRepoEmbededAddress))]
		static public nilnul.fs.address_.ShieldI _Shield_ofAddress(string _embededRepo) {
			return nilnul.fs.address_.shield._SupsX.Sups_ofAddress(_embededRepo).First(
				x => nilnul.fs.folder.be_.git_.Work.Singleton.be(x)
			);
		}

		static public nilnul.fs.address_.ShieldI _Shield_assumeRepoEmbededAddress(string _embededRepo) {
			return nilnul.fs.address_.shield._SupsX.Sups_ofAddress(_embededRepo).First(
				x => nilnul.fs.folder.be_.git_.Work.Singleton.be(x)
			);
		}



		static public nilnul.fs.address_.ShieldI _Shield_assumeRepoEmbededAddress_byRepoTop(string _embededRepo) {
			return
				nilnul.fs.address_.shield.op_.unary_._ParentX._Op(

				nilnul.fs.folder_.giT_.repo.top_.byRevParse_._AbsX.Shield_assumeRepoAddress(_embededRepo)
			);

			
		}



	}
}
