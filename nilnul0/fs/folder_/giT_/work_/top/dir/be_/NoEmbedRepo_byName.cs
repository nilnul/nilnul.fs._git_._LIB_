using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.dir.be_
{
	static public class _NoEmbedRepoS_byNameX
	{
		public static bool _Be_assumeDirIsWorkbaseChild( DirI dir)
		{
			return !nilnul.fs._address._dst.denote.Eq.Singleton.eq(
				dir.denote
				,
				".git"
			);

		}

		public static bool _Be_assumeWorkbase(
			nilnul.fs.folder_.ParentDir _top
			,
		nilnul.win.prog_.Git git = null
			)
		{

			return _Be_assumeDirIsWorkbaseChild(
				_top.en.child
				
			);

		}
		public static bool _Be_assumeWorkbase(

		nilnul.fs.address_.ShieldI _topAndDir
			,
		nilnul.win.prog_.Git git = null
	)
		{
			return _Be_assumeWorkbase(  nilnul.fs.folder_.ParentDir.Ov(_topAndDir), git);
		}

	}

}
