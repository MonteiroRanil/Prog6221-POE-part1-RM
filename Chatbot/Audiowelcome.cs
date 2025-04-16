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
                SoundPlayer soundplayer = new SoundPlayer("C:\\Users\\lab_services_student\\Desktop\\Chatbot\\chatbot.wav");
                soundplayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't play audio: " + ex.Message);
            }
        }
    }
}
