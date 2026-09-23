start cmd /k "cd /d %~dp0BackendRandomizer\BackendRandomizer && dotnet run --launch-profile https"
start cmd /k "cd /d %~dp0FrontendRandomizer && npm.cmd run dev"