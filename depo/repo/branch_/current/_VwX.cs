namespace nilnul.fs.git.depo.repo.branch_.current
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// by branch --show-current
	/// </remarks>
	/// works for empty branch, or detached mode.
	static public class _VwX
	{

		// in detached mode: this returns:
		/// cod:0; msg: ""
		///

		static public string _Nulable_0depo(string module, nilnul.win.prog_.Git git = null)
		{
			var r= nilnul.win.prog_.git.run.result.msg._TrimmedX._Txt_0address_1argument(module, "branch --show-current", git);
			if (string.IsNullOrEmpty(r))
			{
				return null;
			}
			return r;
		}
		static public string Nulable(string module, nilnul.win.prog_.Git git = null)
		{
			var r= nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(module, "branch --show-current", git);
			if (string.IsNullOrEmpty(r))
			{
				return null;
			}
			return r;
		}

	}
}
