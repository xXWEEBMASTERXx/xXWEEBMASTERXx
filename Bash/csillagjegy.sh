#!/bin/bash

if [ "$#" != 2 ]
then
    echo "HASZNALAT: ./csillagjegy.sh <honap> <nap>"
    exit 1
fi

case $1 in
    "Március")
	if [ "$2" -ge 21 ] && [ "$2" -le 31 ]
	then
	    echo "Kos"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Halak"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	    fi;;
    "Április")
	if [ "$2" -ge 21 ] && [ "$2" -le 30 ]
	then
	    echo "Bika"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Kos"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "Május")
	if [ "$2" -ge 21 ] && [ "$2" -le 31 ]
	then
	    echo "Ikrek"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Bika"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "Június")
	if [ "$2" -ge 21 ] && [ "$2" -le 30 ]
	then
	    echo "Rák"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Ikrek"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "Július")
	if [ "$2" -ge 21 ] && [ "$2" -le 31 ]
	then
	    echo "Oroszlán"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Rák"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "Augusztus")
	if [ "$2" -ge 21 ] && [ "$2" -le 31 ]
	then
	    echo "Szűz"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Oroszlán"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "Szeptember")
	if [ "$2" -ge 21 ] && [ "$2" -le 30 ]
	then
	    echo "Mérleg"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Szűz"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "Október")
	if [ "$2" -ge 21 ] && [ "$2" -le 31 ]
	then
	    echo "Skorpió"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Mérleg"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "November")
	if [ "$2" -ge 21 ] && [ "$2" -le 30 ]
	then
	    echo "Nyilas"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Skorpió"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "December")
	if [ "$2" -ge 21 ] && [ "$2" -le 31 ]
	then
	    echo "Bak"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Nyilas"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "Január")
	if [ "$2" -ge 21 ] && [ "$2" -le 31 ]
	then
	    echo "Vízöntő"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Bak"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
    "Február")
	if [ "$2" -ge 21 ] && [ "$2" -le 31 ]
	then
	   echo "Halak"
	elif [ "$2" -ge 1 ] && [ "$2" -le 20 ]
	then
	    echo "Vízöntő"
	else
	    echo "Hibás dátum!" > /dev/stderr
	    exit 1
	fi;;
esac