#!/bin/bash

trap 'rm tmp' EXIT

if mini-redis-server; then
    mv output
else
    mv log
    exit 1 #Exit with failure
fi

exit 0 #Exit with success