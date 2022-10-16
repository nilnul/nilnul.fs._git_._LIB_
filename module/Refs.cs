using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	public class Refs
	{



		/// <summary>
		/// The output is in the format: {SHA-1 ID} {space} {reference name}.
		///$ git show-ref --head --dereference
		///
		///-d 
		///--dereference
		///Dereference tags into object IDs as well.They will be shown with "^{}" appended.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <returns></returns>
		static public string _ShowHeadDeference(nilnul.win.prog_.Git git, string _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module
				,
				"show-ref --head --dereference"
				,git
			);
		}

		/// <summary>
		/// --head
		/// Show the HEAD reference, even if it would normally be filtered out.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <returns></returns>
		static public string _ShowHead(nilnul.win.prog_.Git git, string _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module
				,
				"show-ref --head"
			);
		}





	}
}
