# `time.h`

```c
time_t time(time_t *t);
```

- `t` pointer can be null;

```c
char *ctime(const time_t *timep);
```

- Convert a time to a human readable string representation of the time;
- The pointer returned will **point to static storage**:
  - Don't free the pointer
  - The next time the function is called, the pointer's content will be
    overwritten;
