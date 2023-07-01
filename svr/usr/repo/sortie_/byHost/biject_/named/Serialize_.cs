using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo.sortie_.byHost.biject_.named
{
	enum Serialize_
	{
		/// <summary>
		/// sometimes deserialized as null unexpectedly when restarting the computer while it works in the same session of visual studio even if we close and restart the program. Don't know whether it's due to the lack of parameterless constructor
		/// </summary>
		Binary
			,
		/// <summary>
		/// serialized as null. Maybe this is due to we fail to mark some fileds as To Serialize?
		/// </summary>
		Xml
			,
		/// <summary>
		/// we serialize it by ourself, and then save the txt to the settings.
		/// </summary>
		Xml2txt

			
	}
}
