# Git HOL 2 Notes

## What is .gitignore?

.gitignore is a file used by Git to specify intentionally untracked files and folders that Git should ignore.

## Why use .gitignore?

- Ignore log files
- Ignore temporary files
- Ignore build files
- Ignore IDE files

## Example

```
*.log
log/
```

## Verify

```bash
git status
```

Files listed in .gitignore should not appear in Git status.

## Learning Outcome

Learned how to ignore files and folders using .gitignore.