using System;
using System.Runtime.Serialization;
using Services;
using ShootingGallery;

namespace DefaultNamespace.Level
{
    public class LevelService : IService, IDisposable
    {
        private Encounter[] _encounters;
        
        public LevelService(Encounter[] encounters) => _encounters = encounters;

        public Action OnEncounterComplete;
        
        public void Setup()
        {
            foreach (var encounter in _encounters)
            {
                encounter.Setup();
                encounter.OnEncounterCompleted += EncounterCompleted;
            }
        }
        
        private void EncounterCompleted() => OnEncounterComplete?.Invoke();

        public void Dispose()
        {
            foreach (var encounter in _encounters)
            {
                encounter.OnEncounterCompleted -= EncounterCompleted;
            }
        }
    }
}