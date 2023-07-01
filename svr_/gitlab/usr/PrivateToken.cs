using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usr
{
	public class PrivateToken
	{
		/*
		You need to pass a private_token parameter via query string or header.If passed as a header, the header name must be PRIVATE-TOKEN(uppercase and with a dash instead of an underscore). You can find or reset your private token in your account page(/profile/account).
		*/

		public const string QueryStr_FieldName = "private_token";
		public const string Header_FieldName = "PRIVATE-TOKEN";


	}
}
