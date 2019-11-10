```c
waitpid(pid_t pid, int *status, int options)
```

When the process `pid` finishes, retrieves its information from the process
table and **remove the entry from the process table**.

## Status

- `WIFXXX(status)` returns true if the process terminated because of `XXX`
- `WXXX(status)` returns the `XXX` information. Must check `WIFXXX(status)`
  first!
