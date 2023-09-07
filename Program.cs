using System;
using System.Text;

namespace mainProgram {

public static class osInfoGet {

    public static void getSystemInfo () {
        StringBuilder systemGather = new StringBuilder (string.Empty);
           
            systemGather.AppendFormat ("Operative System:{0} \n "  , Environment.OSVersion);
            systemGather.AppendFormat("Processor Architecture:  {0} \n" , Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            systemGather.AppendFormat("Processor Model:  {0} \n ", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            systemGather.AppendFormat("Processor Level:  {0} \n " , Environment.GetEnvironmentVariable("PROCESSOR_LEVEL"));
            systemGather.AppendFormat("SystemDirectory:  {0} \n", Environment.SystemDirectory);
            systemGather.AppendFormat("ProcessorCount:  {0} \n" , Environment.ProcessorCount);
            systemGather.AppendFormat("UserDomainName:  {0} \n"  , Environment.UserDomainName);
            systemGather.AppendFormat("UserName: {0} \n " , Environment.UserName);

    foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
    {
        try
        {
            systemGather.AppendFormat
            ($"Drive: {0}VolumeLabel: " + 
            "{1} DriveType: {2} DriveFormat: {3} " + 
            "TotalSize: {4} AvailableFreeSpace: {5} " +
             "\n",

              DriveInfo1.Name,
              DriveInfo1.VolumeLabel,
              DriveInfo1.DriveType, 
              DriveInfo1.DriveFormat, 
              DriveInfo1.TotalSize, 
              DriveInfo1.AvailableFreeSpace
            );
        }
        catch
        {}
    }



            Console.WriteLine(systemGather);
    }
public static class Program {
    public static void Main (string[] args) {
        getSystemInfo();
      }
    }
  }
}




