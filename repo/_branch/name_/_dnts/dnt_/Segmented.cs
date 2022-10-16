using nilnul.obj.str_;
using nilnul.txt_.vered_.veR_.decs_;
//using nilnul.txt_.vered_.id_.ascii_;
using nilnul.txt_.vered_.veR_.decs_.underlined_.noM_.id_.ascii_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._branch.name_._dnts.dnt_
{
	/// <summary>
	/// hyphen "-" separated segs. each seg is vered, and can contain "_".
	/// eg:
	///		pub
	///		pub-pakPublished
	///		pub1-pakPublished
	///		pub1-pakPublished_internal
	///		pub1-pakPublished_internal1
	///		pub1-pakPublished_internal1_2
	///		pub1-pakPublished_internal1__1_2r
	///	where each seg can be vered.
	///	"_" cannot be taken as a sep anymore, as it can be used in ver or nom.
	/// </summary>
	/// 
	public class Segmented
		:
		nilnul.obj.str_.Started5<
			nilnul.txt_.vered_.veR_.decs_.underlined_.noM_.id_.ascii_.NomNonempty//might be led by num
																				 //,
																				 //IEnumerable<nilnul.txt_.vered_.id_.ascii_.NomNonempty>
		>
	{

		public const char SEP = '-';
		public Segmented(IEnumerable<NomNonempty> seq) : base(seq)
		{
		}

		public Segmented(NomNonempty head, SeqI3<NomNonempty> tail) : base(head, tail)
		{
		}

		public Segmented(NomNonempty head, IEnumerable<NomNonempty> tail) : base(head, tail)
		{
		}

		public Segmented(IEnumerable<Underlined> x) : this(
			x.Select(
				y => new NomNonempty(new txt_.vered_._id.nom_.ascii_.Dwelt(y.nom), y.ver)
			)
		)
		{
		}

		public override string ToString()
		{
			return string.Join("-", this);
		}

		static public Segmented Parse(string s)
		{
			var arr = s.Split('-');

			return new Segmented(
				arr.Select(n => NomNonempty.Parse(n))
			);
		}
		static public Segmented TryParse(string s)
		{
			try
			{
				return Parse(s);
			}
			catch (Exception)
			{
				return null;
			}
		}


		/// <summary>
		/// eg:
		///		pub_feature_1_2-abc335-d
		/// </summary>
		/// <returns></returns>
		public bool isPub()
		{
			var headAsTxt = this.head.nom.ee;
			return headAsTxt == "pub";

		}
	}
}
