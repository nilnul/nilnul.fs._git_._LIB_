using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder
{
	public class Categorized<TBe >
		where TBe:category.BeI,new()
	{
		private Folder _folder;

		public Folder folder
		{
			get { return _folder; }
			//set { _folder = value; }
		}

		public Categorized(Category category)
		{
			git.folder.category.be.Aver<TBe>.Assert(category);

			_folder = category.folder;

		}

		public Categorized(Folder folder):this( Category.Eval(folder)  )
		{

		}
	}
}
