using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._push
{
	static public class ExitCodeX
	{
		static public string Explain(ExitCode code) {
			switch (code)
			{
				case ExitCode.SvrErr:
					return "Error when pushing such as oversize, or lagbehind; or index.lock?"; /*
					! [rejected]        master -> master (fetch first)
error: failed to push some refs to 'https://.visualstudio.com/DefaultCollection/_git/nilnul.'
hint: Updates were rejected because the remote contains work that you do
hint: not have locally. This is usually caused by another repository pushing
hint: to the same ref. You may want to first integrate the remote changes
hint: (e.g., 'git pull ...') before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

					 */
					break;
				case ExitCode.Unfound:
					return "possible reason: some file is too large (for github the limit is 100Mbytes), time out or repo unfound";
					break;
				default:
					return "Error happend during pushing. Details are in the console; you can reproduce it by trying pushing again. Also consider reporting to the developer.";
					break;
			}
		}

		static public string Explain(int code) {

			return Explain(( ExitCode)code);/*from the C# 4.0 Specification:

1.10 Enums

Enum values can be converted to integral values and vice versa using type casts. For example

int i = (int)Color.Blue;      // int i = 2;
Color c = (Color)2;               // Color c = Color.Blue;
One additional thing to be aware of is that you are permitted to cast any integral value in the range of the enum's underlying type (by default that's int), even if that value doesn't map to one of the names in the enum declaration. From 1.10 Enums:

The set of values that an enum type can take on is not limited by its enum members. In particular, any value of the underlying type of an enum can be cast to the enum type and is a distinct valid value of that enum type.

So, the following is also permitted with the enum in your example:

det.documentStatus = (detallistaDocumentStatus) 42;
even though there's no enum name that has the value 42.*/
		}

	}
}
