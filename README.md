# Discord Rich Presence
[![GitHub stars](https://img.shields.io/github/stars/0xhylia/Discord-Rpc.svg)](https://github.com/0xhylia/Discord-Rpc/stargazers)
[![GitHub license](https://img.shields.io/github/license/0xhylia/Discord-Rpc.svg)](https://github.com/0xhylia/Discord-Rpc/blob/master/LICENSE)

This is a simple Discord Rich Presence application that displays the user's current activity in Discord.

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
To run this application you need the following:
- .NET 6 SDK
- A Discord Developer Account

### Installing
1. Clone the repository: `git clone https://github.com/0xhylia/Discord-Rpc.git`
2. Open the cloned repository in your IDE of choice.
3. Update `client_id` in `appsettings.json` with your Discord application's client ID.
4. Build and run the project.

## How it Works
This application uses Discord's Rich Presence SDK to update the user's Discord status. It tracks the user's currently active application and displays the application's name, window name, image key, app detail, and full app name in the user's Discord status. The user can also add a website and a Discord bot to their status by clicking the "Website" and "Discord Bot" buttons.

## Authors
- **[VtHylia](https://twitter.com/VtHylia)** - *Initial work*

## Acknowledgments
- [Discord Rich Presence SDK](https://discord.com/developers/docs/rich-presence/overview)
- [Stack Overflow](https://stackoverflow.com/) for answering programming questions
