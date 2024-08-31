using nilnul.fs.address_;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;
using System;

namespace nilnul.fs.git.module.repo.branch_.current
{
	[Obsolete(nameof(repo.head.branch._VwX))]
	public static class _VwX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns>
		/// "HEAD", when detached
		/// if remote, svr1/branch1
		/// </returns>
		public static string Txt(Top gitTop, Git git=null)
		{
			return current.nulable._VwX._Nuly_moduleAssumeAddress(gitTop.ToString(),git);

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(gitTop, "rev-parse --abbrev-ref HEAD", git);
		}
		public static string _Txt_assumeWorktop(ShieldI en, Git git=null)
		{
			return current.nulable._VwX._Nuly_moduleAssumeAddress(en,git);
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(en, "rev-parse --abbrev-ref HEAD", git);

			//throw new NotImplementedException();
		}

		public static string _Txt_assumeWorktop(FolderI en, Git boxed=null)
		{
			return _Txt_assumeWorktop(en.address.en,boxed);
			throw new NotImplementedException();
		}


		public static string Txt(fs.folder_.git_.work_.Top top1, Git boxed=null)
		{
			return _Txt_assumeWorktop(top1.en,boxed);
			//throw new NotImplementedException();
		}


		public static string Txt(ModuleI module, Git boxed=null)
		{
			return Txt(
				module.top1,boxed
			);
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="workingDir"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// <exception cref="">fatal:bad revision head if the branch is not born</exception>
		public static string Txt(nilnul.fs.Folder workingDir, nilnul.win.prog_.Git git = null)
		{
			return Txt(new Top(workingDir), git);
		}




		public static string Txt_ofAddress(string workingDir, Git git=null)
		{
			return Txt(nilnul.fs.Folder.FroAddress(workingDir),git);

		}

	}

	public class Vw : nilnul.win.prog_.git.Boxed
	{
		public Vw()
		{
		}

		public Vw(Git val) : base(val)
		{
		}

		public string Txt(nilnul.fs.git.ModuleI module) {
			return _VwX.Txt(module, this.boxed);
		}
	}
}
