using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Chatbot
{
    internal class Audiowelcome
    {
        public static void welcome()
        {
            try
            {
                SoundPlayer soundplayer = new SoundPlayer("C:\\Users\\lab_services_student\\Desktop\\Prog6221-POE-part1-RM\\Chatbot\\chatbot.wav");
                soundplayer.Play(); //file path for audio
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't play audio: " + ex.Message);//exception if the audio cant play
            }
        }
    }
}
