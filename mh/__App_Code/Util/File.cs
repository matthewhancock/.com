using System;
using System.IO;
using System.Threading.Tasks;

namespace mh.Util
{
    /// <summary>
    /// Summary description for File
    /// </summary>
    public static class File
    {
        public static async Task<string> LoadToString(string RelativePath)
        {
            string text = null;
            var filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, RelativePath);
            using (var sr = new StreamReader(filename))
            {
                text = await sr.ReadToEndAsync();
            }
            return text;
        }
        public static async Task<byte[]> LoadToBuffer(string RelativePath)
        {
            byte[] buffer = null;
            var filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, RelativePath);
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (var ms = new MemoryStream())
                {
                    await fs.CopyToAsync(ms);
                    buffer = ms.ToArray();
                }
            }
            return buffer;
        }
    }
}