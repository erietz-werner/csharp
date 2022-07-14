- On the main branch run `dotnet build` to build the solution
- Checkout the branch named `another_branch`
- Open the file `./Proj1/Program.cs`
- Notice that the language server reports an error that it cannot find
  a definition for the field `AnotherBranch` in the enum.
- Go to the definition of `EnumTest`.
  - Notice that there is only one field `MainBranch`
  - Navigate to the file `./Proj3/EnumTest.cs`
  - Notice that there are two fields `MainBranch` and `AnotherBranch`.
- Run `dotnet build` while on `another_branch` and notice that it fixes the
  problem from above.
- Additionally, you can checkout the `main` branch again and go to the definition of `EnumTest` in the file
`./Proj1/Program.cs` and you will see that the field `AnotherBranch` exists
while it is not actually in the enum in the file.

This was a very confusing thing to find. Not sure if it is a problem with 
[this plugin](https://github.com/Decodetalkers/csharpls-extended-lsp.nvim)
or with
[the csharp_ls language server](https://github.com/razzmatazz/csharp-language-server)
.
