using System;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// including not only:
	/// the "config" in the ".git" folder;
	/// but also:
	///		the ".gitconfig" file;
	/// </summary>
	/// <remarks>
	/// <see cref="repo.ICfg"/> shall be used, as <see cref="module.IRepo"/>, per nilnulInfoGrow dev model, includes the info of <see cref="IModule"/>; that is, the cfg is not only about module, but also about <see cref="module.IRepo"/>
	/// </remarks>
	/// <seealso cref="module._ignore.Pattern"/>
	/// <see cref="module._setting.IConfig"/>
	[Obsolete(nameof(repo.ICfg))]
	 interface ICfg
	{
	}

}
