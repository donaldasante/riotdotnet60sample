# Riot js V6.x and dotnet core V6.x web api starter template
This is a dot net core 6.x web api backend with a [riot js v6.xx](https://riot.js.org/) frontend SPA template. 
- [VueCliMiddleware](https://github.com/EEParker/aspnetcore-vueclimiddleware) module to add riot cli support to a dot net core project.
- [FastEndpoints](https://fast-endpoints.com/wiki/Get-Started.html) module which is built on top of the dot net 6.x minimal api functionality.
- Supports hot module reloading. So changes made to CSS/JS code is instantly recompiled and updated on the browser for faster app development.
- Docker support. Create a production ready docker image for deployment. 

## Requirements
- [Visual Studio 2019 or 2022 Community Edition](https://visualstudio.microsoft.com/vs/whatsnew/) .
- [dot net core 6.x](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
- [node js >= version 16.14.0](https://nodejs.org/en/)
- [npm >= 8.5](https://www.npmjs.com/get-npm) which is normally bundled with nodejs.

## Installation
- Open your favorite CLS (Command Line Shell).
- Navigate to your chosen installation folder.
- Enter the command to install the latest riot.dotnet template on your local PC
```bash
$ dotnet new --install riot.dotnet.six
```
- The following output is shown
![Output of dot net new command](https://raw.githubusercontent.com/donaldasante/riotdotnet60sample/main/images/pic1.png?raw=true "Output of dot net new command")

- To create a new project based off the template. Type dotnet new riot-dotnet6 -n {ProjectName}. 
```bash
$ dotnet new riot-dotnet6 -n Demo
```

## Running the demo project
- Open the demo project in Visual Studio. 
- Click on the green run button.
- Assuming all the requirements are met visual studio will
  1. Build the dot net core app.
  2. Run npm install
  3. Start the application
  
## Running demo application in docker
- Make sure you have docker desktop (Win, Mac, Linux) installed.
- Open CLS 
- Goto riot application install folder containing Dockerfile.
- To create a new docker image. Type docker build -t {img-name}. This command will read the Dockerfile and create a dotnet core/ riot SPA ready to run image.
```bash
$ docker build -t demo-riot-web-api-img-60 .
```
- To run the newly created image. Type docker run -d -p {host-port}:{container-port} --name {container-name} {img-name}
```bash 
docker run -d -p 5000:80 --name demo-riot-dotnet-ui-60 demo-riot-web-api-img-60
```
- Open any browser and goto http://localhost:5000. If the host port is not 5000 then use the port configured in the previous command.