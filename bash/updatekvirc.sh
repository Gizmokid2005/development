#Get to correct dir
cd /c/kvirc/
#Check to see if we're on the correct version
if [ "$(svn info | grep 'Revision')" = "$(svn info https://svn.kvirc.de/svn/trunk/kvirc | grep 'Revision')" ];
#We are, good. Let's leave.
then exit
#Looks like we need to update, let's do that!
#else echo 'NOMATCH'
else svn up && echo 'UPDATED' && cd build/ && mingw32-make.exe -j install
fi