using System;
using System.IO;
using GameHelper.Global;

namespace GameHelper.Games.Sims
{
    public abstract class SimsBase
    {
        private string _version;
        private string _baseFolder;
        private string _modFolder;
        private string _modFileFilter;

        public SimsBase(string version)
        {
            _version = version;
            InitValues();
        }

        private void InitValues()
        {
            _baseFolder = Global.Common.ReWriteFoldersIfDefault(Properties.Settings.Default["Sims" + _version + "BaseFolder"]?.ToString());
            _modFolder = Global.Common.ReWriteFoldersIfDefault(Properties.Settings.Default["Sims" + _version + "ModFolder"]?.ToString());
            _modFileFilter = Global.Common.ReWriteFoldersIfDefault(Properties.Settings.Default["Sims" + _version + "ModFileFilter"]?.ToString());
        }

        private string GetCompleteModFolder()
        {
            return Path.Combine(_baseFolder, _modFolder);
        }

        private string GameVersion
        {
            get => _version;
            set => _version = value;
        }

        public virtual void MoveModsToFolder(string sourceFolder)
        {
            foreach(var file in FileOperations.GetFileNamesByFilter(sourceFolder, _modFileFilter))
            {
                FileOperations.DeleteFile(Path.Combine(GetCompleteModFolder(), file.Name));
                FileOperations.MoveFile(file, GetCompleteModFolder());
            }
        }
    }
}
