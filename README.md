# DC-Reader
Console app that reads file name and date for selected file extension in specific folder. 

This app was made for SMART PSS Program. Smart PSS is monitoring system. When you download specific recording 
program generates .asf or .avi file with very long file name which includes: name of camera, beginning and ending datetime, etc.
DC-Reader extract specific file name and date to .txt file. 
When you download many of PSS recordings at the end of month you have 200-300 recordings to deal with. Extracting name and date by hand 
is very uproductive thats why I came up with this solution.


# Manual
1. Type file extension. < for example asf without dot.
2. Type path to top folder. < Function will search all files in src folder tree.
3. Type path for output text file.
4. Type output txt file name.
