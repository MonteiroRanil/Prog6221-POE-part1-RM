using System;
using System.Collections.Generic;

namespace Chatbot
{
    internal class CyberKnowledge
    {
        static Random rnd = new Random(); // for randomizing responses

        public static string Response(string input)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            input = input.ToLower(); // Case-insensitive comparison

            // Repeat the last topic
            if (input.Contains("again") || input.Contains("repeat"))
            {
                if (!string.IsNullOrEmpty(memory.LastTopic))
                {
                    Console.WriteLine($"Sure {memory.UserName}, here's another tip about {memory.LastTopic}:");

                    // Call the same response again using the last topic
                    return Response(memory.LastTopic); 
                }
                else
                {
                    Console.WriteLine("There's nothing to repeat yet. Try asking about a topic like passwords or phishing.");
                    return "";
                }
            }


            if (input.Contains("thank you") || input.Contains("thanks"))
            {
                string emotionResponse = "";

                switch (memory.LastFeeling)
                {
                    case "anxious":
                        emotionResponse = "I'm glad I could help ease some of your worries.";
                        break;
                    case "curious":
                        emotionResponse = "It was fun exploring with you!";
                        break;
                    case "confused":
                        emotionResponse = "I'm happy to have helped clear things up for you.";
                        break;
                    default:
                        emotionResponse = "You're very welcome!";
                        break;
                }

                Console.WriteLine($"{emotionResponse} If you ever have more questions, {memory.UserName}, I'm here for you.");
                Console.ResetColor();
                return "";
            }

           
            if (input.Contains("worried") || input.Contains("scared") || input.Contains("anxious") || input.Contains("stress"))
            {
                memory.LastFeeling = "anxious";
                Console.WriteLine("It's completely understandable to feel that way. Scammers can be very convincing.");
                Console.WriteLine("Let me share some tips to help you stay safe. Would you like to learn about phishing, password safety, or safe browsing?");
                Console.ResetColor();
                return "";
            }
            else if (input.Contains("curious") || input.Contains("interested"))
            {
                memory.LastFeeling = "curious";
                Console.WriteLine("Great to hear you're curious! I can tell you more about password safety, phishing, or internet browsing. What would you like to start with?");
                Console.ResetColor();
                return "";
            }
            else if (input.Contains("frustrated") || input.Contains("confused"))
            {
                memory.LastFeeling = "confused";
                Console.WriteLine("I’m here to help. Cybersecurity can be a lot, but we’ll take it step-by-step.");
                Console.WriteLine("Would you like to start with passwords, phishing, or safe browsing?");
                Console.ResetColor();
                return "";
            }

            if (input.Contains("ask"))
            {
                Console.WriteLine("You can ask me about passwords, phishing, internet browsing, software updates, 2FA, privacy settings, scams, and backups.");
                Console.ResetColor();
                return "";
            }

            if (input.Contains("how are you"))
            {
                Console.WriteLine("I am good, thank you. What would you like to be aware about?");
                Console.ResetColor();
                return "";
            }

