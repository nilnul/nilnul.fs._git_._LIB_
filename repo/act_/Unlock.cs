using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.act_
{
	static public class _UnlockX
	{

		public static void _Vod_assumeRepobase(FolderI en)
		{
			var currentTime = nilnul.time_.datetime._lex_.phrase_.yr_.decimalSubsecond_.seP_.Underscore.Singleton.phrase();

			var locked= nilnul.fs.folder._DocsX.Denotes(en).Where(
				 d=> be_._LockenX._Be_ofDoc(
					
						d
					
				)
			);

			locked.Each(
				l => {
					//apending the current time
					nilnul.fs.file._RenameX.Rename(
						new nilnul.fs.address_.spear_.ParentDoc(
							en.address.en
							,
							l
						)
						,
						l.ToString() + currentTime

					);
				}

			);
		}
	}
}
