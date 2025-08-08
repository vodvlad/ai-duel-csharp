using ai_duel.Srcs.Ai.Prompts;
using ai_duel.Srcs.Config;

namespace ai_duel.Srcs.Ai;

public static class Ai
{
    private static readonly HttpClient client = new HttpClient();
    
    public class Message
    {
        public string role { get; set; }
        public string content { get; set; }
    }
    
    public class Payload
    {
        public string model { get; set; }
        public List<Message> messages { get; set; }
        public double temperature { get; set; } = 0.8;
        public int max_tokens { get; set; } = 500;
        public double top_p { get; set; } = 0.9;
        public long seed { get; set; }
        public double frequency_penalty { get; set; } = 0.1;
        public double presence_penalty { get; set; } = 0.1;
    }
    public class Choice
    {
        public Message message { get; set; }
    }

    public class ResponseData
    {
        public List<Choice> choices { get; set; }
    }
    
    public static void CreateSubject(AiDuelConfig config)
    {
        string prompt = AiDuelPrompts.GetPrompt(config);
        
    }
}