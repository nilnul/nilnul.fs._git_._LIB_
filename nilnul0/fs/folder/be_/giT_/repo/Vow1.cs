﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_.repo
{
	public class Vow
		:nilnul.fs.folder.be.Vow<Repo >
	{


		static public Vow Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow>.Instance;
			}
		}


	}
}
