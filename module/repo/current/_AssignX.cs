using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_.git_.work_;

namespace nilnul.fs.git.module.repo.current
{
	static public class _AssignX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_addressAssumeModule"></param>
		/// <param name="_assumeValid">
		/// a ref such as "refs/head/master"
		///		or
		///	a snap such as "02d02..."
		///
		/// if it's a branch name without slashes, such as "branch123", then the current is detached at the tip's commit hashId.
		/// </param>
		static public void _Assign_addressAssumeModule_assumeHead(string _addressAssumeModule,string _assumeValid, nilnul.os.prog_.Git git=null) {
			if (_assumeValid.IndexOf('/')>=0)
			{
				assign_._ReferenceX._Vod_addressAssumeModule_assumeRef(_addressAssumeModule,_assumeValid,git);
				return;
			}
			assign_._SnapX._Vod_addressAssumeModule_assumeSnap(_addressAssumeModule,_assumeValid,git);
		}
		private static void _Assign_assumeModule_assumeHead(ShieldI en, string oldHead)
		{
			_Assign_addressAssumeModule_assumeHead(
				en.ToString(),oldHead
			);
		}
		private static void _Assign_assumeModule_assumeHead(Exist address, string oldHead)
		{
			_Assign_assumeModule_assumeHead(
				address.en,oldHead
			);

		}


		private static void _Assign_assumeModule_assumeHead(FolderI en, string oldHead)
		{
			_Assign_assumeModule_assumeHead(
				en.address,oldHead
			);

		}


		public static void _Assign_1assumeHead(Top top1, string oldHead)
		{
			_Assign_assumeModule_assumeHead(
				top1.en,oldHead
			);

		}


		public static void _Assign_1assumeHead(Module module, string oldHead)
		{
			_Assign_1assumeHead(
				module.top1,oldHead
			);
		}

	}
}
