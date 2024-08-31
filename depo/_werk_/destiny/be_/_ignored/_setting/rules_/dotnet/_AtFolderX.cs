using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git.module.work.div._ignore._doc
{
	/* extern alias obj;*/
	/// <summary>
	/// ofModule
	/// </summary>
	static public class _AtFolderX
	{

		static public void Force(nilnul.fs.FolderI targetAddress) {

			_FileX.Force(
				new nilnul.fs.address_.spear_.ParentDoc(
					targetAddress.address.en,
					_ignore._DocX.IgnoreFileName
				 ).ToString()
			);
		}

		public static void Force(nilnul.fs.folder_.git_.Top targetAddress)
		{
			Force(targetAddress.en);

			//throw new NotImplementedException();
		}
	
		public static void Force_ofAddress(string targetAddress)
		{
			Force(nilnul.fs.Folder.FroAddress(targetAddress)  );

			//throw new NotImplementedException();
		}

		static public void Create(nilnul.fs.FolderI targetAddress)
		{
			_FileX.Create(
				new nilnul.fs.address_.spear_.ParentDoc(
					targetAddress.address.en,
					_ignore._DocX.IgnoreFileName
				 ).ToString()
			);
		}

		static public void Create_ofAddress(string targetAddress)
		{
			Create(nilnul.fs.Folder.FroAddress(targetAddress));
		}


		/// <summary>
		/// true if created
		/// </summary>
		/// <param name="targetAddress"></param>
		/// <returns>true if created</returns>
		static public bool Ensure(nilnul.fs.FolderI targetAddress) {
			return _FileX.Ensure(
				new nilnul.fs.address_.spear_.ParentDoc(
					targetAddress.address.en,
					_ignore._DocX.IgnoreFileName
				 )
			);

		}
		static public bool Ensure(nilnul.fs.folder_.git_.Top targetModule) {
			return Ensure(targetModule.folder);
		}

		static public bool Ensure_ofAddress(string targetAddress) {
			return Ensure( nilnul.fs.Folder.FroAddress(targetAddress));
		}



	}
}