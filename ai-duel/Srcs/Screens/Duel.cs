using System.Diagnostics;
using ai_duel.Srcs.Config;
using ai_duel.Srcs.Screens.Interfaces;
using ai_duel.Srcs.Subject;
using ai_duel.Srcs.Utils;

namespace ai_duel.Srcs.Screens;

public class Duel
{
    private AiDuelConfig _config;
    private TimeSpan Duration => TimeSpan.FromSeconds(_config.getDuelTime());
    private Stopwatch _stopwatch;
    private bool _isRunning;
    
    public Duel(AiDuelConfig config)
    {
        _config = config;
        _stopwatch = new Stopwatch();
        _isRunning = false;
    }
    public void Start()
    {   
        // PrepareDuel();
        StartDuel();
    }
    
    private void ShowStatus()
    {
        TimeSpan remaining = Duration - _stopwatch.Elapsed;
        if (remaining.TotalSeconds < 0) remaining = TimeSpan.Zero;

        Console.WriteLine($"\n⏳ Remaining time: {remaining.Minutes:D2}:{remaining.Seconds:D2}\n");
    }

    private void PrepareDuel()
    {
        AiDuelSubject.CreateSubject(_config);
    }

    private void StartDuel()
    {
        Console.WriteLine(_config.getDuelTime());
        AiDuelConstants.DuelConst(_config.getDuelTime());
        _stopwatch.Start();
        _isRunning = true;

        while (_isRunning)
        {
            if (_stopwatch.Elapsed >= Duration)
            {
                Console.WriteLine("\n⏰ Time is up! Duel ended.");
                _isRunning = false;
                break;
            }

            if (Console.KeyAvailable)
            {
                string? input = Console.ReadLine()?.Trim().ToLower();

                switch (input)
                {
                    case "status":
                        ShowStatus();
                        break;
                    case "finish":
                        Console.WriteLine("✅ Duel finished early by user.");
                        _isRunning = false;
                        break;
                    case "exit":
                        Console.WriteLine("\n❌  Duel exited.\n");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n❓ Unknown command. Use `status`, `finish`, or `exit`.\n");
                        break;
                }
            }
            Thread.Sleep(100);
        }

        _stopwatch.Stop();
    }
}