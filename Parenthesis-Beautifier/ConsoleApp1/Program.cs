using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static List<(string, int)> GetParenthesisMatchesSortedByDepth(string input)
    {
        var results = new List<(string, int)>();
        int depth = 0;
        string working = input;

        while (true)
        {
            var matches = Regex.Matches(working, @"\([^()]*\)");
            if (matches.Count == 0) break;

            foreach (Match m in matches)
            {
                results.Add((m.Value, depth));
            }

            foreach (Match m in matches)
            {
                int start = m.Index;
                int len = m.Length;
                working = working.Substring(0, start) + new string(' ', len) + working.Substring(start + len);
            }
            depth++;
        }

        // Sort innermost first (highest depth first)
        results.Sort((a, b) => b.Item2.CompareTo(a.Item2));
        return results;
    }

    static void Main()
    {
        string text = "a(b(c(d)e)f(g)h)i";
        var matches = GetParenthesisMatchesSortedByDepth(text);
        foreach (var tuple in matches)
        {
            Console.WriteLine($"Depth: {tuple.Item2}, Match: {tuple.Item1}");
        }
    }
}