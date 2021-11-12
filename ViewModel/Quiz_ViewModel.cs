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
            QuestionOneAnswers.Add(new Answer() { answer = "Answer", correct = true });
            QuestionOneAnswers.Add(new Answer() { answer = "Answer", correct = false });
            QuestionOneAnswers.Add(new Answer() { answer = "Answer", correct = false });
            QuestionOneAnswers.Add(new Answer() { answer = "Answer", correct = false });

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


            questions.Add(new Question() { question = "Question 1", answers = QuestionOneAnswers });
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
