#!/bin/bash

if [ "$1" = "-h" ] || [ "$1" = "--help" ]
then
    echo "HASZNALAT: ./datum.sh <datum1> <datum2>"
fi
if [ "$#" -gt 2 ] || [ "$#" -le 0 ] || [ "$#" = 1 ]
then
    echo "HASZNALAT: ./datum.sh <datum1> <datum2>"
    exit 1
else
    regex="^[12][0-9]{3}\.(0[1-9]|1[012])\.(0[1-9]|[12][0-9]|3[0-1])"
    
    DATUM1="$1"
    DATUM2="$2"

    if [[ $DATUM1 =~ $regex ]]
    then
        masod1=$(date -j -f %Y.%m.%d $DATUM1 +%s)
	    nap1=$(date -r $masod1 +%w)
        
    else
	    echo "Hibas datum!" > /dev/stderr
	    exit 1
    fi

    if [[ $DATUM2 =~ $regex ]]
    then
        masod2=$(date -j -f %Y.%m.%d $DATUM2 +%s)
	    nap2=$(date -r $masod2 +%w)
    else
	    echo "Hibas datum!" > /dev/stderr
	    exit 1
    fi
    masodkulombsegg=$((masod2-masod1))
    days=$((masodkulombsegg/86400))
    work=0
    day=$masod1
    days=$(($days + 1))
    for (( i=0; i < days; i++ ))
    do
        x=$(date -r $day +%w)
        if [ $x = 0 ] || [ $x = 6 ]
        then
            work=$((work+1))
        fi
        day=$(($day + 86400))
    done
    workdays=$((days-work))
    if [ $workdays -le 0 ]
    then
        echo 0
        exit 0
    else
        echo $workdays
        exit 0
    fi
fi