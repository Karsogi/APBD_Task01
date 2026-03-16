This project demonstrates clean Git history, branching, and merges.
Note: The merge of feature-max was not fast-forward because main had an independent commit (updating the README) that was not in the feature-max branch. Git therefore created a merge commit to combine the histories.

1.When does Git perform a fast-forward and when is a merge commit created?

Git performs a fast-forward merge when the main branch has no new commits after a feature branch was created. In this case Git simply moves the main pointer forward to the latest commit of the feature branch.

A merge commit is created when both branches have new commits. Git must combine the histories of the two branches, so it creates a new commit that joins them.

2.What is the practical difference between merge and rebase?

Merge joins two branches together and usually creates a merge commit. It keeps the full branch history.

Rebase moves the commits from one branch on top of another branch. This makes the history look like a straight line and removes extra merge commits.

3.How was the conflict resolved in this repository?

A conflict happened because the same line of code was changed differently in main and in feature-conflict.

Git marked the conflict in the file. The file was opened, the correct version of the code was chosen, and the conflict markers were removed. After that the file was added with git add and the merge was finished with a commit.