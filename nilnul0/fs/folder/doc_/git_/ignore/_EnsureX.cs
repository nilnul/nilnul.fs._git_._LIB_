using nilnul.fs.folder.doc_.git_.ignore;
using nilnul.fs.folder.doc_.giT_.ignore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.doc_.git_.ignore
{
	/// <summary>
	/// create the file if not exist;
	/// patch the ignore file to reflect dotnet ignores if exists;
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		ensure
	///		<see cref="nilnul.data.store_"/>
	/// <see cref="nilnul.data.store_.monolith.rite_.compound_.alter_.IModify"/>
	static public class _EnsureX
	{

		static public void _Vod_0folder(string top, IEnumerable<string> lines)
		{
			if (nilnul.fs.folder.doc_.git_.ignore.be_.ExistsDoc._Be_0folder(top))
			{
				_PatchX._Vod_0folderHavingIgnore(top, lines);

			}
			else
			{
				_EnforceX._Enforce_0folder(top, lines);
			}


		}
		static public void Exe(nilnul.fs.FolderI top, IEnumerable<string> lines)
		{
			if (nilnul.fs.folder.doc_.git_.ignore.be_.ExistsDoc.Be(top))
			{
				_PatchX._OfFolder(top, lines);

			}
			else
			{
				_EnforceX.Enforce(top, lines);
			}


		}



	}
}
