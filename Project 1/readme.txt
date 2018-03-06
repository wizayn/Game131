C:\Users\svc-student>cd desktop

C:\Users\svc-student\Desktop>mkdir Development

C:\Users\svc-student\Desktop>cd Development

C:\Users\svc-student\Desktop\Development>git clone https://github.com/wizayn/Game131.git
Cloning into 'Game131'...
warning: You appear to have cloned an empty repository.

C:\Users\svc-student\Desktop\Development>cd game 131
The system cannot find the path specified.

C:\Users\svc-student\Desktop\Development>cd game131

C:\Users\svc-student\Desktop\Development\Game131>git config user.name wrobert8

C:\Users\svc-student\Desktop\Development\Game131>git config user.email wrobert8@stumail.jccc.edu

C:\Users\svc-student\Desktop\Development\Game131>git branch -a

C:\Users\svc-student\Desktop\Development\Game131>echo placeholder > readme.txt

C:\Users\svc-student\Desktop\Development\Game131>git add readme.txt

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "first commit"
[master (root-commit) 089e700] first commit
 1 file changed, 1 insertion(+)
 create mode 100644 readme.txt

C:\Users\svc-student\Desktop\Development\Game131>git push origin master
Counting objects: 3, done.
Writing objects: 100% (3/3), 224 bytes | 224.00 KiB/s, done.
Total 3 (delta 0), reused 0 (delta 0)
To https://github.com/wizayn/Game131.git
 * [new branch]      master -> master

C:\Users\svc-student\Desktop\Development\Game131>git branch -a
* master
  remotes/origin/master

C:\Users\svc-student\Desktop\Development\Game131>cd ..

C:\Users\svc-student\Desktop\Development>rmdir /r /q
Invalid switch - "r".

C:\Users\svc-student\Desktop\Development>git clone https://github.com/wizayn/Game131.git
Cloning into 'Game131'...
remote: Counting objects: 3, done.
remote: Total 3 (delta 0), reused 3 (delta 0), pack-reused 0
Unpacking objects: 100% (3/3), done.

C:\Users\svc-student\Desktop\Development>cd game131

C:\Users\svc-student\Desktop\Development\Game131>git branch -a
* master
  remotes/origin/HEAD -> origin/master
  remotes/origin/master

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

nothing to commit, working tree clean

C:\Users\svc-student\Desktop\Development\Game131>echo digital play-doh > reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>dir
 Volume in drive C has no label.
 Volume Serial Number is 78AF-D4BD

 Directory of C:\Users\svc-student\Desktop\Development\Game131

02/01/2018  06:30 PM    <DIR>          .
02/01/2018  06:30 PM    <DIR>          ..
02/01/2018  06:25 PM                14 readme.txt
02/01/2018  06:30 PM                19 reshirt.txt
               2 File(s)             33 bytes
               2 Dir(s)  176,158,523,392 bytes free

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Untracked files:
  (use "git add <file>..." to include in what will be committed)

        reshirt.txt

nothing added to commit but untracked files present (use "git add" to track)

C:\Users\svc-student\Desktop\Development\Game131>git add redshirt.txt
fatal: pathspec 'redshirt.txt' did not match any files

C:\Users\svc-student\Desktop\Development\Game131>git add reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        new file:   reshirt.txt


C:\Users\svc-student\Desktop\Development\Game131>echo new information available > readme.txt

C:\Users\svc-student\Desktop\Development\Game131>more readme.txt
new information available

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        new file:   reshirt.txt

Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git checkout -- <file>..." to discard changes in working directory)

        modified:   readme.txt


C:\Users\svc-student\Desktop\Development\Game131>git add readme.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        modified:   readme.txt
        new file:   reshirt.txt


C:\Users\svc-student\Desktop\Development\Game131>echo Even newer information available > readme.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        modified:   readme.txt
        new file:   reshirt.txt

Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git checkout -- <file>..." to discard changes in working directory)

        modified:   readme.txt


