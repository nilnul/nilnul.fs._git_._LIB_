using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git._module.work._ignore.div.doc.ensure_
{
	/* extern alias obj;*/
	/// <summary>
	/// ofModule.
	/// also ensure nilnul settings/rules
	/// </summary>
	///
	[Obsolete(nameof( git.module.work.div.doc_.ignore.establish_._Dotnet0nilnulX) )]
	static public class _DotNetX
	{

		static public void Force(nilnul.fs.FolderI targetAddress) {

			_doc.file._DotNetX.Force(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress,
					_DocX.NAME
				 ).ToString()
			);
		}

		public static void Force(Top targetAddress)
		{
			Force(
				targetAddress.en
			);
			//_doc.file._DotNetX.Force(
			//	nilnul.fs.folder.dir_.dst.to_._ElementX.To(
			//		targetAddress.folder,
			//		_DocX.NAME//.IgnoreFileName
			//	 )
			//);

			//throw new NotImplementedException();
		}
	
		public static void Force(string targetAddress)
		{
			Force(nilnul.fs.Folder.FroAddress(targetAddress)  );

			//throw new NotImplementedException();
		}



		/// <summary>
		/// true if created
		/// </summary>
		/// <param name="targetAddress"></param>
		/// <returns>true if created</returns>
		static public bool Ensure(nilnul.fs.folder_.git_.Top targetAddress) {
			return _doc.file._DotNetX.Ensure(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress.folder,
					_DocX.NAME//.IgnoreFileName
				 )
			);

		}

		static public bool Ensure(string targetAddress) {
			return Ensure( nilnul.fs.folder_.git_.Top.FroAddress(targetAddress));
		}

		static public bool Ensure(nilnul.fs.FolderI targetModule) {
			return Ensure(new nilnul.fs.folder_.git_.Top(targetModule));
		}

		static public void Create(string targetAddress) {
			Create( nilnul.fs.Folder.FroAddress(targetAddress));
		}

		static public void Create(nilnul.fs.FolderI targetAddress) {
			_doc.file._DotNetX.Create(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress,
					_DocX.NAME//.IgnoreFileName
				 ).ToString()
			);
		}
	}
}