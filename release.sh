#!/bin/sh
cp src/backlog/Program.cs release/backlog.cs
sed -i -e '1i#!/usr/bin/cs-script\' release/backlog.cs
chmod +x release/backlog.cs
cp doc/help.txt release/help.txt
cp install/* release