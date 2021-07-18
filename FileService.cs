using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class FileService
    {
        /// <summary>
        /// Read file at filepath 
        /// </summary>
        /// <param name="filepath">filepath to pull</param>
        /// <returns>Returns string[] containing all the lines of the file</returns>
        public static async Task<string[]> readFile(string filepath)
        {
            await Task.Run(() => {
                try
                {
                    return File.ReadAllLines(filepath);
                }
                catch (Exception e)
                {
                    return null;
                }
            });
            return null;
           
        }

        /// <summary>
        /// Writes a lines array to file
        /// </summary>
        /// <param name="filepath">The file</param>
        /// <param name="lines">The lines array</param>
        /// <returns>True if file is written</returns>
        public static async Task<bool> WriteFile(string filepath,string[] lines)
        {
            await Task.Run(() => {
                try
                {
                    File.WriteAllLines(filepath, lines);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            });
            return false;
        }

        /// <summary>
        /// Verify that a file is indeed a pub key file
        /// </summary>
        /// <param name="filepath">The file</param>
        /// <returns>True if verified</returns>
        public static async Task<bool> VerifyPublicKeyFile(string filepath)
        {
            await Task.Run(() => {
                try
                {
                    string[] lines = File.ReadAllLines(filepath);

                    if ((lines[0] == "-----BEGIN PGP PUBLIC KEY BLOCK-----") && (lines[lines.Length - 1] == "-----END PGP PUBLIC KEY BLOCK-----"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            });
            return false;
        }
    }
}
