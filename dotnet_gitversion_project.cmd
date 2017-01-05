@setlocal
@pushd %1
@shift
dotnet gitversion
dotnet %1 %2 %3 %4 %5 %6 %7 %9
@popd
@endlocal