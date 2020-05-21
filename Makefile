RUNTIME_IDENTIFIER=linux-x64

.PHONY: build
build:
	dotnet publish -r ${RUNTIME_IDENTIFIER} -c Release /p:PublishSingleFile=true
