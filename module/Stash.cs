using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/*
	 n terms of drawing of commits (a graph like you get with gitk or git log --graph), you now have something like this. The stash is the little bag-of-i-w dangling off the commit you were "on", in your master branch, when you ran git stash. (The reason for the names i and w is that these are the "i"ndex / staging-area and "w"ork-tree parts of the stash.)
- A - B - C - D - E      <-- HEAD=master, origin/master
          |\
          i-w            <-- the "stash"
This drawing is what you get if you started working on master and never did any commits. The most recent commit you had was thus C. After making the stash, git pull was able to add commits D and E to your local branch master. The stashed bag of work is still hanging off C.
If you made a few commits of your own—we'll call them Y, for your commit, and Z just to have two commits—the result of the "stash then pull" looks like this:
                   .-------- origin/master
- A - B - C - D - E - M  <-- HEAD=master
            \       /
              Y - Z
                  |\
                  i-w    <-- the "stash"
				  
		*/




	/*
	 * 
	You need the directory to be clean (in git clean terms) for the stash to apply properly. This means running git clean -f, or even git clean -fdx, which is kind of an ugly thing to have to do, since some of the untracked or untracked-and-ignored files/directories may be items you want to keep, rather than deleting entirely. (If so, you should move them outside your work-tree instead of git clean-ing them away. Remember, the files that git clean removes are precisely those that you can't get back from nilnul.win.prog_.Git!)
To see why, look at step 3 in the "apply" description. Note that there is no option to skip the untracked and/or ignored files in a stash.
Basic facts about the stash itself
When you use git stash save with either -u or -a, the stash script writes its "stash bag" as a three-parent commit rather than the usual two-parent commit.
Diagrammatically, the "stash bag" normally looks like this, in terms of the commit graph:
o--o--C     <-- HEAD (typically, a branch)
      |\
      i-w   <-- stash
The os are any old ordinary commit nodes, as is C. Node C (for Commit) has a letter so we can name it: it's where the "stash bag" hangs from.
The stash bag itself is the little triangular bag hanging from C, and it contains two commits: w is the work-tree commit and i is the index commit. (Not shown, because it's just hard to diagram, is the fact that w's first parent is C and its second parent is i.)
With --untracked or --all there's a third parent for w, so the diagram looks more like this:
o--o--C     <-- HEAD
      |\
      i-w   <-- stash
       /
      u
(these diagrams really need to be images so that they can have arrows, rather than ASCII-art where arrows are tough to include). In this case, stash is commit w, stash^ is commit C (still also HEAD), stash^2 is commit i, and stash^3 is commit u, which contains the "untracked" or even "untracked and ignored" files. (It's not actually important, as far as I can tell, but I'll add here that i has C as a parent commit, while u is a parentless, or root, commit. There seems to be no particular reason for this, it's just how the script does things, but it explains why the "arrows" (lines) are as they are in the diagram.)
The various options at save time
At save time, you can specify any or all of the following options:
-p, --patch
-k, --keep-index, --no-keep-index
-q, --quiet
-u, --include-untracked
-a, --all
Some of these imply, override, or disable others. Using -p, for instance, completely changes the algorithm the script uses to build the stash, and also turns on --keep-index, forcing you to use --no-keep-index to turn it off if you don't want that. It is incompatible with -a and -u and will error-out if any of those are given.
Otherwise, between -a and -u, whichever one is set last is retained.
At this point the script creates either one or two commits:
one for the current index (even if it contains no changes), with parent commit C
with -u or -a, a parentless commit containing (only) either untracked files, or all (untracked and ignored) files.
The stash script then saves your current work tree. It does this with a temporary index file (basically, a fresh staging area). With -p, the script reads out the HEAD commit into the new staging area, then effectively1 runs git add -i --patch, so that this index winds up with the patches you select. Without -p, it just diffs the work directory against the stashed index to find changed files.2 In either case it writes a tree object from the temporary index. This tree will be the tree for commit w.
As its last stash-creation step, the script uses the tree just saved, the parent commit C, the index commit, and the root commit for untracked files if it exists, to create the final stash commit w. However, the script then takes several more steps that affect your work directory, depending on whether you're using -a, -u, -p, and/or --keep-index (and remember that -p implies --keep-index):
With -p:
"Reverse-patch" the work directory to remove the difference between HEAD and the stash. In essence, this leaves the work-directory with only those changes not stashed (specifically, those not in commit w; everything in commit i is ignored here).
Only if you specified --no-keep-index: run git reset (with no options at all, i.e., git reset --mixed). This clears out the "to be committed" state for everything, without changing anything else. (Of course, any partial changes you had staged before running git stash save -p, with git add or git add -p, are saved in commit i.)
Without -p:
Run git reset --hard (with -q if you specified that too). This sets the work tree back to the state in the HEAD commit.
Only if you specified -a or -u: run git clean --force --quiet -d (with -x if -a, or without it if -u). This removes all the untracked files, including untracked directories; with -x (i.e., under -a mode), it also removes all the ignored files.
Only if you specified -k / --keep-index: use git read-tree --reset -u $i_tree to "bring back" the stashed index as "changes to be committed" that also appear in the work tree. (The --reset should have no effect since step 1 cleared out the work tree.)
The various options at apply time
The two main sub-commands that restore a stash are apply and pop. The pop code just runs apply and then, if the apply succeeds, runs drop, so in effect, there's really just apply. (Well, there is also branch, which is a little more complicated—but in the end, it too uses apply.)
When you apply a stash—any "stash-like object", really, i.e., anything that the stash script can treat as a stash-bag—there are only two stash-specific options:
-q, --quiet
--index (not --keep-index!)
Other flags are accumulated, but are promptly ignored anyway. (The same parsing code is used for show, and here the other flags are passed on to git diff.)
Everything else is controlled by the contents of the stash-bag and the state of the work-tree and index. As above, I'll use the labels w, i, and u to denote the various commits in the stash, and C to denote the commit from which the stash-bag hangs.
The apply sequence goes like this, assuming all goes well (if something fails early, e.g., we are in the middle of a merge, or git apply --cached fails, the script errors-out at that point):
write current index into a tree, making sure we're not in the middle of a merge
only if --index: diff commit i against commit C, pipe to git apply --cached, save the resulting tree, and use git reset to unstage it
only if u exists: use git read-tree and git checkout-index --all with a temporary index, to recover the u tree
use git merge-recursive to merge the tree for C (the "base") with that written in step 1 ("updated upstream") and the tree in w ("stashed changes")
After this point it gets a bit complicated :-) as it depends on whether the merge in step 4 went well. But first let's expand the above a little.
Step 1 is pretty easy: the script just runs git write-tree, which fails if there are unmerged entries in the index. If the write-tree works the result is a tree ID ($c_tree in the script).
Step 2 is a more complicated as it checks not only the --index option but also that $b_tree != $i_tree (i.e., that there is a difference between the tree for C and the tree for i), and that $c_tree != $i_tree (i.e., that there is a difference between the tree written out in step 1, and the tree for i). The test for $b_tree != $i_tree makes sense: it's checking whether there's any change to apply. If there's no change—if the tree for i matches that for C—there's no index to restore, and --index is not needed after all. However, if $i_tree matches $c_tree, that merely means that the current index already contains the changes to be restored via --index. It's true that, in this case, we don't want to git apply those changes; but we do want them to remain "restored". (Maybe that's the point of the code I don't quite understand below. It seems more likely that there is a slight bug here, though.)
In any case, if step 2 needs to run git apply --cached, it also runs git write-tree to write the tree, saving this in the script's $unstashed_index_tree variable. Otherwise $unstashed_index_tree is left empty.
Step 3 is where things go wrong in an "unclean" directory. If the u commit exists in the stash, the script insists on extracting it, but git checkout-index --all will fail if any of those files would be overwritten. (Note that this is done with a temporary index file, which is removed afterward: step 3 does not use the normal staging area at all.)
(Step 4 uses three "magic" environment variables that I have not seen documented: $GITHEAD_t provides the "name" of the trees being merged. To run git merge-recursive, the script supplies four arguments: $b_tree -- $c_tree $w_tree. As already noted these are the trees for the base commit C, the index-at-start-of-apply, and the stashed work commit w. To get string-names for each of these trees, git merge-recursive looks in the environment for names formed by prepending GITHEAD_ to the raw SHA-1 for each tree. The script does not pass any strategy arguments to git merge-recursive, nor let you choose any strategy other than recursive. Probably it should.)
If the merge has a conflict, the stash script runs git rerere (q.v.) and, if --index, tells you that the index was not restored and exits with the merge-conflict status. (As with other early exits, this prevents a pop from dropping the stash.)
If the merge succeeds, though:
If we have a $unstashed_index_tree—i.e., we're doing --index, and all those other tests in step 2 passed too—then we need to restore the index state created in step 2. In this case a simple git read-tree $unstashed_index_tree (with no options) does the trick.
If we don't have something in $unstashed_index_tree, the script uses git diff-index --cached --name-only --diff-filter=A $c_tree to find files to add, runs git read-tree --reset $c_tree to do a single-tree merge against the original saved index, and then git update-index --add with the file names from the earlier diff-index. I'm not really sure why it goes to these lengths (there is a hint in the git-read-tree man page, about avoiding false hits for modified files, that might explain it), but that's what it does.
Last, the script runs git status (with output sent to /dev/null for -q mode; not sure why it runs at all under -q).
A few words on git stash branch
If you're having trouble applying a stash, you can turn it into a "real branch", which makes it guaranteed-to-restore (except, as usual, for the problem of a stash containing a commit u not applying unless you clean out unstaged and maybe even ignored files first).
The trick here is to start by checking out commit C (e.g., git checkout stash^). This of course results in a "detached HEAD", so you need to create a new branch, which you can combine with the step that checks out commit C:
git checkout -b new_branch stash^
Now you can apply the stash, even with --index, and it should work since it will be applying to the same commit the stash-bag hangs from:
git stash apply --index
At this point any earlier staged changes should be staged again, and any earlier unstaged (but tracked) files will have their unstaged-but-tracked changes in the work directory. It's safe to drop the stash now:
git stash drop
Using:
git stash branch new_branch
simply does the above sequence for you. It literally runs git checkout -b, and if that succeeds, applies the stash (with --index) and then drops it.
After this is done, you can commit the index (if you want to), then add and commit the remaining files, to make two (or one if you leave out the first, index, commit) "regular" commits on a "regular" branch:
o-o-C-o-...   <-- some_branch
     \
      I-W     <-- new_branch
and you've converted the stash-bag i and w commits to ordinary, on-branch commits I and W.

1More correctly, it runs git add-interactive --patch=stash --, which directly invokes the perl script for interactive adding, with special magic set for stashing. There are a few other magic --patch modes; see the script.
2There's a very small bug here: git reads $i_tree, the committed index's tree, into the temporary index, but then diffs the work directory against HEAD. This means that if you changed some file f in the index, then changed it back to match the HEAD revision, the work-tree stored under w in the stash-bag contains the index version of f instead of the work-tree version of f.
*/


	interface StatshI { }


}
