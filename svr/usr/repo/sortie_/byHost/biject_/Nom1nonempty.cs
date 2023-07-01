using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_
{


	/// <summary>
	/// 
	/// </summary>
	public class Nom1nonempty
	{
		private ByHost _svcs;

		public ByHost svcs
		{
			get { return _svcs; }
			set { _svcs = value; }
		}

		private nilnul.txt_.vered_._id.nom_.dwelt_.nonnumLed.sortie_.Caseless _noms;

		public nilnul.txt_.vered_._id.nom_.dwelt_.nonnumLed.sortie_.Caseless noms
		{
			get { return _noms; }
			set { _noms = value; }
		}

		public Nom1nonempty(
			ByHost svcs
						,
			nilnul.txt_.vered_._id.nom_.dwelt_.nonnumLed.sortie_.Caseless noms
		)
		{
			this._svcs = svcs;
			this._noms = noms;

			nilnul.num.co.be_.ge.Vow.Singleton.vow_assumeNums(svcs.ee.Count(), noms.ee.Count());
		}






	}
}
