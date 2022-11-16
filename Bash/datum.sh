#!/bin/bash

if [ "$1" == "-h" ] || [ "$1" == "--help" ]
then
    echo "HASZNALAT: ./datum.sh <datum1> <datum2>"
fi
if [ "$#" -gt 2 ] || [ "$#" -le 1 ]
then
    echo "HASZNALAT: ./datum.sh <datum1> <datum2>" > /dev/stderr
    exit
else
    regex="^[1-2][0-9][1-2][1-2]\.[0-2][0-9]\.[0-3][0-9]"
    
    DATUM1="$1"
    DATUM2="$2"

    if [ $DATUM1 =~ $regex ]
    then
        masod1=$(date -j -f %Y.%m.%d $DATUM1 +%s)
	    nap1=$(date -r $masod1 +%w)
    else
	    echo "Hibas datum!" > /dev/stderr
	    exit
    fi

    if [ $DATUM2 =~ $regex ]
    then
        masod2=$(date -j -f %Y.%m.%d $DATUM2 +%s)
	    nap2=$(date -r $masod2 +%w)
    else
	    echo "Hibas datum!" > /dev/stderr
	    exit
    fi
    if [ $DATUM1 -ge $DATUM2]
    then
        echo "$DATUM2 nagyobb"
    else
        echo "$DATUM1 nagyobb"
    fi
fi