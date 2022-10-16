using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svrs_.vsBbGl.client.prjs
{
	public class Add
	{
		private nilnul.fs.git.svr_.vs.Client _vs;

		public nilnul.fs.git.svr_.vs.Client vs
		{
			get { return _vs; }
			set { _vs = value; }
		}


		private nilnul.fs.git.svr_.bitBucket.Client _bitBucket;

		public nilnul.fs.git.svr_.bitBucket.Client bitBucket
		{
			get { return _bitBucket; }
			set { _bitBucket = value; }
		}

		private nilnul.fs.git.svr_.gitlab.Client _gitLab;

		public nilnul.fs.git.svr_.gitlab.Client gitLab
		{
			get { return _gitLab; }
			set { _gitLab = value; }
		}



		public Add(nilnul.fs.git.svr_.vs.Client vs
			,nilnul.fs.git.svr_.bitBucket.Client bitBucket, 
			nilnul.fs.git.svr_.gitlab.Client gitlab
			
		)
		{
			_vs = vs;
			_bitBucket = bitBucket;
			_gitLab = gitlab;
		}
		public IEnumerable< string> exe(string prj) {
			yield return new nilnul.fs.git.svr_.vs.client.prjs.add_.ByWebClient_basicUser(_vs).exe(
					prj
			);

			yield return new nilnul.fs.git.svr_.bitBucket.client.prjs.Add(_bitBucket).exe(prj);

			yield return new nilnul.fs.git.svr_.gitlab.client.prjs.Add(_gitLab)._response_assumeNormalized(prj);
		}
		public IEnumerable< string> exe_errAsMsg(string prj) {
			yield return new nilnul.fs.git.svr_.vs.client.prjs.add_.ByWebClient_basicUser(_vs).exe_errAsMsg(
					prj
			);

			yield return new nilnul.fs.git.svr_.bitBucket.client.prjs.Add(_bitBucket).exe_errAsMsg(prj);

			yield return new nilnul.fs.git.svr_.gitlab.client.prjs.Add(_gitLab).errAsMsg_assumeUnnormed(prj);
		}


	}
}
