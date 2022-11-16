#!/bin/bash

if [ "$#" = 0 ]
then
    pass
fi

gyok () {
    x=$(echo "scale=4;sqrt($1)" | bc)
    echo $x
}
gyok 16
gyok $1
masodfoku () {
    A=$1
    B=$2
    C=$3
    DR=`echo "scale=4; $B^2-4*$A*$C" | bc`
    if test $DR != 0
    then
        y=`echo "scale=4; (-1*$B+sqrt($DR)/(2*$A))" | bc`
        z=`echo "scale=4; (-1*$B-sqrt($DR)/(2*$A))" | bc`
        echo "x1="$y
        echo "x2="$z
    fi
}
masodfoku $1 $2 $3