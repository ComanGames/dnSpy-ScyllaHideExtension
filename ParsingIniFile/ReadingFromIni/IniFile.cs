using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ReadingFromIni
{
	public class IniFile
	{
			string Path;
			string EXE = Assembly.GetExecutingAssembly().GetName().Name;

			[DllImport("kernel32", CharSet = CharSet.Unicode)]
			static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

			[DllImport("kernel32", CharSet = CharSet.Unicode)]
			static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

			[DllImport("kernel32")]
			static extern int GetPrivateProfileString(int Section, string Key, string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result, int Size, string FileName);

			public IniFile(string IniPath = null)
			{
				Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
			}
			public string[] GetSectionNames()
			{
				for (int maxsize = 500; true; maxsize *= 2)
				{
					byte[] bytes = new byte[maxsize];
					int size = GetPrivateProfileString(0, "", "", bytes, maxsize, Path);

					if (size < maxsize - 2)
					{
						string Selected = Encoding.ASCII.GetString(bytes, 0, size - (size > 0 ? 1 : 0));
						return Selected.Split(new char[] { '\0' });
					}
				}
			}

			public string Read(string Key, string Section = null)
				{
				var RetVal = new StringBuilder(255);
				GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
				return RetVal.ToString();
			}

			public void Write(string Key, string Value, string Section = null)
			{
				WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
			}

			public void DeleteKey(string Key, string Section = null)
			{
				Write(Key, null, Section ?? EXE);
			}

			public void DeleteSection(string Section = null)
			{
				Write(null, null, Section ?? EXE);
			}

			public bool KeyExists(string Key, string Section = null)
			{
				return Read(Key, Section).Length > 0;
			}
		}
}