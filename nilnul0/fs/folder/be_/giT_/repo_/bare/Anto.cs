using nilnul.obj;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.giT_.repo_.bare
{
	public class Anto : nilnul.fs.folder.be.Anto1
	{
		public Anto(Git git) : base( nilnul.fs.folder.be_.giT_.repo_.Bare.Ov(git) )
		{
		}

		public Anto():this(null)
		{

		}

		static public Anto Ov(nilnul.win.prog_.Git git = null)
		{
			if (git is null)
			{
				return Singleton;
			}
			return new Anto(git);
		}

		static public Anto Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}

	}
}
