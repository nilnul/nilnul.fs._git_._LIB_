using nilnul.obj;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.giT_.repo_.bare_.top
{
	/// <summary>
	/// not a repo_.bare_.top. may be a repo_.bare_.Nontop, or repo_.Nonbare, or Nonrepo
	/// </summary>
	public class Anto : nilnul.fs.folder.be.Anto1
	{
		public Anto(Git git) : base( nilnul.fs.folder.be_.giT_.repo_.bare_.Top.Ov(git) )
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
