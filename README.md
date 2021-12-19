# Trainee Playground

## Installation Guide - Backend

1. Install [Visual Studio Community 2019 or 2022 Edition](https://visualstudio.microsoft.com/de/vs/) for Backend development
2. Install [.NET Core 3.1 SDK - NOT runtime](https://dotnet.microsoft.com/download/visual-studio-sdks) if not installed with Visual Studio

## Installation Guide - Frontend

### With docker and dev containers

The project might be easier to setup especially if you already have docker running.
You don't need to install node or any visual studio code extension this way.

1. Install [Visual Studio Code](https://code.visualstudio.com/) for Frontend development
   1. Install remote container support extension for vs code: ms-vscode-remote.remote-containers
2. Install [Docker dektop](https://docs.docker.com/docker-for-windows/install/) for devcontainer support

### On local machine

If the above way with docker does not work the client project can be run locally aswell.

1. Install Node 14
2. Install vue cli globally: npm install -g http-server @vue/cli @vue/cli-service-global
3. Install [Visual Studio Code](https://code.visualstudio.com/) for Frontend development
   1. Install extensions: Prettier, ESLint, Vetur, Editorconfig, Html SCSS Support
   2. Optional: You could install all extensions listed in .devcontainer.json

## Start the project

### Start the backend
1. Go to backend folder -> open solution with Visual Studio
2. Start the TraineePlayground project by clicking on play button
3. Allow SSL certification messages

### Start the frontend
4. Open frontend folder with Visual Studio Code
5. Click on reopen in container on the bottom right corner if the message box pops up -> everything will be set up for the user
6. Wait until the loading icon disappears in the status bar and the container is built
6. Navigate into the app folder with the terminal (terminal => new terminal => type "cd app")
7. Type: `npm install`
8. Type: `npm run serve`
9. Open localhost:8080 in the browser -> if uyou see the hello world page everything works fine

## About the project

This project is a very basic dotnet core api and a vuejs client that can make requests to the server over axios.

There is already a greeting endpoint that communicats with the server.

## Todos

### 1. Help Sammy

Hello, i am Sammy, a trainee at the Samhammer AG. Can you please help me out.
We got a ticket from our customer stating out that "Greet from server" on the home page contains the wrong user name. It should be the user name behind "Client username" but in the screenshot we got the first line was "Client username: User_74530" and the second "Greet from server: Hello User_4529". I tried to reproduce the issue but always got similar user numbers. Also the code looks correct to me. Can you fix this issue for me?

### 2. Show a list of users

In the last refinement meeting the team discussed a userstory of the customer. It's also your next task and is discribed like that:

As a customer i want to be able to see users added to the database on a separate page.

Acceptance Criteria:
* Users are shown in a table on a new page (client)
* Users can have the folowing fields: LoginName, FirstName, LastName
* All fields are represented as column

Further infromation from refinement:
* No fancy layout required for the table - just html
* We need to add an api endpoint to create users
* No ui required for the user creation. We have swagger. That's enough for the first step (http://localhost:5000/swagger)
* We need to add an api endpoint to list all users. No search or paging required
* The dev can decide which db and framework to use, even in memory is ok. (Entity-Framework, Sqlite, etc.)