C:\Users\svc-student\Desktop\Development\Game131>git add readme.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        modified:   readme.txt
        new file:   reshirt.txt


C:\Users\svc-student\Desktop\Development\Game131>echo I am untracked > untracked.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        modified:   readme.txt
        new file:   reshirt.txt

Untracked files:
  (use "git add <file>..." to include in what will be committed)

        untracked.txt


C:\Users\svc-student\Desktop\Development\Game131>git status -s
M  readme.txt
A  reshirt.txt
?? untracked.txt

C:\Users\svc-student\Desktop\Development\Game131>echo Second deits > readme.txt

C:\Users\svc-student\Desktop\Development\Game131>git status -s
MM readme.txt
A  reshirt.txt
?? untracked.txt

C:\Users\svc-student\Desktop\Development\Game131>del untracked.txt

C:\Users\svc-student\Desktop\Development\Game131>git status -s
MM readme.txt
A  reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Change demo"
[master 1a775ef] Change demo
 Committer: svc-student <svc-student@student.directory.jccc>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly:

    git config --global user.name "Your Name"
    git config --global user.email you@example.com

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 2 files changed, 2 insertions(+), 1 deletion(-)
 create mode 100644 reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is ahead of 'origin/master' by 1 commit.
  (use "git push" to publish your local commits)

Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git checkout -- <file>..." to discard changes in working directory)

        modified:   readme.txt

no changes added to commit (use "git add" and/or "git commit -a")

C:\Users\svc-student\Desktop\Development\Game131>echo Danger increasing > reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git status -s
 M readme.txt
 M reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git add reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git status -s
 M readme.txt
M  reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git status -s
 M readme.txt
MD reshirt.txt
?? redshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>delete reshirt.txt
'delete' is not recognized as an internal or external command,
operable program or batch file.

C:\Users\svc-student\Desktop\Development\Game131>git status -s
 M readme.txt
MD reshirt.txt
?? redshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>del reshirt.txt
Could Not Find C:\Users\svc-student\Desktop\Development\Game131\reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Change demo"
[master 7728434] Change demo
 Committer: svc-student <svc-student@student.directory.jccc>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly:

    git config --global user.name "Your Name"
    git config --global user.email you@example.com

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 1 file changed, 1 insertion(+), 1 deletion(-)

C:\Users\svc-student\Desktop\Development\Game131>git status -s
 M readme.txt
 D reshirt.txt
?? redshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git add readme.txt

C:\Users\svc-student\Desktop\Development\Game131>git add redshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git status -s
M  readme.txt
A  redshirt.txt
 D reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Change demo"
[master b4f71ad] Change demo
 Committer: svc-student <svc-student@student.directory.jccc>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly:

    git config --global user.name "Your Name"
    git config --global user.email you@example.com

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 2 files changed, 2 insertions(+), 1 deletion(-)
 create mode 100644 redshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git status -s
 D reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git rm reshirt.txt
rm 'reshirt.txt'

C:\Users\svc-student\Desktop\Development\Game131>git rm redshirt.txt
rm 'redshirt.txt'

C:\Users\svc-student\Desktop\Development\Game131>git status -s
D  redshirt.txt
D  reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Killing off first redshirt"
[master 308237d] Killing off first redshirt
 Committer: svc-student <svc-student@student.directory.jccc>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly:

    git config --global user.name "Your Name"
    git config --global user.email you@example.com

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 2 files changed, 2 deletions(-)
 delete mode 100644 redshirt.txt
 delete mode 100644 reshirt.txt

C:\Users\svc-student\Desktop\Development\Game131>git status -s

C:\Users\svc-student\Desktop\Development\Game131>echo Backup on the way > redshirt2.txt

C:\Users\svc-student\Desktop\Development\Game131>dir
 Volume in drive C has no label.
 Volume Serial Number is 78AF-D4BD

 Directory of C:\Users\svc-student\Desktop\Development\Game131

