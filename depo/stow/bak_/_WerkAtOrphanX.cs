using Microsoft.VisualStudio.Services.Common;
using nilnul.fs.file.be;
using nilnul.obj.lex_._byt.bind_.name_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace nilnul.fs.git.depo.stow.bak_
{
	/// we will reset the stage. to avoid loss of work, <see cref="pier._BakX"/> shall be done beforehand.
	/// 
	/// <summary>
	/// bak the werk separately as an orphan.
	/// </summary>
	/// <remarks>
	/// designed to be called from within <see cref="depo_.IWrought"/>
	/// </remarks>
	/// todo:
	///		,keep the moving branch to be on the last tag
	///		,name last tag as something similar to "-123end"

	static public class _WerkAtOrphanX
	{

		static public (string[] piers, List<string> werks) _Tags_0depo(
			string _depo
			,
			nilnul.os.prog_.Git git = null
		)
		{
			string timestamp = nilnul.time_.datetime.lex_.num_.YrInTwo.Singleton.phrase();

			var bakBatch = "bak" + timestamp;

			var head = nilnul.fs.git.module.repo.current._VwX._Txt_0depo(_depo);

			var pierTags = nilnul.fs.git.depo.pier._BakX._Vod_0depo_1bak(
				_depo
				, head
				,
				bakBatch
			);

			string _pierRef = pierTags.FirstOrDefault();

			try
			{
				var tags = nilnul.fs.git.depo.werk._BakX._Tags_0depo_1head_2bak_3pier0nul(
					_depo
					,
					head
					,
					bakBatch
					,
					_pierRef
				);

				return (
					pierTags, tags
				);

			}
			catch (Exception x)
			{

				/// todo: some restore
				///


				throw new Exception($"when bak werk of {_depo} with (head :{head}, bak:{bakBatch}, pierHenceTag:{_pierRef}):",x);
			}
		}
	}
}
