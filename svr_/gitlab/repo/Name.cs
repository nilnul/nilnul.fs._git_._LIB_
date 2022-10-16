using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.repo
{
	/// <summary>
	/// not normed in constructor
	/// </summary>

	public class Name// : _name.txt.be.vow.Ee
	{
		/// <summary>
		/// boxing this to invalidate implicit casting to txt, lest inadvertly taking this as unnormalized txt.
		/// </summary>
		private _name.txt.be.vow.Ee _vowee;

		public _name.txt.be.vow.Ee vowee
		{
			get { return _vowee; }
			set { _vowee = value; }
		}

		public Name(string val) //: base(val)
		{
			_vowee = new _name.txt.be.vow.Ee( val );
		}

		public override string ToString()
		{
			return _vowee;//.ToString();
		}

		/// <summary>
		/// apend special char with 0 if it's followed by another, or nul.
		/// </summary>
		/// <param name="intendedName"></param>
		/// <returns></returns>
		/// todo: this is not idempotent;
		/// we may need an idempotent, by, say, constrict out the special char.
		static public Name Normalize(string intendedName) {

			return new Name( _NameX.Encode(intendedName) );

		
			//return new Name(
			//	intendedName/*.Replace("-","-_")*/.Replace(".", "-")
			//);
		}

		

	}
}
