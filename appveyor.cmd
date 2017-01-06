@setlocal
@set _P=%~dp0
@if "%CONFIGURATION%"=="" set CONFIGURATION=Debug
@if "%DNX_BUILD_VERSION%"=="" set DNX_BUILD_VERSION=build-private-99999.0.0

@pushd %_P%

dotnet publish .\src\AppSyndication.UserService.Web --configuration %CONFIGURATION% --version-suffix %DNX_BUILD_VERSION% --output %_P%artifacts\web
dotnet pack .\src\AppSyndication.UserService.Model --configuration %CONFIGURATION% --version-suffix %DNX_BUILD_VERSION% --output %_P%artifacts\nuget

goto :End

Fail:
echo Must provide build number.
exit /b -1

:End
@popd
@endlocal