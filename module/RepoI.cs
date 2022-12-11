using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	static public class _RepoX
	{
		public const string DENOTE = ".git";

		static public string DefaultAddress_worktopAssumeAddress(string module)
		{
			return System.IO.Path.Combine(module, ".git");
		}

		static public nilnul.fs.address_.ShieldI DefaultShield(nilnul.fs.git.ModuleI module)
		{
			return nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(module.top1.en.address.en, DENOTE);
		}

		static public nilnul.fs.Folder DefaultFolder(nilnul.fs.git.ModuleI module)
		{
			return nilnul.fs.folder._EnsureX.Folder(
				DefaultShield(module)
			);
		}

		static public nilnul.fs.Folder DefaultFolder(nilnul.fs.address_.ShieldI module)
		{
			return DefaultFolder(
				new nilnul.fs.git.Module(module)
			);
		}

		static public nilnul.fs.Folder DefaultFolder_assumeModule(nilnul.fs.FolderI module)
		{
			return DefaultFolder(
				new nilnul.fs.git.Module(module)
			);
		}

		static public nilnul.fs.Folder DefaultFolder_ofAddress(string module)
		{
			return DefaultFolder(
				nilnul.fs.address_.Shield.FroAddress(module)
			);
		}

		static public nilnul.fs.Folder EnsureDefaultFolder(nilnul.fs.git.ModuleI module)
		{
			return nilnul.fs.folder._EnsureX.Folder(
				DefaultShield(
					module
				)
			);
		}

		static public nilnul.fs.Folder EnsureDefaultFolder(nilnul.fs.address_.ShieldI module)
		{
			return EnsureDefaultFolder(
				new nilnul.fs.git.Module(module)
			);
		}

		static public nilnul.fs.Folder EnsureDefaultFolder_ofShield(string module)
		{
			return EnsureDefaultFolder(
				nilnul.fs.address_.Shield.Parse(module)
			);
		}

		static public nilnul.fs.Folder EnsureDefaultFolder_ofAddress(string module)
		{
			return EnsureDefaultFolder(
				nilnul.fs.address_.Shield.FroAddress(module)
			);
		}

	}

	/// <summary>
	/// given a module, its repo
	/// repo is what's within the ".git" dir that can be synchrozed with a remoe. those cannot be synchronized should be scoped within "DotGit"
	/// So this is primarily a namespace place holder for all the actions to sync with remote.
	/// as the namespace, this denotes all the actions the scope of which (maybe empty) is within the repo only (but may read others.)
	/// </summary>
	/// 
	/// <remarks>
	/// 
	/// repos is what's sunk/deposted/recorded/unsubjected2change
	/// for remote actions
	/// 
	///		vs: nilnul.fs.git.RepoI: an abstraction of all modules, be it bare or moduled
	///		vs: nilnul.fs.git._module_.RepoI: an abstraction of all moduled repos
	///		while this is a specific repo given a specific module
	/// </remarks>
	public interface IRepo
	{
	}

	/// <summary>
	/// for remote actions
	/// 
	/// repo is what's within the ".git" dir that can be synchrozed with a remoe. those cannot be synchronized should be scoped within "DotGit"
	/// So this is primarily a namespace place holder for all the actions to sync with remote.
	/// as the namespace, this denotes all the actions the scope of which (maybe empty) is within the repo only (but may read others.)
	/// </summary>


}
