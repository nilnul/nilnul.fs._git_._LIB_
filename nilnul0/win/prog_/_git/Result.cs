using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_._git
{
	public class Result
	{
		
		public string err;
		public string msg;
		public int errCode;


		public Result(int errCode, string result, string err)
		{
			this.err = err;
			this.errCode = errCode;
			this.msg = result;
		}

		



		public bool beErr
		{
			get { return errCode!=0; }
		}


		public bool notBeErr
		{
			get { return !beErr; }
		}

		public override string ToString()
		{
			return $"{msg}{Environment.NewLine}{err}{Environment.NewLine}{errCode}";	
		}


	}
}
