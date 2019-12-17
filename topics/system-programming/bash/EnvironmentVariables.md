# Read & Write in Bash

- Read: `set` display all environment variables
- Write `export KEY=VALUE` would set an environment variable

# Read in C

## `extern char **environ;`

- The array of string has a null string pointer in the end, like `argv`;
- The pointer to pointer `environ` has to be manualy declared

```c
extern char **environ;
```

## `getenv(name)`

- `getenv(name)` returns a string as the value of the environment variable whose
  key string is passed as the parameter.
