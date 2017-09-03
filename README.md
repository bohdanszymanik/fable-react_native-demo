# Fable on React Native demo

This is a demo application for React Native development in F# using Fable.

If you want to try it out then please do the following:

### Make sure FSharp is installed

Make sure that the FSharp compiler is properly installed on your operating system:
  * [on Windows](http://fsharp.org/use/windows/)
  * [on Mac OS X](http://fsharp.org/use/mac/)
  * [on Linux](http://fsharp.org/use/linux/)

### Make sure React Native works

* Install the Ionide [VS Code extension for F#](https://github.com/ionide/ionide-vscode-fsharp)
* Install the [VS Code extension for React Native](https://github.com/Microsoft/vscode-react-native)
* Go to https://facebook.github.io/react-native/ and do all steps of the [getting started tutorial](https://facebook.github.io/react-native/docs/getting-started.html#content)
* At this point you should have the default Javascript React Native "Hello World" running

### Running F# code on React Native

* Pull latest master
* Open Android Simulator (using either the emulator command or the Android SDK Manager) or connect a device in debug mode via USB
* Run `build.cmd debug` from command prompt
* Go to android device simulator and you should see something like

![Device Running](http://www.navision-blog.de/images/nightwatchapp.gif)

* Go to the F# source in VS Code make a change and save the file
* Fable watch should pick up this change automatically and compile it
* Go to android device simulator and press r+r - change should be visible

This could look like:

![Hot loading](http://www.navision-blog.de/images/hotloading.gif)


## Error handling

### Unauthorized device

If you run `build.cmd debug` and it compiles everything, but nothing happens... go to the packager
output and search for hints.
One pitfall might be "Skipping device, Device is UNAUTHORIZED". With
```
adb devices
```
you can see the list of devices, probably one of them is marked as UNAUTHORIZED. First,
try
```
adb kill-server
```
and try it again. If it doesn't help, you can push the public key onto the device again:
```
cd ~/.android && adb push adbkey.pub /data/misc/adb/adb_keys
```
After rebooting the device, access should be granted again.

### Licenses not accepted 

If the above does not work, and still nothing happens after it compiles everything, the licenses may need to be accepted on your computer. To accept the licenses run the following commands for your platform

On a Mac run the following 
```
$ANDROID_HOME/tools/bin/sdkmanager --update
```
On Windows run the following 
```
“%ANDROID_HOME%\tools\bin\sdkmanager” --update
```

Re-run the build script and everything should work.

