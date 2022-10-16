using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.giT_.repo_.embed
{
	public class Anto :nilnul.fs.folder.be.Anto1
	{
		public Anto(nilnul.win.prog_.Git git=null):base( new NonBare(git) )
		{

		}

		public Anto() : this(null)
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
