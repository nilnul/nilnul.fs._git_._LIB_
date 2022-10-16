using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_.work_;

namespace nilnul.fs.git.module.work.be_
{
	[Obsolete("use "+nameof(Empty)+" or "+ nameof(module.be_.AllDotLed) + "; as they are more unambiguous terms.")]
	public class Trivia :

		nilnul.fs.folder_.git_.work_.top.BeI,
		nilnul.fs.folder.BeI
		
	{
		public bool be(Top obj)
		{
			return _TriviaX.Be(obj);
		}
		public bool be(FolderI obj)
		{
			return be(
				new Top(obj)
			);
		}


		static public Trivia Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Trivia>.Instance;
			}
		}

	}
}
