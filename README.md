when_changed
============

Runs a Command when a file changes (Windows only)

usage:
when_changed (file path) (command) (optional-parameters)

when_changed C:\somedir\foo.txt myapp.exe
when_changed C:\somedir\*.txt myapp.exe
when_changed C:\somedir\**.txt myapp.exe
when_changed C:\somedir\* myapp.exe
when_changed C:\somedir\** myapp.exe
when_changed fileincurrentdir.txt myapp.exe
when_changed C:\somedir\foo.txt myapp.exe bar wibble 123
when_changed C:\somedir\*.txt mybuildapp.exe $FullPath
when_changed C:\somedir\*.txt mybuildapp.exe $Name

Notes:
- Press 'F' to force the command to run.
- Recursive: The search is recursive if the filename contains a double-asterisk ** (wildcards in directory names not supported.)
- The utility will wait for the command to exit before running it again.
- The utility will will re-run the command if file changes whilst command is running.
- (file path) must be a file path with wildcards -- not a directory.
- Beware of creating an infinite loop (if command output creates changes which match the trigger)!

- A command parameter of "$FullPath" (case insensitive) will be substituted for the fully qualified path of affected file or directory when executing the command.
- A command parameter of "$Name" (case insensitive) will be substituted for the name of the affected file or directory.

feedback to: blamey.ben (at) gmail.com

See http://benblamey.com/code for binaries.
