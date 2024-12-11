using Refit;
using System.Threading.Tasks;

namespace QuestionProSdk
{
    public interface IQuestionProApi
    {
        [Get("/surveys")]
        Task<List<Survey>> GetSurveysAsync();

        [Get("/surveys/{id}")]
        Task<Survey> GetSurveyByIdAsync(string id);

        [Post("/surveys")]
        Task<Survey> CreateSurveyAsync([Body] Survey survey);

        [Delete("/surveys/{id}")]
        Task DeleteSurveyAsync(string id);
    }
}