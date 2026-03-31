CyberGuard (Part 1)

Project Overview:
This project is a console-based chatbot developed in C# for Programming 2A (PROG6221).
The purpose of the chatbot is to educate users about basic cybersecurity concepts such as password safety, phishing, and safe browsing through simple interaction.

Features:
-Plays a voice greeting using a WAV file when the application starts
-Displays ASCII art (CyberGuard shield) with coloured console output
-Prompts the user for their name and personalises responses
-Responds to basic cybersecurity questions (passwords, phishing, safe browsing, purpose)
-Handles invalid or empty input using input validation

Project Structure:
-Program.cs: Entry point of the application and plays the audio
-Chatbot.cs: Contains the chatbot logic and conversation flow
-User.cs: Stores user information (name)
-UIHelper.cs: Handles console UI and ASCII display
-CyberGuard_Greeting.wav: Voice greeting file

How to Run:
-Open the project in Visual Studio
-Ensure the WAV file properties are set as follows:
-Build Action: Content
-Copy to Output Directory: Copy if newer
-Build the solution
-Run the program using Ctrl + F5

GitHub and Version Control:
The project is uploaded to GitHub, please see below for GitHub link and youtube link.

Continuous Integration (CI):
-GitHub Actions is configured to build the project on each push
-The workflow checks that the project builds successfully
-A successful run is indicated by a green check mark in the Actions tab
-A screenshot of the CI run is included, although I'm unsure on how to get it to run properly.

Video Presentation
A video demonstration of the application is included, explaining:
-Program functionality
-Code structure
-Voice greeting and UI features

Creator
Connaire Myall
ST10297849

GitHub Link: https://github.com/ST10297849/CyberGuard
Youtube Link: https://youtu.be/qX2a6x-hfjo

Cyberguard Shield ASCII Art:

             /\
            /  \
           /----\
          / |  | \
         /  |  |  \
        /   |  |   \
       /    |  |    \
      /_____|__|_____\
          \      /
           \    /
            \  /
             \/

