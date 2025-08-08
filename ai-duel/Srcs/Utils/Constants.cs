using ai_duel.Srcs.Config;

namespace ai_duel.Srcs.Utils;

public static class AiDuelConstants
{
    public const string MainMenuConst = """
██   ▄█     ██▄     ▄   ▄███▄   █
█ █  ██     █  █     █  █▀   ▀  █
█▄▄█ ██     █   █ █   █ ██▄▄    █
█  █ ▐█     █  █  █   █ █▄   ▄▀ ███▄
   █  ▐     ███▀  █▄ ▄█ ▀███▀       ▀
  █                ▀▀▀
 ▀
════════════════════════════════════════════
💻 🤖 Welcome to AI DUEL: CODE BATTLE 🤖 💻
────────────────────────────────────────────
⚔️  Test your coding skills against powerful AI!
🚀 Learn, compete, and become the coding champion!

Choose your path:

    1) 🏁 Start the Duel!
    2) 💡 How it works
    3) 👤 About the Developer
    4) ❌  Exit the Arena
    
""";

    public const string AboutMeConst = """
██   ███   ████▄   ▄     ▄▄▄▄▀     █▀▄▀█ ▄███▄
█ █  █  █  █   █    █ ▀▀▀ █        █ █ █ █▀   ▀
█▄▄█ █ ▀ ▄ █   █ █   █    █        █ ▄ █ ██▄▄
█  █ █  ▄▀ ▀████ █   █   █         █   █ █▄   ▄▀
   █ ███         █▄ ▄█  ▀             █  ▀███▀
  █               ▀▀▀                ▀
 ▀
════════════════════════════════════════════
👤 ℹ️ ABOUT THE DEVELOPER ℹ️ 👤
────────────────────────────────────────────
Hey there! I’m Vlad, an AI enthusiast 👨‍💻
from Ukraine 🇺🇦, currently living in
Luxembourg.

💻 I love coding projects, especially in
   Flutter and AI development.

🎯 My goal is to create tools that are
   fun, useful, and challenging for
   everyone learning programming.

    1) Back to main menu
    
""";


    public const string HowItWorksConst = """
 ▄  █ ████▄   ▄ ▄       ▄█    ▄▄▄▄▀       ▄ ▄   ████▄ █▄▄▄▄ █  █▀  ▄▄▄▄▄
█   █ █   █  █   █      ██ ▀▀▀ █         █   █  █   █ █  ▄▀ █▄█   █     ▀▄
██▀▀█ █   █ █ ▄   █     ██     █        █ ▄   █ █   █ █▀▀▌  █▀▄ ▄  ▀▀▀▀▄
█   █ ▀████ █  █  █     ▐█    █         █  █  █ ▀████ █  █  █  █ ▀▄▄▄▄▀
   █         █ █ █       ▐   ▀           █ █ █          █     █
  ▀           ▀ ▀                         ▀ ▀          ▀     ▀
════════════════════════════════════════════
💡 ℹ️ HOW IT WORKS ℹ️ 💡
────────────────────────────────────────────
Here’s how the AI Duel works:

📝 A *subject* with a function task is
    generated in your chosen language.

🧑‍💻 You write your solution.

🤖 At the same time, the AI writes its own
    solution for the same task.

⚖️  Both codes are then sent for analysis:
    • Checks if the solutions are correct
    • Compares efficiency and quality
    • Suggests improvements
    • Determines the winner!

Are you ready to battle for coding glory?

    1) Back to main menu
    
""";

    public const string ChooseProgrammingLanguageConst = """
▄█▄    ████▄ ██▄   ▄███▄     ▄   ▄   ▄
█▀ ▀▄  █   █ █  █  █▀   ▀   █   █   █
█   ▀  █   █ █   █ ██▄▄    █   █   █
█▄  ▄▀ ▀████ █  █  █▄   ▄▀ █   █   █
▀███▀        ███▀  ▀███▀
                           ▀   ▀   ▀
════════════════════════════════════════════
💻 🔧 CHOOSE YOUR PROGRAMMING LANGUAGE 🔧 💻
────────────────────────────────────────────
Here you choose the language in which
🧑‍💻 YOU and 🤖 THE AI will write code
to battle for the best solution!

Choose your weapon:

    1) C language   ⚙️  (old-school power)
    2) Dart         🎯  (modern mobile force)
    3) Java         ☕  (classic enterprise beast)
    4) Return to Main Menu

""";

