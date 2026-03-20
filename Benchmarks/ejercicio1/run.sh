#!/bin/bash

echo "Running Python implementation..."
cd python
python3 app.py

echo "Running Node.js implementation..."
cd ../node
node index.js

echo "Running Go implementation..."
cd ../go
go run main.go

echo "Running Dotnet implementation..."
cd ../dotnet
dotnet run

echo "Running Java implementation..."
cd ../java
javac main.java
java main

echo "All implementations have been executed."