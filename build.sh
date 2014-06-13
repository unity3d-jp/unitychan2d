#!/bin/bash

UNITY_APP_PATH=/Applications/Unity4.3.4/Unity.app/Contents/MacOS/Unity

UNITY_PACKAGE_NAME=UnityChan2D

[ ! -e $UNITY_APP_PATH ] && UNITY_APP_PATH=/Applications/Unity/Unity.app/Contents/MacOS/Unity

[ ! -d build ] && mkdir build

echo 'unitypackage 作成中'

$UNITY_APP_PATH -quit -batchmode -projectPath ${PWD} -exportPackage Assets/$UNITY_PACKAGE_NAME ProjectSettings/EditorBuildSettings.asset ProjectSettings/TagManager.asset build/$UNITY_PACKAGE_NAME.unitypackage

mkdir build/$UNITY_PACKAGE_NAME

tar -zxpf build/$UNITY_PACKAGE_NAME.unitypackage -C  build/$UNITY_PACKAGE_NAME

cp unitychan2D.png build/$UNITY_PACKAGE_NAME/.icon.png

cd build/$UNITY_PACKAGE_NAME

tar -zcpf ../$UNITY_PACKAGE_NAME.unitypackage .

cd ../../

rm -fr build/$UNITY_PACKAGE_NAME