# Warm Oder Kalt

A C# (CSharp) Console App exercise project developed during my retraining as an IT Specialist in Application Development at Lutz + Grub Academy.

This is a number guessing game where the player has to guess a random number between 0 and 100. The game gives feedback whether the new guess is “warmer” (closer) or “colder” (further away) compared to the previous one. The number of attempts is recorded and stored as a highscore, sorted by best performance.

Player data is saved and loaded from a JSON file using serialization.

### Features

- Random number guessing game (0–100)
- Console feedback: "warmer", "colder", or "correct"
- Scoreboard: highscores based on number of attempts
- JSON serialization and deserialization with `Newtonsoft.Json`

### How to Run

To run the Console App program directly, launch  
`Warm oder Kalt.exe` located in  
`bin/Release/net6.0`.

> **Note**: German language used in console output.

---

The code was written independently by me. The class only provided a general idea of what the project should do.
