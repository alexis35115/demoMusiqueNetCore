using NAudio.Wave;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    /// <summary>
    /// Classe qui encapsule https://github.com/naudio/NAudio
    /// </summary>
    public class LecteurMusique : ILecteurMusique
    {
        public void Jouer(string nomMusique)
        {
            // Référence de l'exemple https://github.com/naudio/NAudio/blob/master/Docs/PlayAudioFileConsoleApp.md

            string file = $"{Directory.GetCurrentDirectory()}\\sons\\{nomMusique}";
            using var audioFile = new AudioFileReader(file);
            using var outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();
            while (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
