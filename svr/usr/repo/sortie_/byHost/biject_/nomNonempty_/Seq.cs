using nilnul.txt_.vered_._id;
using nilnul.txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.nom1dwelt_
{


	/// <summary>
	/// map to a started str of noms like:
	///		nilnul-pub-github1
	/// </summary>
	///
	[Serializable]
	[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	public class Seq
		:
		IEnumerable<
			(nilnul.fs.git.svr.client.RepoI svc
			, nilnul.txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.Started nom
		)
		>
	{
		private ByHost _svcs;

		public ByHost svcs
		{
			get { return _svcs; }
			set { _svcs = value; }
		}

		private nilnul.txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.started.sortie_.Caseless _noms;

		public nilnul.txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.started.sortie_.Caseless noms
		{
			get { return _noms; }
			set { _noms = value; }
		}

		public Seq(
			ByHost svcs
			,
			nilnul.txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.started.sortie_.Caseless noms
		)
		{
			this._svcs = svcs;
			this._noms = noms;

			nilnul.num.co.be_.eq.Vow.Singleton.vow_assumeNums(svcs.ee.Count(), noms.ee.Count());
		}
		public Seq():this(
			new ByHost()
			,
			new txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.started.sortie_.Caseless()
		)
		{

		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="byHost"></param>
		/// <param name="enumerable">
		/// for each memeber, the prefix shall not be prepended.
		/// eg:
		///		for "github", leave it as it is: "github"
		///		donnot prepend it with "nilnul-pub" to be "nilnul-pub-github"
		///	eg:
		///		for github/nilnul, leave it as [github,nilnul]
		/// </param>
		public Seq(ByHost byHost, IEnumerable<IEnumerable<string>> enumerable)
:this(
				 byHost
				 ,
				 new txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.started.sortie_.Caseless(
					enumerable.Select(
						n=>
						new txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.Started(
							n
						)

					)
				)
		)
		{
		}

		public Seq(IEnumerable<( RepoI, IEnumerable< string> Text)> enumerable):this(
			new ByHost(enumerable.Select(x=>x.Item1))
			,
			new txt_.vered_._id.nom_.ascii_.dwelt_.nonnumLed.str_.seq_.started.sortie_.Caseless(
				enumerable.Select(
					y=>  new Started(  y.Item2)
				)
			)
		)
		{
		}
		public Seq(IEnumerable<( RepoI,  string[] Text)> enumerable):this(
			enumerable.Select(t=>(t.Item1,(IEnumerable< string>) t.Text))
		)
		{
		}


		public IEnumerator<(RepoI, Started)> GetEnumerator()
		{
			return svcs.ee.Zip(noms.ee, (a, b) => (a, b)).GetEnumerator();

		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
