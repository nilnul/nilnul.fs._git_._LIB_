using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.sups
{
	static public class _NearestGitModuleX
	{
		static public string _AddressNulable_ofAddress(string _folderAddress) {
			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(_folderAddress))
			{
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					return null;
					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					return nilnul.fs.folder_.git_.work._RtX.__Address_ofAddress(_folderAddress);
					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					return nilnul.fs.folder_.git_.repo.ModuleRt._Shield_ofAddress(_folderAddress).ToString();
					break;
				default:
					throw new UnexpectedReachException();
					break;
			}
		}

		static public string _AddressNulable_ofShield(nilnul.fs.address_.ShieldI _folderAddress) {
			return _AddressNulable_ofAddress(_folderAddress.ToString());
		}
	}
}
