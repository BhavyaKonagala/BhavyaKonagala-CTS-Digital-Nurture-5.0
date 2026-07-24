# Git HOL 1 Notes

## Git

Git is a Distributed Version Control System used to track source code changes.

---

## Check Git Installation

```bash
git --version
```

---

## Configure Username

```bash
git config --global user.name "Your Name"
```

---

## Configure Email

```bash
git config --global user.email "youremail@example.com"
```

---

## Verify Configuration

```bash
git config --list
```

---

## Configure Default Editor

```bash
git config --global core.editor notepad++
```

---

## Initialize Repository

```bash
git init
```

---

## Check Repository Status

```bash
git status
```

---

## Create File

```bash
echo "Welcome to Git" > welcome.txt
```

---

## Stage File

```bash
git add welcome.txt
```

or

```bash
git add .
```

---

## Commit

```bash
git commit -m "Initial Commit"
```

---

## Pull Repository

```bash
git pull origin master
```

---

## Push Repository

```bash
git push origin master
```

---

## Learning Outcome

- Configured Git
- Created Local Repository
- Added Files
- Committed Changes
- Connected Local and Remote Repository
- Pushed and Pulled Changes Successfully