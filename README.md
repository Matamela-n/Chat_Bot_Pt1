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

# SecureLock Chat

## Overview
SecureLock Chat is a Windows Forms chatbot that helps users manage cybersecurity tasks, take a quiz, and track activities using Natural Language Processing.

## Features
- **Part 1 & 2:** Core chatbot with voice/text greetings and purple neon GUI
- **Part 3:** Task management with MySQL database (add, view, complete, delete tasks)
- **Task 2:** 12-question cybersecurity quiz with immediate feedback
- **Task 3:** NLP-based intent detection (understands flexible phrasing)
- **Task 4:** Activity log that tracks all user actions with timestamps

## Technologies
- C# (.NET 9.0)
- Windows Forms
- MySQL 8.0.46
- MySql.Data 9.7.0

## Setup

### Prerequisites
- Visual Studio 2022
- .NET 9.0
- MySQL Server 8.0+
- MySql.Data NuGet package

### Database Setup
```sql
CREATE DATABASE SecureLockAssistantDB;
USE SecureLockAssistantDB;
CREATE TABLE Tasks (
    TaskID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    Description VARCHAR(500),
    ReminderDate DATETIME NULL,
    IsCompleted BOOLEAN DEFAULT FALSE
);
```

### Installation
1. Clone the repository
2. Open `Secure_Lock_Chat.sln` in Visual Studio
3. Install MySql.Data NuGet package
4. Update MySQL password in `Database.cs` if needed
5. Build solution (`Ctrl+Shift+B`)
6. Run application (`F5`)

## Usage

### Commands
```
"add task"              → Create a new task
"show tasks"            → Display all tasks
"complete task [name]"  → Mark task as done
"delete task [name]"    → Remove a task
"quiz"                  → Start cybersecurity quiz
"show activity log"     → View recent actions
```

### Example
```
User: add task
Bot: What's the title?
User: Enable 2FA
Bot: Describe this task
User: Enable on email and banking
Bot: How many days to remind? (0 for none)
User: 7
Bot: ✓ Task added! Remind in 7 days.
```

## Project Structure
- **Form1.cs** - Main GUI
- **Task.cs** - Task model
- **Database.cs** - MySQL connection
- **TaskManager.cs** - Task business logic
- **QuizQuestion.cs** - Quiz questions
- **QuizManager.cs** - Quiz logic
- **ActivityLog.cs** - Activity tracking
- **NLPHelper.cs** - Intent detection
- **ChatBot.cs** - Chatbot logic (Part 1)
- **TextGreeting.cs** - Text greeting (Part 2)
- **VoiceGreeting.cs** - Voice greeting (Part 2)

## Key Features

### Database (Part 3)
- Full CRUD operations for tasks
- MySQL persistence
- Parameterized queries for security

### Quiz (Task 2)
- 12 cybersecurity questions
- Multiple-choice and true/false
- Immediate feedback with explanations
- Performance-based scoring

### NLP (Task 3)
- Keyword-based intent detection
- Supports flexible phrasing
- Recognizes variations: "add task", "create task", "new task"

### Activity Log (Task 4)
- Tracks tasks, quiz, and system events
- Timestamped entries (HH:MM:SS)
- Shows last 10 actions

## Testing
- Application launches ✅
- Database connects ✅
- Tasks save to database ✅
- Quiz displays all questions ✅
- NLP recognizes commands ✅
- Activity log tracks actions ✅

## Author
Matamela Nesidoni

## Date
June 2026


## Author
Matamela Nesidoni
Student Number: ST10483305

