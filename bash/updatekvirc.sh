#Get to correct dir
cd /c/kvirc/
#Declare Variables
currentver=$(svn info | grep 'Revision' | grep -oE '[0-9]+')
svnver=$(svn info https://svn.kvirc.de/svn/trunk/kvirc | grep 'Revision' | grep -oE '[0-9]+')
#Check to see if we're on the correct version
if [ $currentver = $svnver ];
#We are, good. Let's leave.
then exit
#Looks like we need to update, let's do that!
else 	svn up && \
		echo 'UPDATED' && \
		cd build/ && \
		mingw32-make.exe -j install && \
		filename=$(/c/Program\ Files\ \(x86\)/NSIS/makensis.exe KVIrc.nsi | grep OutFile: | grep -oE '[^"]+.exe' | sed 's/.exe$//') && \
		/c/Program\ Files/7-Zip/7z.exe a -t7z $filename.7z $filename.exe
		#Generate ftp command file
		echo 'open <host>' > ftp.txt && \
		echo '<user>' >> ftp.txt && \
		echo '<pass>' >> ftp.txt && \
		echo 'cd public_html/KVIrc4_nightly'	>> ftp.txt && \
		echo 'mkdir r'$svnver >> ftp.txt && \
		echo 'quote SITE chmod 777 r'$svnver >> ftp.txt && \
		echo 'cd r'$svnver >> ftp.txt && \
		echo 'put '$filename'.exe' >> ftp.txt && \
		echo 'put '$filename'.7z' >> ftp.txt && \
		echo 'quit' >> ftp.txt && \
		echo 'exit' >> ftp.txt && \
		ftp.exe -s:ftp.txt
		rm ftp.txt
fi
exit