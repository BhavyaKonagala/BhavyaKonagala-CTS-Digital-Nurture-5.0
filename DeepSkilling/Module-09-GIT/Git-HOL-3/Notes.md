# Git HOL 3 Notes

## Branching

A branch allows independent development without affecting the main branch.

## Common Commands

Create Branch

```bash
git branch GitNewBranch
```

List Branches

```bash
git branch -a
```

Switch Branch

```bash
git checkout GitNewBranch
```

Commit Changes

```bash
git add .
git commit -m "Added new file"
```

Switch Back

```bash
git checkout master
```

Compare Branches

```bash
git diff master GitNewBranch
```

Merge Branch

```bash
git merge GitNewBranch
```

View History

```bash
git log --oneline --graph --decorate
```

Delete Branch

```bash
git branch -d GitNewBranch
```

## Learning Outcome

Learned Git branching, merging, comparing branches, and deleting merged branches.