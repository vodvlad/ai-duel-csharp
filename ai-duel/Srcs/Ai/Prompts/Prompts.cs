using ai_duel.Srcs.Config;

namespace ai_duel.Srcs.Ai.Prompts;

public static class AiDuelPrompts
{
    private static string cSystemPrompt =
        """
        You are a creative programming teacher. Generate a unique and interesting function in C for practice. {randomContext}. Provide the following format in your response:

        function: [function header]
        allowed_libs: [only allowed libraries, for example unistd, stdio, or none]
        description: [a short clear description of what the function should do, without implementation]

        Do not write the implementation. The purpose is for the user to write the function themselves.

        Example format:
        *function: void ft_putnbr(int n);
        *allowed_libs: unistd
        *description: outputs an integer to the standard output using only write().
        *output_example: 42

        Generate one unique function now. Make it creative and different from typical examples.
        """;

    private static string dartSystemPrompt =
        """
        You are a creative programming teacher. Generate a unique and interesting function in Dart for practice. {randomContext}. Provide the following format in your response:

        function: [function header]
        allowed_libs: [only allowed libraries, for example dart:core, dart:io, or none]
        description: [a short clear description of what the function should do, without implementation]

        Do not write the implementation. The purpose is for the user to write the function themselves.

        Example format:
        *function: void printNumber(int number);
        *allowed_libs: dart:core
        *description: outputs an integer to the console in a formatted way.
        *output_example: 42

        Generate one unique function now. Make it creative and different from typical examples.
        """;

    private static string javaSystemPrompt =
        """
        You are a creative programming teacher. Generate a unique and interesting function in Java for practice. {randomContext}. Provide the following format in your response:

        function: [function header]
        allowed_libs: [only allowed libraries, for example java.util, java.io, or none]
        description: [a short clear description of what the function should do, without implementation]

        Do not write the implementation. The purpose is for the user to write the function themselves.

        Example format:
        *function: public static void printNumber(int number);
        *allowed_libs: java.util
        *description: outputs an integer to the console in a formatted way.
        *output_example: 42

        Generate one unique function now. Make it creative and different from typical examples.
        """;

    public static string GetPrompt(AiDuelConfig config)
    {
        if (config.getProgrammingLanguage() == ProgrammingLanguage.Clang)
        {
            return cSystemPrompt;
        }
        else if (config.getProgrammingLanguage() == ProgrammingLanguage.Dart)
        {
            return dartSystemPrompt;
        }
        else if (config.getProgrammingLanguage() == ProgrammingLanguage.Java)
        {
            return javaSystemPrompt;
        }

        return "";
    }
}