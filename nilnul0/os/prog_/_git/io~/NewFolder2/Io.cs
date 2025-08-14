using nilnul;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.fs.git.bak
{
	/// <summary>
	/// read and write log
	/// write err
	/// write msg
	/// 
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.fs.git.Io))]
	public class Io
		:IDisposable
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



		public void flushAndClose() {
			msg.flushAndClose();
			err.flushAndClose();
		}

		public void setAutoFlush()
		{
			_msg.setAutoFlush();
			_err.setAutoFlush();

		}

		#region IDisposable Support
		private bool disposedValue = false; // 要检测冗余调用

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{

					flushAndClose();
					// TODO: 释放托管状态(托管对象)。
				}

				// TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
				// TODO: 将大型字段设置为 null。

				disposedValue = true;
			}
		}

		// TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
		// ~Io() {
		//   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
		//   Dispose(false);
		// }

		// 添加此代码以正确实现可处置模式。
		public void Dispose()
		{
			// 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
			Dispose(true);
			// TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
			// GC.SuppressFinalize(this);
		}
		#endregion


	}
}
