#!/bin/bash

magassag=20
star=1

for ((i=0; i<$magassag; i++))
{
	space=$magassag-$i
	for ((j=0; j<$space; j++))
	{
		echo -n " "
	}
	for ((h=0;h<$star; h++))
	{
		echo -n "*"
	}
	echo
	((star+=2))
	echo $star
}
torzs=$magassag-1
for ((j=0; j<$torzs; j++))
	{
		echo -n " "
	}
echo "mWm"
for ((j=0; j<$torzs; j++))
	{
		echo -n " "
	}
echo "mWm"
for ((j=0; j<$torzs; j++))
	{
		echo -n " "
	}
echo "mWm"