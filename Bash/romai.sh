#!/bin/bash

if [ "$#" -ne 1 ]; then
    echo "Hibás szám"
    exit 1
fi
case $1 in
    1)
        echo "I"
        ;;
    5)
        echo "V"
        ;;
    10)
        echo "X"
        ;;
    50)
        echo "L"
        ;;
    100)
        echo "C"
        ;;
    500)
        echo "D"
        ;;
    1000)
        echo "M"
        ;;
esac