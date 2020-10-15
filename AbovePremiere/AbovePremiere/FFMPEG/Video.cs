using System;
using System.Collections.Generic;
using System.Text;

namespace AbovePremiere.FFMPEG
{
    static class Video
    {
        public static void obtenerResolucion(string path) 
        {
        }
        public static void extraerAudio(string path) 
        {
            string strCmdText;
            string pathDestino;
            pathDestino = (path.Remove(path.Length-5, 5)) + "-audio.mp3";
            strCmdText = "/C ffmpeg -i "+ path +" -f mp3 -vn "+pathDestino;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = strCmdText;
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void eliminarAudio(string path) 
        {
            string strCmdText;
            string pathDestino;
            pathDestino = (path.Remove(path.Length - 5, 5)) + "-no-audio.mp4";
            strCmdText = "/C ffmpeg -i "+ path +" -c copy -an "+pathDestino;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = strCmdText;
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void cambiarResolucion() { }

        public static void cambiarFormato() { }

        public static void extraerImagenes(string path, string frames)
        {
            if (!(frames.Equals("1") || frames.Equals("2") || frames.Equals("3") || frames.Equals("4") || frames.Equals("5")))
            {
                frames = "1";
            }
            string strCmdText;
            string pathDestino;
            pathDestino = (path.Remove(path.Length - 5, 5)) + "-img%04d.jpg";
            strCmdText = "/C ffmpeg -i " + path + " -vf fps="+frames+" " + pathDestino;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = strCmdText;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
