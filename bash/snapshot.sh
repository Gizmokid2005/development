#/bin/sh

# Variables
FOLDER="path/to/folder"
SCREENNAME='normal'
PIDFILE='serverprocess.pid'
WINDOWNAME='snapshot'
YEAR=$(date +%y)
WEEK=$(date +%V)

# Nav to proper folder
cd "$FOLDER"

# Get the pid of the server.
PID=$(cat "$PIDFILE")

echo "Downloading latest snapshot."
for c in z y x w v u t s r q p o n m l k j i h g f e d c b a
do
    # Version number.
    V="${YEAR}w${WEEK}${c}"

    # Try to download the snapshot.
    wget -q "http://s3.amazonaws.com/Minecraft.Download/versions/$V/minecraft_server.$V.jar" 

    # Check if we found a snapshot.
    if [[ -f "minecraft_server.$V.jar" ]]
    then
        echo "Found snapshot version $V."
        echo "Current version is $(cat VERSION)."

        # Check if the downloaded snapshot is different from the one we already had.
        if [[ $(cat VERSION) != $V ]];
        then
            echo "Latest is different from current version, so we're restarting the server."

            # Store the new version number.
            echo $V > VERSION

            # Move it to the server jar.
            mv "minecraft_server.$V.jar" "minecraft_server.jar"

            # If the process is running, stop it.
            if kill -0 $PID 2> /dev/null;  
            then
                # Send the stop command.
                screen -S "$SCREENNAME" -p "$WINDOWNAME" -X stuff 'stop'`echo -ne '\015'`
                
                # Wait for it to exit.
                while kill -0 $PID 2> /dev/null; do sleep 0.5; done
            fi

            # Start the server.
            screen -S "$SCREENNAME" -p "$WINDOWNAME" -X stuff './run.sh'`echo -ne '\015'`

            # Wait for a bit for it to start, then save the PID.
            sleep 1
            ps ax | grep 'minecraft_server.jar' | grep java | head -n1 | cut -c1-5 > $PIDFILE
        else
            echo "We're already running the snapshot, no need to do anything."

            # We already have this version, just remove it.
            rm "minecraft_server.$V.jar"
        fi

        # Stop looking for more versions, we already found the latest one.
        break
    fi
done

