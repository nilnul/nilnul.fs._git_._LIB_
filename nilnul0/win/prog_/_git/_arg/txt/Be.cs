using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace nilnul.win.prog_._git._arg.txt
{
	extern alias character;
	/// <summary>
	/// the argument in git. quoted, or no space
	/// </summary>
	public class Be : nilnul.txt.BeI
	{


		static public bool Eval(string arg)
		{


			if (nilnul.txt.be_.White.Singleton.be(arg))
			{
				return false;
			}

			if (arg.Length == 1)
			{
				if (arg == "\"")
				{
					return false;
				}
				else
				{
					return true;

				}
			}

			if (arg.First() == '\"')
			{
				if (arg.Last() == '\"')
				{
					return _BeOfQuotedContent(
						arg.Substring(1, arg.Length - 2)
					);
				}
				else
				{
					return false;
				}
			}
			if (arg.Last() == '\"')
			{
				return false;
			}
			return _BeOfNotQuoted(arg);


		}

		/// <summary>
		/// the string starts with no \", and ends with no \"
		/// </summary>
		/// <param name="argUnquoted"></param>
		/// <returns></returns>
		static public bool _BeOfNotQuoted(string argUnquoted)
		{

			return !argUnquoted.Contains("\"") 
				&& 
				!nilnul.txt.be_.contain_.White.Singleton.be(
					argUnquoted
				)
			;
		}


		/// <summary>
		/// the string is quoted by double-quotation-mark
		/// </summary>
		/// <param name="argUnquoted"></param>
		/// <returns></returns>
		static public bool _BeOfQuotedContent(string argUnquoted)
		{
			var doubleQuoteRemoved = argUnquoted.Replace("\"\"", "");
			return !doubleQuoteRemoved.Contains("\"") 
				&& 
				!nilnul.txt.be_.contain_.White.Singleton.be(
					doubleQuoteRemoved
				)
			;
		}



		public bool be(string obj)
		{
			return Eval(obj);
			//throw new NotImplementedException();
		}


		static public Be Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Be>.Instance;
			}
		}




	}

	public class En : nilnul.obj.be.vow.Ed_beDefaultable<string, Be>
	{
		public En(string val) : base(val)
		{
		}
	}

}
