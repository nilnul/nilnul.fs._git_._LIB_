using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.newable.be_
{
	/// <summary>
	/// only:
	///		ignores
	///		.nilnulCfg
	/// </summary>
	///
	[Obsolete(nameof(Trivia))]
	public class OnlyIgnore : nilnul.fs.folder_.giT_.newable.BeI
		,
		nilnul.fs.folder.BeI
	{
		static public bool _Be(nilnul.fs.FolderI _newable)
		{
			return Trivia._Be(_newable);
			//return nilnul.fs.folder._DocumentsX.Documents(_newable)
			//	.All(
			//		d=> new nilnul.fs._address.doc.Set(nilnul.fs.git.module.work.div.doc_.Ignore._DOC__TXT
			//		/*,".nilnulCfg"*/
			//		).Contains(
						
			//			d.doc
			//		)
			//	)
			//;

		}

		public bool be(Newable obj)
		{
			return _Be(obj.en);

		}

		public bool be(FolderI obj)
		{
			return be(new Newable(obj));

		}

		static public OnlyIgnore Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<OnlyIgnore>.Instance;
			}
		}

	}
}
