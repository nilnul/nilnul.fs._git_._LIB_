using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_.git_.work_;

namespace nilnul.fs.git.module.repo.branch_.current.assign_
{
	static public class _ByUpdateRefX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_addressAssumeModule"></param>
		/// <param name="_assumeValid">
		/// a ref such as "refs/head/master"
		///		or
		///	a snap such as "02d02...", whence git updates not the HEAD, but the branch's content, which is changed the new git.
		/// </param>
		static public void _Assign_addressAssumeModule_assumeHead(string _addressAssumeModule,string _assumeValid) {
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
				_addressAssumeModule,
				$"update-ref HEAD {_assumeValid}"
			);
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
