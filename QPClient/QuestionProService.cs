using QuestionProClient.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionProClient
{
    public class QuestionProService
    {
        private readonly IQuestionProApi _api;

        public QuestionProService(string baseUrl)
        {
            _api = RestService.For<IQuestionProApi>(baseUrl);
        }

        public Task<List<Survey>> GetSurveysAsync() => _api.GetSurveysAsync();

        public Task<Survey> GetSurveyByIdAsync(string id) => _api.GetSurveyByIdAsync(id);

        public Task<Survey> CreateSurveyAsync(Survey survey) => _api.CreateSurveyAsync(survey);

        public Task DeleteSurveyAsync(string id) => _api.DeleteSurveyAsync(id);
    }
}