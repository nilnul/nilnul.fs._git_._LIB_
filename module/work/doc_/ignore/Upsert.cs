using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.div_.top.doc_.ignore
{
	/// <summary>
	/// if it's not created, create
	/// if it's created, patch it.
	/// aka:
	///		upsert in db
	///		put in webApi
	/// </summary>
	static public class _UpsertX
	{
		static public void Upsert(nilnul.fs.git.ModuleI module, IEnumerable<string> lines) {
			if (doc_._IgnoreX.Exist(module))
			{
				_PatchX.Vod(module, lines);
			}
			else
			{
				_CreateX.WouldForce(module, lines);
			}
		}
	}
}
