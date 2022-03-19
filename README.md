# Disable Windows Update
This solution allows you to turn off updates until you decide to go ahead with them.
The included window service monitors the "Windows Update Service" every few seconds to ensure it is stopped and disabled, and the control application allows you to turn Windows Updates back on when needed.

# Why would you want to stop Windows Update?
Windows 10 forces you to continually update even when you disable the Windows Update service.
In my experience, eventually updates fail, leaving computers & servers in a variable broken state. Several man hours are then required to repair the damage which costs me time, and because I bill per hour, it costs me money, and because I like to keep my commitments, it makes me look bad to my clients.
So I wrote this service to solve the "Microsoft Update" problem and save me money and ensure I can deliver things in a timely fashion without delays.

# Download
 [Windows Installer](https://github.com/krugertech/Disable-Windows-Update/tree/master/Binaries)

# Troubleshooting
Should you have trouble running the executable. Right click on the exe and click properties and uncheck the "Unblock" box and click OK. 
Alternatively, build your own release from the source code.

# Licensing
Free Software under the GPL License
