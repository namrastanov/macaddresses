using MacAddresses.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MacAddresses.Data.Entities;
using System.IO;
using System.Text;

namespace MacAddresses.Data.Services.DataServices
{
    public class MacAddressService : Disposable, IMacAddressService
    {
        private static object lockObject = new object();
        public int Add(IList<MacAddress> macs)
        {
            try
            {
                var count = 0;
                foreach (var mac in macs)
                {
                    if (SaveToFile(mac)) count++;
                }
                return count;
            } catch (Exception e)
            {
                //TODO log errors
                return 0;
            }
        }

        public bool SaveToFile(MacAddress mac)
        {
            var filePath = Utils.GetApplicationPath() + $"{mac.Value[0]}.txt";
            lock (lockObject)
            {
                try
                {
                    var fileContent = GetFileContent(filePath);
                    if (fileContent != null && fileContent.Length > 0)
                    {
                        var existMacValues = new List<string>();
                        existMacValues.AddRange(fileContent.ToString().Split(','));
                        if (existMacValues.Contains(mac.Value)) return true;
                        existMacValues.Add(mac.Value);
                        existMacValues = existMacValues.OrderBy(x => x).ToList();
                        var dataToSave = string.Join(",", existMacValues);
                        File.WriteAllText(filePath, dataToSave);
                    }
                    else
                    {
                        File.AppendAllText(filePath, mac.Value);
                    }
                    return true;
                } catch (Exception e)
                {
                    //TODO log errors
                    return false;
                }
            }
        }

        private StringBuilder GetFileContent(string pathToFile)
        {
            var result = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        result.Append(line);
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                //TODO log errors
                return null;
            }
        }
    }
}