02/01/2018  06:46 PM    <DIR>          .
02/01/2018  06:46 PM    <DIR>          ..
02/01/2018  06:38 PM                15 readme.txt
02/01/2018  06:46 PM                20 redshirt2.txt
               2 File(s)             35 bytes
               2 Dir(s)  176,155,119,616 bytes free

C:\Users\svc-student\Desktop\Development\Game131>del reshirt2.txt
Could Not Find C:\Users\svc-student\Desktop\Development\Game131\reshirt2.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is ahead of 'origin/master' by 4 commits.
  (use "git push" to publish your local commits)

Untracked files:
  (use "git add <file>..." to include in what will be committed)

        redshirt2.txt

nothing added to commit but untracked files present (use "git add" to track)

C:\Users\svc-student\Desktop\Development\Game131>git status -s
?? redshirt2.txt

C:\Users\svc-student\Desktop\Development\Game131>git add redshirt2.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is ahead of 'origin/master' by 4 commits.
  (use "git push" to publish your local commits)

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        new file:   redshirt2.txt


C:\Users\svc-student\Desktop\Development\Game131>del reshirt2.txt
Could Not Find C:\Users\svc-student\Desktop\Development\Game131\reshirt2.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is ahead of 'origin/master' by 4 commits.
  (use "git push" to publish your local commits)

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        new file:   redshirt2.txt


C:\Users\svc-student\Desktop\Development\Game131>del reshirt2.txt
Could Not Find C:\Users\svc-student\Desktop\Development\Game131\reshirt2.txt

C:\Users\svc-student\Desktop\Development\Game131>del redshirt2.txt

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is ahead of 'origin/master' by 4 commits.
  (use "git push" to publish your local commits)

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        new file:   redshirt2.txt

Changes not staged for commit:
  (use "git add/rm <file>..." to update what will be committed)
  (use "git checkout -- <file>..." to discard changes in working directory)

        deleted:    redshirt2.txt


C:\Users\svc-student\Desktop\Development\Game131>git rm redshirt2.txt
rm 'redshirt2.txt'

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is ahead of 'origin/master' by 4 commits.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean

C:\Users\svc-student\Desktop\Development\Game131>git commit "Second redshirt down"
error: pathspec 'Second redshirt down' did not match any file(s) known to git.

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Second redshirt down"
On branch master
Your branch is ahead of 'origin/master' by 4 commits.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean

C:\Users\svc-student\Desktop\Development\Game131>git push
Counting objects: 12, done.
Delta compression using up to 16 threads.
Compressing objects: 100% (7/7), done.
Writing objects: 100% (12/12), 1.07 KiB | 1.07 MiB/s, done.
Total 12 (delta 0), reused 0 (delta 0)
To https://github.com/wizayn/Game131.git
   089e700..308237d  master -> master

C:\Users\svc-student\Desktop\Development\Game131>add Initializer.bat
'add' is not recognized as an internal or external command,
operable program or batch file.

C:\Users\svc-student\Desktop\Development\Game131>git add Initializer.bat
fatal: pathspec 'Initializer.bat' did not match any files

C:\Users\svc-student\Desktop\Development\Game131>echo @echo off > Initializer.bat

C:\Users\svc-student\Desktop\Development\Game131>dir
 Volume in drive C has no label.
 Volume Serial Number is 78AF-D4BD

 Directory of C:\Users\svc-student\Desktop\Development\Game131

02/01/2018  06:55 PM    <DIR>          .
02/01/2018  06:55 PM    <DIR>          ..
02/01/2018  06:55 PM                12 Initializer.bat
02/01/2018  06:38 PM                15 readme.txt
               2 File(s)             27 bytes
               2 Dir(s)  176,155,578,368 bytes free

C:\Users\svc-student\Desktop\Development\Game131>git commit "Initializer first commit"
error: pathspec 'Initializer first commit' did not match any file(s) known to git.

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Untracked files:
  (use "git add <file>..." to include in what will be committed)

        Initializer.bat

nothing added to commit but untracked files present (use "git add" to track)

