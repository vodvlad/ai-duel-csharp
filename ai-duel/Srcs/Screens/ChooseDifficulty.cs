using ai_duel.Srcs.Config;
using ai_duel.Srcs.Screens.Interfaces;
using ai_duel.Srcs.Utils;

namespace ai_duel.Srcs.Screens;

public class ChooseDifficulty : IMenu
{
    private bool _error;
    private ChooseProgrammingLanguage _chooseProgrammingLanguage;
    private AiDuelConfig _config;
    public ChooseDifficulty(AiDuelConfig config)
    {
        _error = false;
        _config = config;
        _chooseProgrammingLanguage = new ChooseProgrammingLanguage(_config);
    }
    public void Show()
    {
        while (true)
        {
            Console.Clear();
            AiDuelConstants.ChooseDifficultyConst();
            if (_error == true)
            {
                Console.WriteLine("Incorrect input. Please try again.\n");
                _error = false;
            }
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _config.setDifficulty(Difficulty.Easy);
                    _chooseProgrammingLanguage.Show();
                    return;
                case "2":
                    _config.setDifficulty(Difficulty.Medium);
                    _chooseProgrammingLanguage.Show();
                    return;
                case "3":
                    _config.setDifficulty(Difficulty.Hard);
                    _chooseProgrammingLanguage.Show();
                    return;
                case "4":
                    return;
                default:
                    _error = true;
                    break;
            }
        }
    }
}