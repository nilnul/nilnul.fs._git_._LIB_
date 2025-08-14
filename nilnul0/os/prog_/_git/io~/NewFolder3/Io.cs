using nilnul;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.fs.git
{
	/// <summary>
	/// read and write log
	/// write err
	/// write msg
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.fs._git.Io))]
	public class Io
	{


		private _io.Msg _msg;

		public _io.Msg msg
		{
			get { return _msg; }
			set { _msg = value; }
		}
		private _io.Err _err;

		public _io.Err err
		{
			get { return _err; }
			set { _err = value; }
		}


		private _io.Log _log;

		public _io.Log log
		{
			get { return _log; }
			set { _log = value; }
		}





		public Io(
			_io.Log log
			,
			_io.Err err
			,
			_io.Msg msg


		)
		{
			_msg = (msg);
			_err = (err);
			_log = log;
		}





		public void setAutoFlush()
		{
			_msg.setAutoFlush();
			_err.setAutoFlush();

		}





	}
}
