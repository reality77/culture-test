# Reproduce date & time culture issue in docker container

## Preparation

1. Compile the project

2. Build the docker image

`docker build -t culture-test .`

## Test the issue

### Works fine with dotnet run

```sh
$ dotnet run
Bonjour, le jour est dimanche
```

> This is the expected behavior 

### Issue appears with docker

```sh
$ docker run culture-test
Bonjour, le jour est Sunday
```

> Here the day of week is displayed in english, though the current culture is french
