using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.duo
{
	/*
	 发信人: zeus2615 (zeuslord·呆猫), 信区: Programming
标  题: Re: git有没有单独merge一个文件的功能
发信站: 水木社区 (Tue Aug  1 21:22:10 2017), 站内

sof的回答是
git checkout B

git checkout --patch A f

我记得自己好像用过没问题，不是特别确定
【 在 libgcc (不要再叫我吃键盘|继续五年内不bg) 的大作中提到: 】
: 标  题: git有没有单独merge一个文件的功能
: 发信站: 水木社区 (Tue Aug  1 16:54:54 2017), 站内
: 
: 
: 我现在有2个br,A跟B
: 我在A上改了一个文件,提交
: 然后在B上,改了同一个文件,突然想起来A上的修改也是要用到的
: 
: 我想直接把A上的文件的修改merge到B上来,而且是非交互的,冲突了直接修改文件
: >>>>>A
: =======
: <<<<<B
: 这种
: 
: 要求:
: 只merge这一个文件,不是整个项目,不是整个commit,cherry-pick好像也不支持单个文件
: 不要像git checkout -p 这种交互式的,好麻烦,看的头疼
: 
: 不知道有没有别的什么办法?
: 
: --
: keyboard not found. Press F1 to continue...
: 
: 
: ※ 来源:·水木社区 newsmth.net·[FROM: 111.47.10.*]

		 */
	class MergeFile
	{
	}
}
