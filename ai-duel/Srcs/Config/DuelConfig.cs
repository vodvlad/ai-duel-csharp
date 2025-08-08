namespace ai_duel.Srcs.Config;

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}

public enum ProgrammingLanguage
{
    Clang,
    Dart,
    Java,
}
public class AiDuelConfig
{
    private Difficulty _difficulty;
    private ProgrammingLanguage _language;
    private string lmUrl = "https://api.openai.com/v1/chat/completions";
    private string model = "gpt-3.5-turbo";
    public AiDuelConfig()
    {
        _difficulty = Difficulty.Easy;
        _language = ProgrammingLanguage.Clang;
    }
    public ProgrammingLanguage getProgrammingLanguage()
    {
        return _language;
    }
    public Difficulty getDifficulty()
    {
        return _difficulty;
    }
    
    public void setProgrammingLanguage(ProgrammingLanguage language)
    {
        _language = language;
    }
    public void setDifficulty(Difficulty difficulty)
    {
        _difficulty = difficulty;
    }
    
    public int getDuelTime()
    {
        if (_difficulty == Difficulty.Easy)
        {
            return 2700;
        }
        else if (_difficulty == Difficulty.Medium)
        {
            return 1200;
        }
        else if (_difficulty == Difficulty.Hard)
        {
            return 600;
        }
        else
        {
            return 0;
        }
    }
    
}