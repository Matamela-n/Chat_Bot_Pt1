# 🤖 Secure Lock — Chat Bot (Part 1)

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

