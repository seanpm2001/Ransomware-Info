// Start of script
// A script to de-activate Ransomware if the target server is no longer available
// Script is not yet functional
using System.Net.NetworkInformation;    
// Taken from https://stackoverflow.com/a/11804416 | slightly modified
public static bool PingHost(string nameOrAddress)
{
    bool pingable = false;
    Ping pinger = null;

    try
    {
        pinger = new Ping();
        PingReply reply = pinger.Send(nameOrAddress);
        pingable = reply.Status == IPStatus.Success;
    }
    catch (PingException)
    {
        // Discard PingExceptions and return false;
    }
    finally
    {
        if (pinger != null)
        {
            pinger.Dispose();
        }
    }

    return pingable;
    if pingable {
      return 0
    } else {
      return deactivate;
    }
}
public static int deactivate(String, str)
{
  Console.WriteLine("De-activating Ransomware, as server could not be reached");
  /* Script needs to go between here */
  // Scipt goes here
  /* Script needs to go between here */
}
public static void main(String, str)
{
  return PingHost;
}
// File info
// File type: C# source file (*.cs *.csx)
// File version: 1 (2022, Monday, August 22nd at 5:05 pm PST)
// Line count (including blank lines and compiler line): 52
// End of script
