using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.repo
{
	/// <summary>
	/// there are rules for the repo name of vs(visual studio online src code mgt such as git svc)
	/// </summary>
	public class Name : _name.txt.be.vow.Ee
	{
		//[Obsolete("use by Encode")]
		public Name(string val) : base(val)
		{
		}

		static public string Normalize(string x)
		{
			return Encode(x);
		}
		/// <summary>
		/// escape starting "-" and trucate overlong.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public string Encode(string x)
		{
			var t = ((x.StartsWith("_") || x.StartsWith("-")) ? "-" : "")
					+
					x
			;
			//if (t.Length>64)
			//{
			//	if (t.LastIndexOf(".")>61) //at leat two chars must be remained for last seg.
			//	{
			//		throw new ArgumentOutOfRangeException($@"given name:{x} is too long and the trucation cannot be done for the last segment would be left with less than two chars.");

			//	}
			//	t = t.Substring(0, 64);
			//}
			//t = t.TrimEnd('.');

			return t;

		}


		/// <summary>
		/// encode the string
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(Of_byEncode))]
		static public Name ByEncode(string x)
		{
			return Of_byEncode(x);
		}

		/// <summary>
		/// assume unNormalized; now encode the string
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public Name Of_byEncode(string x)
		{
			try
			{
				return new Name(Encode(x));

			}
			catch (Exception e)
			{

				throw new Exception($"{x} as {typeof(Name).FullName} fails: maybe the name is too long or contains (at the begining, for example) invalid character", e);
			}
		}

		static public Name Of_byEncode(nilnul.fs.git.svr.repo.Name x)
		{
			//if (x is Name)
			//{
			//	return (Name)x;

			//}
			return Of_byEncode(x.ed);
		}

		static public Name Parse(string x)
		{
			try
			{
				return new Name(
					Normalize(x)
				);

			}
			catch (Exception e)
			{

				throw new Exception($"{x} as {typeof(Name).FullName} fails: maybe the name is too long or contains (at the begining, for example) invalid character", e);
			}
		}

		static public string Decode(string svrName)
		{
			if (_name.txt.be_.StartWithMinus.Singleton.be(svrName))
			{
				return svrName.Substring(1);
			}
			else
			{
				return svrName;
			}
		}

	}
}
