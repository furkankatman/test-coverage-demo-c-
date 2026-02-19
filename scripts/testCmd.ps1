
$ErrorActionPreference = "Stop"
dotnet build -c Debug
dotnet test ./test-coverage-demo-c-.Tests/test-coverage-demo-c-.Tests.csproj `
  -c Debug --verbosity normal `
  --collect:"XPlat Code Coverage" `
  --logger trx `
  --results-directory coverage
