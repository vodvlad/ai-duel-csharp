using ai_duel.Srcs.Screens.Interfaces;
using ai_duel.Srcs.Utils;

namespace ai_duel.Srcs.Screens;

public class HowItWorks : IMenu
{
    private bool _error = false;
    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(AiDuelConstants.HowItWorksConst);
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