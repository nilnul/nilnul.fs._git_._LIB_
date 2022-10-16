using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.git.repo.be_
{
	static public class _BareX
	{
		[Obsolete(nameof(_Be_assumeRepoAddress))]
		static public bool _Be_ofAddress(
			string address /* in the .git directory*/
			,
			nilnul.win.prog_.Git git=null
		) {
			return nilnul.bit._ParseX.Exe(  nilnul.txt.convert_.trim_.White.Singleton.op( nilnul.win.prog_.git.run.result._MsgX.OfAddress(
				address
				,
				"rev-parse --is-bare-repository"		// error if plain, false 
				,
				git
			)));
		}
		static public bool _Be_assumeRepoAddress(
			string address /* in the .git directory*/
			,
			nilnul.win.prog_.Git git=null
		) {
			return nilnul.bit._ParseX.Exe(  nilnul.txt.convert_.trim_.White.Singleton.op( nilnul.win.prog_.git.run.result._MsgX.OfAddress(
				address
				,
				"rev-parse --is-bare-repository"		// error if plain, false 
				,
				git
			)));
		}

		[Obsolete(nameof(_Be_assumeRepo))]
		static public bool _Be(
			nilnul.fs.address_.ShieldI address /* in the .git directory*/
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Be_assumeRepoAddress(address.ToString(),git);
		}

		static public bool _Be_assumeRepo(
			nilnul.fs.address_.ShieldI address /* in the .git directory*/
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Be_assumeRepoAddress(address.ToString(),git);
		}

		[Obsolete(nameof(_Be_assumeRepo))]
		public static bool _Be(Exist address)
		{
			return _Be(address.en);
		}

		public static bool _Be_assumeRepo(Exist address)
		{
			return _Be_assumeRepo(address.en);
		}
		[Obsolete(nameof(_Be_assumeRepo))]
		public static bool _Be(FolderI folder_nonlink)
		{
			return _Be(folder_nonlink.address);
		}
		public static bool _Be_assumeRepo(FolderI folder_nonlink)
		{
			return _Be_assumeRepo(folder_nonlink.address);
		}


	}

	public class Bare :
		nilnul.obj.Box<nilnul.win.prog_.Git >
		,
		nilnul.fs.git.repo.BeI
	{

		/*git rev-parse --is-bare-repository 
It was introduced as early as commit 493c774, nilnul.win.prog_.Git 1.5.3 (Sept. 2007) and commit 7ae3df8 by Matthias Lederhofer (matled).
When the repository is bare print "true", otherwise "false".*/
		public bool be(RepoI obj)
		{
			return _BareX._Be_assumeRepoAddress(obj.folder.ToString());
		}
		public Bare():this( win.prog_.Git.StaticInstance)
		{

		}

		public Bare(win.prog_.Git val) : base(val)
		{
		}

		static public Bare Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Bare>.Instance;
			}
		}



	}
}
