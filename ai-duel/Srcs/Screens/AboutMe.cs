using ai_duel.Srcs.Screens.Interfaces;
using ai_duel.Srcs.Utils;

namespace ai_duel.Srcs.Screens;

public class AboutMe : IMenu
{
    private bool _error = false;
    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(AiDuelConstants.AboutMeConst);
            if (_error == true)
            {
                Console.WriteLine("Incorrect input. Please try again.\n");
                _error = false;
            }
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    return;
                default:
                    _error = true;
                    break;
            }
        }
    }
}