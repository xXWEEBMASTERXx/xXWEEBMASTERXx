#!/bin/bash

error=0
for i in $@
do
    case $i in
	"-h"|"--help")
	echo "HASZNALAT: ./konyvtar.sh [-p | --pwd] | <konyvtar1> <konyvtar2> ...";;
    "-p"|"--pwd")
	pwd;;
    *)
	if [ -e "$i" ]
	then
	    echo "$i: már létezik" > /dev/stderr
	    error=1
	else
	    mkdir "$i"
	fi;;
    esac
done
if [ $error = 1 ]
then
    exit 1
else
    exit 0
fi