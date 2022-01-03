using System;
using System.Collections.Generic;
using CyberThink.Model;

namespace CyberThink.ViewModel
{
    public class Quiz_ViewModel
    {
        public List<Question> questions { get;}

        public Quiz_ViewModel()
        {
            questions = new List<Question>();
            this.GenerateQuestionAndAnswers();
        }

        public void GenerateQuestionAndAnswers()
        {
            var QuestionOneAnswers = new List<Answer>();
            questions.Add(new Question() { question = "Which one of the following statements is true about brute-force attack?", answers = QuestionOneAnswers });
            QuestionOneAnswers.Add(new Answer() { answer = "A brute-force attack involves a colleague watching over your shoulder to obtain valuable information within a work environment.", correct = true });
            QuestionOneAnswers.Add(new Answer() { answer = "A brute-force attack is whereby every permutation of password is tested against a password protected system.", correct = true });
            QuestionOneAnswers.Add(new Answer() { answer = "A brute-force attack involves guessing the victim’s password without any tools or technology.", correct = false });
            QuestionOneAnswers.Add(new Answer() { answer = "A brute-force attack utilises a dictionary to breach a victims account.", correct = false });

            var QuestionTwoAnswers = new List<Answer>();
            questions.Add(new Question() { question = "Which of the following statements is false?", answers = QuestionTwoAnswers });
            QuestionTwoAnswers.Add(new Answer() { answer = "One of the most effective defence mechanisms against password attacks is ensuring the password contains a minimum of 8 characters, a combination of mixed characters both upper and lowercase.", correct = false });
            QuestionTwoAnswers.Add(new Answer() { answer = "Using a password manager is an effective strategy for securely storing your passwords and accessing applications.", correct = false });
            QuestionTwoAnswers.Add(new Answer() { answer = "You can always share your password with anyone if they ask you to use your account.", correct = true });
            QuestionTwoAnswers.Add(new Answer() { answer = "To ensure maximum security, you must prevent using the same password for different accounts as a single leak could expose other accounts.", correct = true });

            var QuestionThreeAnswers = new List<Answer>();
            questions.Add(new Question() { question = "Which of the following password ensures the most security?", answers = QuestionThreeAnswers });
            QuestionThreeAnswers.Add(new Answer() { answer = "Ilovefootball", correct = true });
            QuestionThreeAnswers.Add(new Answer() { answer = "!xD#Lu_21x@X", correct = false });
            QuestionThreeAnswers.Add(new Answer() { answer = "123Sam123", correct = false });
            QuestionThreeAnswers.Add(new Answer() { answer = "Password1234!", correct = false });

            var QuestionFourAnswers = new List<Answer>();
            questions.Add(new Question() { question = "Which of the following statement is true about email phishing?", answers = QuestionFourAnswers });
            QuestionFourAnswers.Add(new Answer() { answer = "Phishing emails can usually be identified by their generic contents and beginning starting with ‘Dear Customer’", correct = true });
            QuestionFourAnswers.Add(new Answer() { answer = "Phishing emails usually contain malicious links which aim to extract confidential information from the victim", correct = false });
            QuestionFourAnswers.Add(new Answer() { answer = "Phishing emails does not include any information which may make the victim think there is a genuine connection between the sender and them", correct = false });
            QuestionFourAnswers.Add(new Answer() { answer = "All the above", correct = true });

            var QuestionFiveAnswers = new List<Answer>();
            questions.Add(new Question() { question = "If you receive a suspicious email with contents that are specifically directed to you, what type of phishing attack does this closely relate to?", answers = QuestionFiveAnswers });
            QuestionFiveAnswers.Add(new Answer() { answer = "Email Phishing", correct = true });
            QuestionFiveAnswers.Add(new Answer() { answer = "Vishing", correct = false });
            QuestionFiveAnswers.Add(new Answer() { answer = "Spear Phishing", correct = true });
            QuestionFiveAnswers.Add(new Answer() { answer = "Whaling", correct = false });

            var QuestionSixAnswers = new List<Answer>();
            questions.Add(new Question() { question = "Which of the following is false regarding defensive mechanisms against phishing? ", answers = QuestionSixAnswers });
            QuestionSixAnswers.Add(new Answer() { answer = "A spoofed link will often be shorted. You can ensure a link is genuine by checking if it is in the original, long-tail format", correct = true });
            QuestionSixAnswers.Add(new Answer() { answer = "Attackers only utilise a malicious application which follow the HTTP protocol and will never attempt to trick a victim via a website operating over HTTPS", correct = true });
            QuestionSixAnswers.Add(new Answer() { answer = "When reading a message, you must consider any misspelling or wrong domain use which may indicate a phishing attempt", correct = false });
            QuestionSixAnswers.Add(new Answer() { answer = "Two effective mechanisms against any phishing attempt could be simply by ignoring the message or directly contacting the institution", correct = false });


            var QuestionSevenAnswers = new List<Answer>();
            questions.Add(new Question() { question = "Which of the following statement is true?", answers = QuestionSevenAnswers });
            QuestionSevenAnswers.Add(new Answer() { answer = "It is crucial that you lock your computer to prevent an unauthorised user from accessing confidential information on your computer which could support a cyber-attack.", correct = true });
            QuestionSevenAnswers.Add(new Answer() { answer = "Ensuring your workspace is clean from any cluttered documents, sticky notes containing passwords will prevent an attacker from obtaining sensitive information.", correct = false });
            QuestionSevenAnswers.Add(new Answer() { answer = "As an employee, you must respect security protocols and must under no circumstances oppose them. ", correct = true });
            QuestionSevenAnswers.Add(new Answer() { answer = "Implementing all three measures will maximise the security within the organization and prevent an attacker from obtaining information which could lead to a cyber-attack.", correct = false });

            var QuestionEightAnswers = new List<Answer>();
            questions.Add(new Question() { question = "Which statement closely relates to tailgating?", answers = QuestionEightAnswers });
            QuestionEightAnswers.Add(new Answer() { answer = "Tailgating involves an attacker using a device to attack an organization from outside", correct = true });
            QuestionEightAnswers.Add(new Answer() { answer = "Tailgating involves an attacker gaining unauthorised access to the business premises by following an employee typically from behind", correct = false });
            QuestionEightAnswers.Add(new Answer() { answer = "Tailgating involves an attacker using a brute-force attack to breach an employee’s account", correct = true });
            QuestionEightAnswers.Add(new Answer() { answer = "Tailgating is not a malicious attempt to physically access an organizations property", correct = false });

            var QuestionNineAnswers = new List<Answer>();
            questions.Add(new Question() { question = "What must you do if you detect suspicious activity?", answers = QuestionNineAnswers });
            QuestionNineAnswers.Add(new Answer() { answer = "Ignore it and continue with your duty", correct = true });
            QuestionNineAnswers.Add(new Answer() { answer = "Report the activity to a senior member such as a manager", correct = false });
            QuestionNineAnswers.Add(new Answer() { answer = "Attempt to stop the individual yourself ", correct = true });
            QuestionNineAnswers.Add(new Answer() { answer = "Help the individual with what they are trying to achieve ", correct = false });
        }

        public bool CheckAnswer(Answer answer)
        {
            if (answer.correct == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
    }
}
