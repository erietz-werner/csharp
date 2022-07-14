- GIVEN we have a c# solution with multiple projects
- AND we build the solution on one branch
- AND we checkout another branch (without rebuilding)
- WHEN we go to definition of an object from another project
- THEN source code from a different branch is displayed rather than the actual
  file contents of the current branch.

The language server gives a diagnostic error that definition does not exist
because it is using metadata from the build from the other branch.
