using System;
using System.Diagnostics;

namespace nilnul.fs.git.depo.pier
{
	static public class _BakX
	{
		public static (string head, string[] pierTags) _Vod_0depo_1bak(string depo, string bakBatch, os.prog_.Git git = null)
		{

			string _oldHead = nilnul.fs.git.module.repo.current._VwX._Txt_0depo(depo);
			return (
				_oldHead
				,
				_Vod_0depo_1bak(
					depo
					, _oldHead
					, bakBatch
					, git
				)
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="bakBatch"></param>
		/// <param name="git"></param>
		/// <returns>
		///	for pier Tags:
		///		empty for dry depo;
		///		if the depo is wet:
		///			pierTags: pierAhead, optionally pierOrhaned
		/// </returns>
		static public  string[]  _Vod_0depo_1bak(
			string depo
			,
			string _oldHead
			,
			string bakBatch
			,
			nilnul.os.prog_.Git git = null
		)
		{

			// check whether the pier is clean

			if (nilnul.fs.git.depo.pier.be_.Dry._Be_0depo(depo))
			{
				// it's clean, do nothing;
				// we cannot simply tag here, as the head might be unborn;
				return  [] ;
			}
			else
			{
				nilnul.app.trace._OfXmlX.TraceError(
					new System.Xml.Linq.XElement(
						"Err",	$"{depo}'s stage is not commited; for bak, it's better dried out."
					)
				);
				var t= pier_.wet._BakX._Tags_0depo8dirty_1head_2bak(depo,_oldHead,bakBatch,git);

				return  t;



			}


		}

	}
}
