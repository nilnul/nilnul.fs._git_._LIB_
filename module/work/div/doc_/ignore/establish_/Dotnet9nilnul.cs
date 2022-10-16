using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git.module.work.div.doc_.ignore.establish_
{
	/* extern alias obj;*/
	/// <summary>
	/// if not exists,
	///		create with given content.
	///	if exists
	///		do nothing.
	/// </summary>
	static public class _Dotnet0nilnulX
	{

		static public void Force(nilnul.fs.FolderI targetAddress) {
			nilnul.fs.git.module.work.division.be_._ignored.rules_.dotnet0nilnul.ovFile_._EstablishX.Force
			(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress,
					git.module.work.div.doc_.Ignore._DOC__TXT
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
		static public bool Created(nilnul.fs.folder_.git_.Top targetAddress) {
			return nilnul.fs.git.module.work.division.be_._ignored.rules_.dotnet0nilnul.ovFile_._EstablishX.Created(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress.folder,
					git.module.work.div.doc_.Ignore._DOC__TXT//.IgnoreFileName
				 )
			);

		}

		static public bool Created(string targetAddress) {
			return Created( nilnul.fs.folder_.git_.Top.FroAddress(targetAddress));
		}

		static public bool Created(nilnul.fs.FolderI targetModule) {
			return Created(new nilnul.fs.folder_.git_.Top(targetModule));
		}

		static public void Create(string targetAddress) {
			Create( nilnul.fs.Folder.FroAddress(targetAddress));
		}

		static public void Create(nilnul.fs.FolderI targetAddress) {
			nilnul.fs.git.module.work.division.be_._ignored.rules_.dotnet0nilnul.ovFile_._EstablishX.Create(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress,
					git.module.work.div.doc_.Ignore._DOC__TXT//.IgnoreFileName
				 ).ToString()
			);
		}
	}
}