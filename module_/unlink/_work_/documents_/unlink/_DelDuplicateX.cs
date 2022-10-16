using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module_.unlink._work_.documents_.unlink
{
	static public class _DelDuplicateX
	{

		static public void _OfAddress(
			string folder

			,
			TraceSource log

		)
		{


			//var shield = nilnul.fs.address_.shield_._AddressX1.Create(folder);
			//var documents = nilnul.fs.git.module_.unlink._work_.documents_._UnlinkX.Infos_ofAddress(folder);

			nilnul.fs.files.dedup_._TraceSrcX._Void(
				nilnul.fs.git.module_.unlink._work_.documents_._UnlinkX.Addresses_ofAddress(folder)
				, log

			);
			//partition the folder

			//var partiton = nilnul.set.partite_._InnerEqDefaultX.Partite(
			//	documents.Select(x => new nilnul.fs.File(x))
			//	,
			//	nilnul.fs.file.eq_.Binary.Singleton
			//);


			//foreach (var part in partiton)
			//{

			//	var ordered = part.OrderByDescending(
			//		x =>
			//		nilnul.fs.file.to_.ToFileInfo.Singleton.to(x).LastWriteTime
			//	);

			//	var kept = ordered.First();

			//	var kept_ShieldDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(kept.file.en.ToString());

			//	var targetDocument1 = nilnul.fs.address_.shieldSpear_.sup._DifX._ofSupSub(
			//		shield
			//		,
			//		kept_ShieldDoc
			//	);

			//	ordered.Skip(1).ForEach(
			//		y =>
			//		{
			//			var verOfFolder = new nilnul.fs.folder.denote_.Vered(
			//				kept_ShieldDoc.parent
			//			);

			//			var currentContainerDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(y.file.en.ToString());

			//			var toBeDelDocument = nilnul.fs.address_.shieldSpear_.sup._DifX._ofSupSub(

			//				shield
			//				,
			//				currentContainerDoc
			//			);

			//			var relPath = nilnul.fs._address.document.duo.RelPathX.RelPath(
			//				toBeDelDocument
			//				,
			//				targetDocument1
			//			);

			//			var linkName = verOfFolder.getNextDst(currentContainerDoc.doc.ToString() + "_", "lnk");

			//			var linkNameParsed = nilnul.fs._address.doc_.exted_.Dotted.Parse(linkName);

			//			nilnul.fs.file_.shortcut_.relative_.explorer._CreateX.Create(
			//				currentContainerDoc.parent
			//				,
			//				linkNameParsed.main
			//					,
			//				relPath


			//			);

			//			nilnul.fs.file.del_._RecyclableX.Del(y);
			//		}
			//	);
			//}

		}

		static public void Exe(
			Unlink folder
						,
			TraceSource log

		)
		{
			_OfAddress(folder.en.top.en.ToString(),log);
		}
		static public void OfAddress(
			string folder
						,
			TraceSource log

		)
		{
			Exe(Unlink.FroAddress(folder),log);
		}


	}
}
