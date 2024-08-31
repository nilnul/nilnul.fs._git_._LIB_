using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo._setting
{

	/// <summary>
	/// the description blob in the ".git/" dir;
	/// </summary>
	/// <remarks>
	/// The .git/description file is used only by some applications like Gitweb;
	/// nilnul uses this for repo name;
	///
	/// note: git describe is about a blob, not displaying this;
	/// 
	/// </remarks>
	static public class _DescriptionX
	{

		/// <summary>
		/// the <see cref="nilnul.fs._address._route.division_._div._dir.IDnt"/> of the description file;
		/// </summary>
		const string DNT = "description";

		/// <summary>
		/// 	The content of this file is also used by gitolite with the "desc -ld" command.
		/// </summary>
		///<remarks>
		///read the clob of the repo;
		/// </remarks>
		static public string? Description0nul(string depo, nilnul.os.prog_.Git? git = null)
		{

			var repoDir = fs.git.module.repo.path._VwX.Path_assumeWorktop(depo, git);

			var spear4descript = System.IO.Path.Combine(
				depo, repoDir, DNT
			);

			if (nilnul.fs.address_.spear.be_._FileX._Be(spear4descript))
			{
				return System.IO.File.ReadAllText(spear4descript);

			}
			return null;

		}
		static public string[] DescriptionAsLines0nul(string depo, nilnul.os.prog_.Git? git = null)
		{

			var repoDir = fs.git.module.repo.path._VwX.Path_assumeWorktop(depo, git);

			var spear4descript = System.IO.Path.Combine(
				depo, repoDir, DNT
			);

			if (nilnul.fs.address_.spear.be_._FileX._Be(spear4descript))
			{
				return System.IO.File.ReadAllLines(spear4descript);

			}
			return null;

		}

	}
}
