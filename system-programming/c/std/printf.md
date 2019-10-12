# `printf`

## stdout and stderr

`printf` only flush (`write`) to to stdout when

- The input string has `\n` in terminal environment;
- The buffer is full;

`printf` does not buffer and always flush to stderr
