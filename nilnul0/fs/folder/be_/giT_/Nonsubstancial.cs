using System.Collections.Generic;
using System.Linq;
using nilnul.fs._address.dir;

namespace nilnul.fs.folder.be_.git_
{
	/// <summary>
	/// empty or (only .git ). no work.
	/// </summary>
	public class Nonsubstancial : nilnul.fs.folder.BeI
	{

		public static bool _DirEmptyOrGit(nilnul.fs.FolderI folder)
		{
			var dirs = nilnul.fs.folder._DirsX.Dirs(folder).Take(2).ToArray(); ;
			switch (dirs.Length)
			{
				case 0:
					return true;
				case 1:
					if (
						nilnul.fs._address.dir.EqX.Eq(
							nilnul.fs._address.dir.Eq.Singleton,

							dirs.First().denote.en, nilnul.fs.git.module._RepoX.DENOTE
						)
					)
					{
						return true;
					}
					return false;
				default:
					return false;
					break;
			}

		}
		public static bool _DocEmptyOrIgnore(nilnul.fs.FolderI folder)
		{
			var docs = nilnul.fs.folder._DirsX.Dirs(folder).Take(2).ToArray(); ;
			switch (docs.Length)
			{
				case 0:
					return true;
				case 1:
					if (
						nilnul.fs._address.doc.EqX.Eq(
							nilnul.fs._address.doc.Eq.Singleton,

							docs.First().denote.en, nilnul.fs.git.module._ignore_.div._DocX.NAME
						)
					)
					{
						return true;
					}
					return false;
				default:
					return false;
					break;
			}

		}


		public bool be(nilnul.fs.FolderI obj)
		{
			
			return _DirEmptyOrGit(obj) && _DocEmptyOrIgnore(obj);
		}


		static public Nonsubstancial Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonsubstancial>.Instance;
			}
		}


	}
}
