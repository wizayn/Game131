@echo off

echo You are about to revert all changes to working directory since last commit. Y to continue, N to cancel

set /p input=Y or N
IF %input%=="Y"
git reset --hard
IF %input%=="N"
EXIT /B
