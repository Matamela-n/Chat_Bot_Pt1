# 🤖 Secure Lock — Chat Bot 

A C# console-based chatbot application featuring a colourful ASCII art logo and a smart security theme. This is Part 1 of a multi-part series.

---

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running the App](#running-the-app)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Links](#links)

---

## About the Project

**Secure Lock Chat Bot** is a C# console application that greets users with a gradient-coloured ASCII art logo on startup. Built as Part 1 of a chatbot series, it establishes the visual identity and foundational structure of the bot — with the tagline *"Smart Security Starts Here!"*

---

## Features

- 🎨 Rainbow gradient ASCII art logo rendered in the console
- 🔐 Smart security themed branding
- 🏗️ Clean class-based C# structure ready to be extended in future parts

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher recommended)
- A terminal or IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/Matamela-n/Chat_Bot_Pt1.git
   cd Chat_Bot_Pt1
   ```

2. **Build the project:**

   ```bash
   dotnet build
   ```

### Running the App

```bash
dotnet run
```

The console will display the colourful ASCII art logo followed by the message:


Smart Security Starts Here!


---

## Project Structure


Chat_Bot_Pt1/
├── AsciiArt.cs       # Handles the gradient ASCII logo display
├── Program.cs        # Entry point (main)
└── README.md
```

### `AsciiArt.cs`

Contains the `AsciiArt` class with:
- `DisplayLogo()` — public method that triggers the logo render
- `ascii()` — private method that loops through each line and character of the logo, applying a 7-colour gradient using `ConsoleColor`

---

## Contributing

Contributions, issues, and feature requests are welcome!

1. Fork the project
2. Create your feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -m 'Add YourFeature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

---

## License

This project is open source.

---

## Links
- 📺 YouTube Tutorial: https://youtu.be/IS3iWZRHS2Y
- 💻 GitHub Repository: https://github.com/Matamela-n/Chat_Bot_Pt1

# SecureLock Chat — Cybersecurity Awareness Bot

## Description
A Windows Forms chatbot application that educates users on cybersecurity topics including passwords, phishing, privacy, scams, malware, wifi security and data backups.

## How to Run
1. Clone the repository
2. Open the solution file in Visual Studio
3. Build the solution (Ctrl + Shift + B)
4. Run the application (F5)
5. Enter your name to begin chatting

## Features
- Voice greeting on launch using WAV file
- Text greeting with personalised user name input
- Keyword recognition for cybersecurity topics
- Random responses using Dictionary and Lists
- Sentiment detection — worried, frustrated, curious
- Memory and recall feature
- Follow-up conversation flow
- Voice button to speak welcome message
- Purple neon themed GUI

## Topics Covered
- Passwords
- Phishing
- Privacy
- Scams
- Malware
- WiFi Security
- Data Backups

## Example Usage
- Type "tell me about passwords" for password safety tips
- Type "I am worried about scams" for sentiment response
- Type "interested in privacy" to save your interest
- Type "remind me" to recall your saved interest
- Type "tell me more" for another tip on the same topic

## YouTube Presentation
[Add your YouTube link here]

## Technologies Used
- C# Windows Forms
- System.Speech.Synthesis
- System.Media.SoundPlayer
- OOP — Classes, Methods, Dictionary, Lists

## Project Structure
- Form1.cs — Main GUI form and event handlers
- ChatBot.cs — Chatbot logic and responses
- TextGreeting.cs — Text greeting and speech
- VoiceGreeting.cs — WAV audio greeting

## Author
Matamela Nesidoni
Student Number: ST10483305

