using nilnul;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.fs.git.bak._io
{
	/// <summary>
	/// write err
	/// 
	/// </summary>
	public  class Msg
	{

		
		private StreamWriter _writer;

		public StreamWriter writer
		{
			get { return _writer; }
			set { _writer = value; }
		}





		public Msg(
			StreamWriter writer	


		)
		{
			_writer = writer;
		}



		public void setAutoFlush() {
			_writer.AutoFlush = true;
			
		}

		public void flushAndClose() {
			writer.Flush();
			writer.Close();

		}

		public void writeRec(string s)
		{
			writer.WriteLine();
			writer.WriteLine($"=================={nilnul.time.to_.txt_.Iso.Singleton.to()}==========================");
			writer.WriteLine(s);
		}








	}
}