C:\Users\svc-student\Desktop\Development\Game131>git add Initializer.bat

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        new file:   Initializer.bat


C:\Users\svc-student\Desktop\Development\Game131>git commit "Initializer first commit"
error: pathspec 'Initializer first commit' did not match any file(s) known to git.

C:\Users\svc-student\Desktop\Development\Game131>git push
Everything up-to-date

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "First Initializer commit"
[master ed97f65] First Initializer commit
 Committer: svc-student <svc-student@student.directory.jccc>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly:

    git config --global user.name "Your Name"
    git config --global user.email you@example.com

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 1 file changed, 1 insertion(+)
 create mode 100644 Initializer.bat

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is ahead of 'origin/master' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean

C:\Users\svc-student\Desktop\Development\Game131>git push
Counting objects: 3, done.
Delta compression using up to 16 threads.
Compressing objects: 100% (2/2), done.
Writing objects: 100% (3/3), 311 bytes | 311.00 KiB/s, done.
Total 3 (delta 0), reused 0 (delta 0)
To https://github.com/wizayn/Game131.git
   308237d..ed97f65  master -> master

C:\Users\svc-student\Desktop\Development\Game131>echo git clone https://github.com/wizayn/Game131.git > initializer.bat

C:\Users\svc-student\Desktop\Development\Game131>git add Initializer.bat

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Initializer second commit"
[master 9a4e219] Initializer second commit
 Committer: svc-student <svc-student@student.directory.jccc>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly:

    git config --global user.name "Your Name"
    git config --global user.email you@example.com

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 1 file changed, 1 insertion(+), 1 deletion(-)

C:\Users\svc-student\Desktop\Development\Game131>git push
Counting objects: 3, done.
Delta compression using up to 16 threads.
Compressing objects: 100% (2/2), done.
Writing objects: 100% (3/3), 345 bytes | 345.00 KiB/s, done.
Total 3 (delta 0), reused 0 (delta 0)
To https://github.com/wizayn/Game131.git
   ed97f65..9a4e219  master -> master

C:\Users\svc-student\Desktop\Development\Game131>echo git config user.name wrobert8 > initializer.bat

C:\Users\svc-student\Desktop\Development\Game131>echo config user.email wrobert8@stumail.jccc.edu > initializer.bat

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Third Initializer commit"
On branch master
Your branch is up to date with 'origin/master'.

Changes not staged for commit:
        modified:   Initializer.bat

no changes added to commit

C:\Users\svc-student\Desktop\Development\Game131>add initializer
'add' is not recognized as an internal or external command,
operable program or batch file.

C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Third Initializer commit"
On branch master
Your branch is up to date with 'origin/master'.

Changes not staged for commit:
        modified:   Initializer.bat

no changes added to commit

C:\Users\svc-student\Desktop\Development\Game131>git add Initializer.bat

C:\Users\svc-student\Desktop\Development\Game131>status
'status' is not recognized as an internal or external command,
operable program or batch file.

C:\Users\svc-student\Desktop\Development\Game131>git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git reset HEAD <file>..." to unstage)

        modified:   Initializer.bat


C:\Users\svc-student\Desktop\Development\Game131>git commit -m "Third Initializer commit"
[master 4037bf2] Third Initializer commit
 Committer: svc-student <svc-student@student.directory.jccc>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly:

    git config --global user.name "Your Name"
    git config --global user.email you@example.com

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 1 file changed, 1 insertion(+), 1 deletion(-)

C:\Users\svc-student\Desktop\Development\Game131>git push
Counting objects: 3, done.
Delta compression using up to 16 threads.
Compressing objects: 100% (2/2), done.
Writing objects: 100% (3/3), 342 bytes | 342.00 KiB/s, done.
Total 3 (delta 0), reused 0 (delta 0)
To https://github.com/wizayn/Game131.git
   9a4e219..4037bf2  master -> master

C:\Users\svc-student\Desktop\Development\Game131>helo
'helo' is not recognized as an internal or external command,
operable program or batch file
