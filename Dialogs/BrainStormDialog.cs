using System;
using System.Threading.Tasks;

using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.ConnectorEx;
using System.Net.Http;
using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using ProactiveBot.Services;

namespace Microsoft.Bot.Sample.ProactiveBot
{
    [Serializable]
    public class BrainStormDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        public async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> argument)
        {
            var message = await argument;
            // Create a queue Message

            var wordGenerator = new WordGenerator();

            var responseMessage =
                $"Try brainstorming an idea with the following two words {wordGenerator.NewWord()} and {wordGenerator.NewWord()}";
            // write the queue Message to the queue
            await context.PostAsync(responseMessage);
            context.Wait(MessageReceivedAsync);
        }
    }
}