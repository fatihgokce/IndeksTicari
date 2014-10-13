using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace Indeks.Views
{
  public static class LogWrite
  {
    public static void Write(Exception exc)
    {
      StreamWriter sw=default(StreamWriter);
      try
      {       
        string path = Path.Combine(Application.StartupPath, @"Log\LogFile.txt");
        CreateFileDirectory();
        FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
        sw = new StreamWriter(fs);
        sw.WriteLine(DateTime.Now);
        sw.WriteLine(exc.Message);
        sw.Flush();
        sw.Close();
        fs.Close();
        if (exc.InnerException != null)
        {
          Write(exc.InnerException);
        }              
      }
      catch
      {
      }

    }
    static void CreateFileDirectory()
    {
      string path = Path.Combine(Application.StartupPath, @"Log\LogFile.txt");    

      if (!Directory.Exists(Path.Combine(Application.StartupPath, "Log")))
        Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Log"));

      if (!File.Exists(path))
      { 
        FileStream fs= File.Create(path);
        fs.Close();
      }
    }
  }
}
