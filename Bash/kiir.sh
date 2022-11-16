#!/bin/bash

if [ "$1" = "-h" ] || [ "$1" = "--help" ]
then
    echo "HASZNALAT: ./kiir.sh <fajlnev>"
    exit
fi
if [ -n "$1" ]
then
    F=$1

else
    read F
fi
if [ -f "$F" ]
then
    cat $F
    exit 0
else
    echo "Nincs ilyen fajl." >/dev/stderr
    exit 1
fi