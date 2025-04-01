# Keikakudori-Mono

A fighting game built with MonoGame and C#, focusing on fluid combat mechanics and responsive controls.

## Overview

Keikakudori-Mono is a 2D fighting game that combines traditional fighting game mechanics with modern gameplay elements. The project uses MonoGame framework to deliver a cross-platform experience with pixel-perfect precision and frame-accurate combat.

## Current State

The project is in early development with the following components in place:

- Basic MonoGame infrastructure setup
- Project structure established
- Initial rendering pipeline configured
- Development environment configured for cross-platform development

## Planned Features

- **Combat System**: Frame-precise hit boxes and responsive controls
- **Character Roster**: Multiple unique fighters with distinct move sets
- **Stage Variety**: Different arenas with interactive elements
- **Single Player**: Arcade mode with progressively challenging AI
- **Multiplayer**: Local and potentially online versus modes
- **Training Mode**: Comprehensive practice environment with frame data display

## Technical Architecture

The game is built on these core technologies:

- **C#**: Primary programming language
- **MonoGame**: Game framework (OpenGL implementation)
- **Entity Component System**: For game object management
- **Custom Physics**: Tailored for fighting game mechanics

## Development Setup

### Prerequisites

- .NET SDK 8.0 or later
- Visual Studio Code or Visual Studio 2022
- MonoGame templates

### Getting Started

1. Clone the repository:

   ```plaintext
   git clone https://github.com/yourusername/keikakudori-mono.git
   cd keikakudori-mono
   ```

2. Open the project in Visual Studio Code:

   ```plaintext
   code .
   ```

3. Build and run the project:
   - Press F5 to start debugging
   - Or use the terminal: `dotnet run`

### VS Code Configuration

The repository includes optimized VS Code settings:

- Debugging configurations
- Build tasks
- Editor settings for C# development
- Recommended extensions

## Project Structure

```plaintext
keikakudori-mono/
├── .vscode/                  # VS Code configuration
├── Content/                  # Game assets and resources
│   ├── Content.mgcb          # MonoGame Content Builder file
│   ├── Sprites/              # Character and UI sprites
│   ├── Fonts/                # Text rendering fonts
│   └── Audio/                # Sound effects and music
├── Source/                   # C# source files
│   ├── Core/                 # Core game systems
│   ├── Entities/             # Game objects and components
│   ├── Input/                # Input handling
│   ├── Combat/               # Fighting mechanics
│   ├── UI/                   # User interface
│   └── Utilities/            # Helper classes
├── Program.cs                # Entry point
├── Game1.cs                  # Main game class
└── keikakudori-mono.csproj   # Project file
```

## Development Roadmap

- **Phase 1**: Core engine and rendering pipeline *(Current)*
- **Phase 2**: Character movement and basic combat mechanics
- **Phase 3**: First playable character with complete move set
- **Phase 4**: UI systems and game states
- **Phase 5**: Additional characters and stages
- **Phase 6**: Polish and release preparation

## Contributing

Contributions are welcome. Feel free to create a new issue to discuss proposed changes.

## Acknowledgments

- The MonoGame community for their excellent framework and support
- Fighting game community for inspiration and feedback
