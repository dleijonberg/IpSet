# IpSet - Network IP quickset tool

Since I work on a lot of different places, such as 
factories and offices, where I am mostly needed to use 
static IP-addresses to communicate with equipment 
and hardware, I got tired of changing IP-address 
through windows dialogs.

I have tried and used existing software for changing 
and saving IP-settings, but I figured I would try
to make my own tool for this purpose.


IpSet is written in C# with .NET Framework 4.7.2,
and is using WMI (Windows Management Instrumentation)
for getting and setting network adapter configuration.

