main purpose: build docker containers reliably

developed in .net/mono

binaries are in build folder

on linux:
first run './wb fetch' to download files from the slices repo
it will create .wb folder in the same directory

other commands:

./wb check will check if a particular image can be built

./wb make will create a output file, if -d specified then Dockerfile will be created, -sh - a shell file

./wb test will create a dockerfile and run docker to build a container

