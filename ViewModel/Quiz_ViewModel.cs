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
            QuestionOneAnswers.Add(new Answer() { answer = "A brute-force attack involves a colleague watching over your shoulder to obtain valuable information within a work environment.", correct = true });
            QuestionOneAnswers.Add(new Answer() { answer = "A brute-force attack is whereby every permutation of password is tested against a password protected system.", correct = true });
            QuestionOneAnswers.Add(new Answer() { answer = "A brute-force attack involves guessing the victim’s password without any tools or technology.", correct = false });
            QuestionOneAnswers.Add(new Answer() { answer = "A brute-force attack utilises a dictionary to breach a victims account.", correct = false });

            var QuestionTwoAnswers = new List<Answer>();
            QuestionTwoAnswers.Add(new Answer() { answer = "Answer", correct = false });
            QuestionTwoAnswers.Add(new Answer() { answer = "Answer", correct = false });
            QuestionTwoAnswers.Add(new Answer() { answer = "Answer", correct = false });
            QuestionTwoAnswers.Add(new Answer() { answer = "Answer", correct = true });

            var QuestionThreeAnswers = new List<Answer>();
            QuestionThreeAnswers.Add(new Answer() { answer = "Answer", correct = true });
            QuestionThreeAnswers.Add(new Answer() { answer = "Answer", correct = false });
            QuestionThreeAnswers.Add(new Answer() { answer = "Answer", correct = false });
            QuestionThreeAnswers.Add(new Answer() { answer = "Answer", correct = false });


            questions.Add(new Question() { question = "Which one of the following statements is true about brute-force attack?", answers = QuestionOneAnswers });
            questions.Add(new Question() { question = "Question 2", answers = QuestionTwoAnswers });
            questions.Add(new Question() { question = "Question 3", answers = QuestionThreeAnswers });


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
