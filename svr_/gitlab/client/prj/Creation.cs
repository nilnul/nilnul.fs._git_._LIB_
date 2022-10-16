using System;

namespace nilnul.fs.git.svr_.gitlab.client.prj
{
	public class Creation
	{

		private svr_.gitlab.Client _svr;

		public svr_.gitlab.Client svr
		{
			get { return _svr; }
			set { _svr = value; }
		}

		public Creation(svr_.gitlab.Client gitLab)
		{
			_svr = gitLab;
		}


	

		public string _response_assumeNormalized(string prj)
		{

			return _CreationX. _ByWebReq_assumesNormed(

				_svr.credential.txt
				,
				prj

			);
		}

		public string errAsMsg_assumeUnnormed(string prj)
		{ 
			try
			{
				return _CreationX._ByWebReq_assumesNormed(
					_svr.credential.txt
					,
					nilnul.fs.git.svr_.gitlab.repo._NameX.Encode(prj)

				//prj
				);

			}
			catch (Exception e)
			{
				return e.Message;

				//throw;
			}
		}

		public string errInMsg_assumeNormed(string prj)
		{
			try
			{
				return _CreationX._ByWebReq_assumesNormed(
					_svr.credential.txt
					,
					prj

				//prj
				);

			}
			catch (Exception e)
			{
				return e.Message;

				//throw;
			}
		}
	}
}

