using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.sups
{

	static public class _NearestGitModuleX
	{
		static public string AddressNulable(
			nilnul.fs.address_.ShieldI _shieldAddress
		) {
			var nearestFolder = nilnul.fs.address_.shield.sups_.existed._NearestFolderX.ShieldNulable(_shieldAddress);

			if (nearestFolder==null)
			{
				return null;
			}
			else
			{
				return nilnul.fs.folder.sups._NearestGitModuleX._AddressNulable_ofShield(_shieldAddress);
			}
		}

		static public nilnul.fs.address_.ShieldI ShieldNulable(
			nilnul.fs.address_.ShieldI _shieldAddress
		)
		{
			return nilnul.fs.address_.shield.nulable_._AddressNulableX.Parse(
				AddressNulable(_shieldAddress)
			);
		}

		static public nilnul.fs.address_.ShieldI ShieldNulable_ofAddress(
			string _shieldAddress
		)
		{
			return ShieldNulable ( 
				nilnul.fs.address_.Shield.FroAddress(
					_shieldAddress
				)
			);
		}
	}
}