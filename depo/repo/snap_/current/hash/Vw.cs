using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap_.current.hash
{
	public class Vw
		:
		nilnul.os.prog_.git.run_.end.result._msg_.AssumeDepoI

	{
		/// <summary>
		/// if current is born.
		/// </summary>
		/// <param name="_depo"></param>
		/// <param name="git"></param>
		/// <returns>
		/// the hash only
		/// </returns>
		/// <exception cref="">
		/// fatal: Not a valid object name @ if current is not born
		/// </exception>
		public string _msg_0depo(string _depo, nilnul.os.prog_.Git git = null)
		{

			return nilnul.win.prog_.git.run.result._MsgX._Msg_0address(_depo, "show --format=%H", git).Trim();

		}


		static public Vw Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Vw>.Unison;
			}
		}

	}
}
