

set firstVal=%~2
set secondVal=%~4
set thirdVal=%~6

IF "%1"=="username" goto userfirst
IF "%1"=="email" goto emailfirst
goto cloneRepo

:userfirst
set username=%~2
IF"%3"=="email" (
    set email=%~4
    set RepoAddress=%~6
)   else (
        set cloneRepo=%~4
        set email=$~6
)
goto display

:emailfirst
set email=%~2
IF "%3"=="username" (
    set username=%~4
    set RepoAddress=%~6
) else (
    set RepoAddress=%~4
    set username=%~6
)
goto display

:cloneRepo
set RepoAddress=%~2
IF "%3"=="RepoAddress" (
    set RepoAddress=%~4
    set email=%~6
)   else (
        set email=%~4
        set RepoAddress=$%~6
)
goto display

:display
echo username %username%
echo email %email%
echo Repo Address %RepoAddress%


git clone RepoAddress

git config user.name username

git config user.email email
