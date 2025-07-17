namespace Le_Jeu_des_Allumettes
{
    // AudioManager.cs
    public static class AudioManager
    {
        public static float MusicVolume = 1.0f;           // Volume musique (0.0 à 1.0)
        public static float SoundEffectsVolume = 1.0f;    // Volume effets (0.0 à 1.0)

        public static void ApplyMusicVolume()
        {
            if (frmAccueil.musicPlayer != null)
                frmAccueil.musicPlayer.Volume = MusicVolume;
        }
    }

}