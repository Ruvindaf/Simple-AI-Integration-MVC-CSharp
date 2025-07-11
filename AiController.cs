using Azure;
using Azure.AI.OpenAI;
using Microsoft.AspNetCore.Mvc;
using OpenAI.Chat;
using Simple_AI.Settings;

namespace AI.Test.Controllers
{
    public class AiController : Controller
    {
        private readonly AzureOpenAISettings _openAiSettings;

        public AiController(
            AzureOpenAISettings openAiSettings)
        {
            _openAiSettings = openAiSettings;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AskOpenAI(string prompt)
        {
            try
            {
                var endpoint = new Uri(_openAiSettings.Endpoint);
                var apiKey = _openAiSettings.ApiKey;
                var deploymentName = _openAiSettings.DeploymentName;

                AzureOpenAIClient azureClient = new AzureOpenAIClient(endpoint, new AzureKeyCredential(apiKey));
                ChatClient chatClient = azureClient.GetChatClient(deploymentName);

                var requestOptions = new ChatCompletionOptions
                {
                    MaxOutputTokenCount = 1000,
                    Temperature = 0.7f,
                    TopP = 1.0f
                };

                var messages = new List<ChatMessage>
        {
            new SystemChatMessage("You are a DevOps assistant."),
            new UserChatMessage(prompt)
        };

                var response = chatClient.CompleteChat(messages, requestOptions);
                string reply = response.Value.Content.FirstOrDefault()?.Text ?? "No response returned.";

                return Json(new { response = reply });
            }
            catch (Exception ex)
            {
                return Json(new { response = $"Error: {ex.Message}" });
            }
        }

    }
}
