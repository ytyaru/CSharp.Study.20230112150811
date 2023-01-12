#!/usr/bin/env bash
set -Ceu
#---------------------------------------------------------------------------
# C#の環境開発から学習まで。
# CreatedAt: 2023-01-12
#---------------------------------------------------------------------------
Run() {
	THIS="$(realpath "${BASH_SOURCE:-0}")"; HERE="$(dirname "$THIS")"; PARENT="$(dirname "$HERE")"; THIS_NAME="$(basename "$THIS")"; APP_ROOT="$PARENT";
	cd "$HERE"
#	csc -nologo Program.cs Sub.cs
#	csc -nologo *.cs -out:prog.exe
	csc -nologo -recurse:*.cs -nullable:enable -langversion:latest
	mono Program.exe
}
Run "$@"
