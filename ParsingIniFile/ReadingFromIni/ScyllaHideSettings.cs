using System.Collections.Generic;

namespace ReadingFromIni
{
	public class ScyllaHideSettings
	{
		private const string FileName = "scylla_hide.ini";
		private const string CurrentProfileSection = "SETTINGS";
		private const string SelectedProfileSetting = "CurrentProfile";

		private IniFile _iniFile;
		public List<ScyllaHideSettingsSection> Sections;
		public ScyllaHideSettingsSection CurrentSelectedSection;

		public ScyllaHideSettings()
		{
			_iniFile = new IniFile(FileName);
			Sections = GetAllSections();
			CurrentSelectedSection = GetCurrentSelectedSection(Sections);
			
		}

		public void SaveAllSettings()
		{
			SaveCurrentSelectedSection();
			SaveAllSections();
		}


		private void SaveCurrentSelectedSection()
		{
			_iniFile.Write(SelectedProfileSetting,CurrentSelectedSection.SectionName, CurrentProfileSection);
		}

		private void SaveAllSections()
		{

			for (int i = 0; i < Sections.Count; i++)
			{
				Sections[i].SaveSectionSettings(_iniFile);
			}

		}


		private ScyllaHideSettingsSection GetCurrentSelectedSection(List<ScyllaHideSettingsSection> sections)

		{
			string name = _iniFile.Read(SelectedProfileSetting, CurrentProfileSection);
			ScyllaHideSettingsSection result = null;
			for (int i = 0; i < sections.Count; i++)
			{
				if (sections[i].SectionName == name)
					result = sections[i];

			}

			if (result != null)
				return result;

			return sections[0];

		}

		private List<ScyllaHideSettingsSection> GetAllSections()
		{

			List<ScyllaHideSettingsSection> result = new List<ScyllaHideSettingsSection>();
			string[] sectionNames = _iniFile.GetSectionNames();

			for (int i = 0; i < sectionNames.Length; i++)
			{
				if (CurrentProfileSection != sectionNames[i])
				{
					ScyllaHideSettingsSection section = new ScyllaHideSettingsSection(sectionNames[i]);
					section.ReadSectionSettings(_iniFile);
					result.Add(section);
				}
			}

			return result;
		}


	}
}