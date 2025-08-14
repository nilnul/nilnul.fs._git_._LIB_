using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git.module._ignore.apply_
{
	/* extern alias obj;*/
	/// <summary>
	/// ofModule
	/// </summary>
	/// 
	[Obsolete()]
	static public class _DotNetX
	{
		

		static public void Force(nilnul.fs.FolderI targetAddress) {

			_dotnet.by_._FileX.Force(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress,
					_Apply.IgnoreFileName
				 ).ToString()
			);
		}

		public static void Force(Top targetAddress)
		{
			_dotnet.by_._FileX.Force(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress.folder,
					_Apply.IgnoreFileName
				 )
			);

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
			return _dotnet.by_._FileX.Ensure(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress.folder,
					_Apply.IgnoreFileName
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
			_dotnet.by_._FileX.Create(
				nilnul.fs.folder.dir_.dst.to_._ElementX.To(
					targetAddress,
					_Apply.IgnoreFileName
				 ).ToString()
			);
		}
	}
}