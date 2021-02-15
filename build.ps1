dotnet run --project build/Build.csproj -- -w $(pwd) -v Diagnostic $args
exit $LASTEXITCODE;