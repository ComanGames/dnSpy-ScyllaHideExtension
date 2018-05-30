using System;
using ReadingFromIni;

namespace ParsingIniFile
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("STart WRiting to file");

			ScyllaHideSettings settings = new ScyllaHideSettings();
			Console.WriteLine($"Current selected section {settings.CurrentSelectedSection.SectionName}");

			for (int i = 0; i < settings.Sections.Count; i++)
				Console.WriteLine(settings.Sections[i].SectionName);

			settings.Sections.Add(new ScyllaHideSettingsSection("NewSection"));


			settings.SaveAllSettings();
			settings = new ScyllaHideSettings();

			Console.WriteLine();
			Console.WriteLine($"Current selected section {settings.CurrentSelectedSection.SectionName}");

			for (int i = 0; i < settings.Sections.Count; i++)
				Console.WriteLine(settings.Sections[i].SectionName);




			Console.WriteLine("Done Writing to file");
			Console.ReadKey();

		}
	}
}