            if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to help people be aware of cyber dangers.");
                Console.WriteLine("Choose a topic: passwords, phishing, internet browsing, 2FA, scams, privacy, updates, or backups.");
                Console.ResetColor();
                return "";
            }

            
            if (input.Contains("password"))
            {
                memory.LastTopic = "passwords";
                List<string> responses = new List<string>()
                {
                    "Strong passwords should be at least 12 characters long and include letters, numbers, and symbols.",
                    "Avoid using the same password across multiple websites.",
                    "Use a password manager to keep track of complex passwords.",
                    "Never share your password with anyone, even someone you trust.",
                };

                Console.WriteLine(responses[rnd.Next(responses.Count)]);
                Console.WriteLine("Next: Try phishing, safe browsing, or another topic.");
                Console.ResetColor();
                return "";
            }

            
            if (input.Contains("phishing") || input.Contains("email"))
            {
                memory.LastTopic = "phishing";
                List<string> responses = new List<string>()
                {
                    "Phishing emails often include suspicious links or fake urgency. Stay alert!",
                    "Don't click links in emails unless you're sure who sent them.",
                    "Always verify the sender's email address carefully.",
                    "If it seems too good to be true, it probably is – classic phishing trick."
                };

                Console.WriteLine(responses[rnd.Next(responses.Count)]);
                Console.WriteLine("Next: Try password safety, safe browsing, or another topic.");
                Console.ResetColor();
                return "";
            }

            
            if (input.Contains("browsing") || input.Contains("internet"))
            {
                memory.LastTopic = "browsing";
                List<string> responses = new List<string>()
                {
                    "Use secure HTTPS websites whenever possible.",
                    "Avoid entering personal info on public Wi-Fi networks.",
                    "Regularly clear your browser cache and cookies.",
                    "Keep your browser and extensions updated to avoid vulnerabilities."
                };

                Console.WriteLine(responses[rnd.Next(responses.Count)]);
                Console.WriteLine("Next: Choose phishing, password safety, or another topic.");
                Console.ResetColor();
                return "";
            }

            
            if (input.Contains("2fa") || input.Contains("two-factor"))
            {
                memory.LastTopic = "2FA";
                List<string> responses = new List<string>()
                {
                    "Always enable two-factor authentication (2FA) for your important accounts.",
                    "2FA adds an extra layer of security even if your password is stolen.",
                    "Authenticator apps are safer than SMS for 2FA.",
                    "Don't share your 2FA codes with anyone."
                };

                Console.WriteLine(responses[rnd.Next(responses.Count)]);
                Console.WriteLine("Next: Choose another topic like phishing, updates, or backups.");
                Console.ResetColor();
                return "";
            }

           
            if (input.Contains("privacy"))
            {
                memory.LastTopic = "privacy";
                List<string> responses = new List<string>()
                {
                    "Check your privacy settings on social media regularly.",
                    "Limit what personal information is publicly visible online.",
                    "Avoid oversharing location or personal details.",
                    "Disable unnecessary app permissions."
                };

                Console.WriteLine(responses[rnd.Next(responses.Count)]);
                Console.WriteLine("Next: Learn about passwords, 2FA, or updates.");
                Console.ResetColor();
                return "";
            }

  
            if (input.Contains("scam") || input.Contains("fraud"))
            {
                memory.LastTopic = "scams";
                List<string> responses = new List<string>()
                {
                    "Watch out for messages that claim you’ve won something unexpectedly.",
                    "Never send money or personal info to strangers online.",
                    "Check official sources before believing financial requests.",
                    "Scams often create urgency to get you to act fast—pause and think."
                };

                Console.WriteLine(responses[rnd.Next(responses.Count)]);
                Console.WriteLine("Next: Try phishing, backups, or safe browsing.");
                Console.ResetColor();
                return "";
            }

           
            if (input.Contains("update") || input.Contains("patch"))
            {
                memory.LastTopic = "updates";
                List<string> responses = new List<string>()
                {
                    "Keep your software up to date to fix security vulnerabilities.",
                    "Enable automatic updates where possible.",
                    "Updates often include important security patches.",
                    "Outdated software can be a target for hackers."
                };

                Console.WriteLine(responses[rnd.Next(responses.Count)]);
                Console.WriteLine("Next: Learn about 2FA, scams, or backups.");
                Console.ResetColor();
                return "";
            }

        
            if (input.Contains("backup"))
            {
                memory.LastTopic = "backups";
                List<string> responses = new List<string>()
                {
                    "Back up your important files regularly.",
                    "Use cloud storage or an external drive for backups.",
                    "Ransomware can lock your files—backups help you recover.",
                    "Automate your backups to stay protected."
                };

                Console.WriteLine(responses[rnd.Next(responses.Count)]);
                Console.WriteLine("Next: Learn about updates, privacy, or scams.");
                Console.ResetColor();
                return "";
            }

            // Default fallback response
            Console.WriteLine("I'm not sure I understand. Try topics like passwords, phishing, 2FA, or scams.");
            Console.ResetColor();
            return "";
        }
    }
}
