@echo off

set commitMessage=%~1

git commit -m %commitMessage%
echo Message %commitMessage%