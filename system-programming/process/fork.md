# `fork()`

- Copies everything of a process's address space (including kernel context)
- Open file handles are the only things shared between forks()
  - Open file handles is shared across the OS; file descriptor table is local
    to the process
