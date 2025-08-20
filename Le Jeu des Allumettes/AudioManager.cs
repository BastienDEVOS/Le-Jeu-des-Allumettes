using System;
using NAudio.Wave;

namespace Le_Jeu_des_Allumettes
{
    public static class SoundManager
    {
        private static WaveOutEvent musicOutput;
        private static AudioFileReader musicReader;

        private static float musicVolume = 1f;
        private static float effectsVolume = 1f;

        public static float MusicVolume
        {
            get => musicVolume;
            set
            {
                musicVolume = Math.Clamp(value, 0f, 1f);
                if (musicReader != null) musicReader.Volume = musicVolume;
            }
        }

        public static float EffectsVolume
        {
            get => effectsVolume;
            set => effectsVolume = Math.Clamp(value, 0f, 1f);
        }

        public static void PlayMusic(string filePath)
        {
            StopMusic();

            musicReader = new AudioFileReader(filePath) { Volume = musicVolume };
            musicOutput = new WaveOutEvent();
            musicOutput.Init(musicReader);

            musicOutput.PlaybackStopped += (s, e) =>
            {
                musicReader.Position = 0; // relance depuis le début
                musicOutput.Play();
            };

            musicOutput.Play();
        }

        public static void StopMusic()
        {
            musicOutput?.Stop();
            musicOutput?.Dispose();
            musicReader?.Dispose();
            musicOutput = null;
            musicReader = null;
        }

        public static void PlayEffect(string filePath)
        {
            // Chaque effet a son propre lecteur indépendant
            var reader = new AudioFileReader(filePath) { Volume = effectsVolume };
            var output = new WaveOutEvent();
            output.Init(reader);
            output.Play();

            // Nettoyage après lecture
            output.PlaybackStopped += (s, e) =>
            {
                reader.Dispose();
                output.Dispose();
            };
        }
    }
}
