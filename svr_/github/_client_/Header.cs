using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github._client_
{
	public interface HeaderI
	{

		/// <summary>
		/// github requires a header.
		///		eg:
		///			header
		///			any
		/// </summary>
		/// blog.somewhatabstract.com/tag/productheadervalue/
		/// All but one of the constructors take a `ProductHeaderValue` instance, which provides some basic information about the application that is accessing the API. According to the documentation, this information is used by GitHub for analytics purposes and can be whatever you want.
		/// 
		 string product4header { get;  }

	}
}
