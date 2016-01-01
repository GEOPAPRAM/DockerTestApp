FROM microsoft/aspnet

ENV BaseUri=http://*:5000
COPY . /opt/app
WORKDIR /opt/app

EXPOSE 5000
ENTRYPOINT ["mono","DockerSelfhostWebApi.exe"]

