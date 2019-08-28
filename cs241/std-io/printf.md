# `printf`

`printf` has a buffer that is only to be flushed using the `write` system call
when
- The input string has `\n`;
- The buffer is full;