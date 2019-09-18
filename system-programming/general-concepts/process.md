# Process

## Orphans and Zombies

- A zombie is a process that is killed, but has not been waited by
its parent process, thereby causing **its entry in the process table
to not be removed**. (**Killed, but still around**)
    - All well-behaving user process would enter this stage shortly after
    they exit, before their parents `wait` them

- An orphan process is a process whose parent has exited. On Linux and Unix,
these types of processes immediately uses the `init` process as their parent.
    - The `init` process periodically `wait` its children (some of which are
    zombies)
    - A **long-living zombie process** can only be created when **the parent
    has neither exit nor wait, but the children has already exited**

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

## `waitpid(pid_t pid, int *status, int options)`

When the process `pid` finishes, retrieves its information from the process
table and **remove the entry from the process table**.

### Status

- `WIFXXX(status)` returns true if the process terminated because of `XXX`
- `WXXX(status)` returns the `XXX` information. Must check `WIFXXX(status)`
first!

## `getpid()`

Get the PID (process identifier) of the current process.

## `getppid()`

Get the PID of the parent.