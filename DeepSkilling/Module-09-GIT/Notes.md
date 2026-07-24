# Module 09 - Git Notes

## What is Git?

Git is a distributed version control system that helps developers track changes in source code, collaborate with team members, and maintain project history.

---

# Advantages of Git

- Tracks file changes
- Supports collaboration
- Enables branching and merging
- Maintains complete project history
- Allows rollback to previous versions
- Integrates with GitHub and GitLab

---

# Basic Git Workflow

Working Directory
        ↓
git add
        ↓
Staging Area
        ↓
git commit
        ↓
Local Repository
        ↓
git push
        ↓
Remote Repository (GitHub)

---

# Common Git Commands

## Configure Git

```bash
git config --global user.name "Your Name"
git config --global user.email "email@example.com"
```

## Verify Configuration

```bash
git config --list
```

## Initialize Repository

```bash
git init
```

## Check Status

```bash
git status
```

## Add Files

```bash
git add .
```

or

```bash
git add filename
```

## Commit Changes

```bash
git commit -m "Commit message"
```

## View Commit History

```bash
git log
```

```bash
git log --oneline
```

---

# Remote Repository Commands

## Add Remote

```bash
git remote add origin <repository-url>
```

## View Remote

```bash
git remote -v
```

## Push

```bash
git push origin master
```

## Pull

```bash
git pull origin master
```

---

# Branching Commands

Create Branch

```bash
git branch GitNewBranch
```

List Branches

```bash
git branch
```

List Local and Remote Branches

```bash
git branch -a
```

Switch Branch

```bash
git checkout GitNewBranch
```

Create and Switch

```bash
git checkout -b GitWork
```

Delete Branch

```bash
git branch -d GitWork
```

---

# Merging

Merge another branch into the current branch.

```bash
git merge GitNewBranch
```

---

# Comparing Changes

Compare two branches

```bash
git diff master GitNewBranch
```

---

# Merge Conflict

A merge conflict occurs when two branches modify the same part of a file.

Conflict markers:

```text
<<<<<<< HEAD
Current branch changes
=======
Incoming branch changes
>>>>>>> BranchName
```

Resolve the conflict by editing the file, then:

```bash
git add filename
git commit -m "Resolved merge conflict"
```

---

# .gitignore

Used to prevent unwanted files from being tracked.

Example:

```
*.log
*.bak
log/
bin/
obj/
```

---

# Useful Commands

Current Branch

```bash
git branch
```

View Graph

```bash
git log --oneline --graph --decorate
```

View Complete Graph

```bash
git log --oneline --graph --decorate --all
```

Clone Repository

```bash
git clone <repository-url>
```

Remove File

```bash
git rm filename
```

Rename File

```bash
git mv oldname newname
```

---

# Git Lifecycle

Create Repository
        ↓
Add Files
        ↓
Stage Files
        ↓
Commit Changes
        ↓
Create Branch
        ↓
Modify Files
        ↓
Merge Branch
        ↓
Resolve Conflicts
        ↓
Push to GitHub

---

# Key Concepts

- Repository
- Commit
- Branch
- Merge
- Merge Conflict
- Staging Area
- Working Directory
- Remote Repository
- Origin
- HEAD
- GitHub
- .gitignore

---

# Learning Outcome

Completed hands-on exercises involving Git repository creation, GitHub integration, file tracking, branch management, merge conflict resolution, remote synchronization, and repository maintenance using Git and GitHub.