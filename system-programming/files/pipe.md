# `pipe(fds)`

## `pipe2(fds, flags)`

Same to `pipe`, but can take optional flags:
- `O_CLOEXEC`: when a process is cloned, all of its file descriptors are
also cloned; this flag would close all file descriptors inherited from
a parent process upon `exec`