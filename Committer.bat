@echo off

set commitMessage=%~1

git add .\

git commit -m %commitMessage%

git push