    public static void ChooseDifficultyConst()
    {
        Console.WriteLine("""
██▄   ▄█ ▄████  ▄████  ▄█ ▄█▄      ▄   █      ▄▄▄▄▀ ▀▄    ▄
█  █  ██ █▀   ▀ █▀   ▀ ██ █▀ ▀▄     █  █   ▀▀▀ █      █  █
█   █ ██ █▀▀    █▀▀    ██ █   ▀  █   █ █       █       ▀█
█  █  ▐█ █      █      ▐█ █▄  ▄▀ █   █ ███▄   █        █
███▀   ▐  █      █      ▐ ▀███▀  █▄ ▄█     ▀ ▀       ▄▀
           ▀      ▀               ▀▀▀
════════════════════════════════════════════
💻 🚀 BATTLE OF CODE: CHOOSE YOUR DESTINY 🚀 💻
────────────────────────────────────────────
The difficulty level you choose will determine:
  • 🕒 The time you get to solve the challenge
  • 🤖 The skill level of the AI opponent
    battling you for the best and most
    optimal code!
    
""");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("    1) Easy    😌 (beginner vs. training bot)");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("    2) Medium  😎 (intermediate vs. skilled bot)");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("    3) Hard    👾 (hardcore vs. master AI)");

        Console.ResetColor();
        Console.WriteLine("    4) Return to Main Menu\n");
    }
    
    public static void UserConfigConst(Difficulty difficultyName, ProgrammingLanguage programmingLanguageName, int time)
    {
        Console.WriteLine("""
█▄▄▄▄ ▄███▄       ▄   ▄█ ▄███▄     ▄ ▄
█  ▄▀ █▀   ▀       █  ██ █▀   ▀   █   █
█▀▀▌  ██▄▄    █     █ ██ ██▄▄    █ ▄   █
█  █  █▄   ▄▀  █    █ ▐█ █▄   ▄▀ █  █  █
  █   ▀███▀     █  █   ▐ ▀███▀    █ █ █
 ▀               █▐                ▀ ▀
                 ▐

════════════════════════════════════════════
💻 ✅ REVIEW YOUR SETTINGS ✅ 💻
────────────────────────────────────────────
Check your battle setup before starting:
""");
        Console.Write("⚔️ Difficulty: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(difficultyName);
        Console.ResetColor();

        Console.Write("💻 Programming Language: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(programmingLanguageName);
        Console.ResetColor();

        Console.Write("⏳  Timer: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{time / 60:0.0} minutes\n");
        Console.ResetColor();
        
        Console.WriteLine("""
                          Are you ready to begin?
                              1) 🚀 START the Challenge!
                              2) Return to Main Menu
                              
                          """);
    }
    
    public static void DuelConst(int time)
    {
        Console.WriteLine($"""
                             ▄▄▄▄▀ ▄█ █▀▄▀█ ▄███▄   █▄▄▄▄
                          ▀▀▀ █    ██ █ █ █ █▀   ▀  █  ▄▀
                              █    ██ █ ▄ █ ██▄▄    █▀▀▌
                             █     ▐█ █   █ █▄   ▄▀ █  █
                            ▀       ▐    █  ▀███▀     █
                                        ▀            ▀
                          ════════════════════════════════════════════
                          ⏳ 🕒 TIMER STARTED 🕒 ⏳
                          ────────────────────────────────────────────
                          🚀 Timer is now running for {time} seconds ({time / 60} minutes).
                          
                          Available commands:
                              📊 status  - check timer status
                              🛑 finish  - stop the timer
                              ❌  exit    - exit the game
                              
                          """);
    }
}