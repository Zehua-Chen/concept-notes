# Process

## Process Layout

- string literal stored inside the readonly section of **data**;

## `fork()`

- Copies everything of a process's address space (including kernel context)
- Open file handles are the only things shared between forks()
    - Open file handles is shared across the OS; file descriptor table is local
    to the process

### Fork Exec Wait Pattern

```c
pid_t pid = fork();

if (pid == -1) { /* failed */ }
else if (pid == 0) { /* child */ exec(...); }
else { /* parent */ waid(pid); }
```

### Fork bomb

- Create too many forks
- Use `ulimit` to prevent fork bombs