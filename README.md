# C# Homework

C# console exercises (.NET 6) from a programming course, September–December 2023. Each folder is a separate Visual Studio solution; prompts and output are in Russian.

| Folder | Exercises |
|---|---|
| `Seminar1` | Variables, types and formatted console output: a student information card |
| `Seminar2` | Menu-driven tasks: even/odd check, a hand-total calculator for the card game "21", prime number check, smallest element of a sequence, a "guess the number" game |
| `Seminar3` | Two-dimensional arrays: a random matrix and matrix addition |
| `Seminar 3 Exercise 3` | Conway's Game of Life in the console (`LifeSimulation` on a `bool[,]` grid) |
| `Seminar4` | String methods: splitting a phrase into words and reversing the word order |
| `Seminar5` | File I/O: reading records from a text file and appending new ones |
| `Seminar6` | An employee directory: a `Worker` struct and a file-backed `Repository` to list, find, add and delete records, and load them by date range |
| `Seminar7` | Collections: `List<int>`, a phone book on `Dictionary`, a duplicate check with `HashSet`, a notebook saved as XML with `XElement` |

**Run:** open a folder's `.sln` in Visual Studio, or run `dotnet run --project <Folder>`. Seminars 5 and 6 point to a hard-coded data folder (`G:\VisualStudioHomework\...`); change that path to the seminar's own folder, where `test.txt` is, before running them.
