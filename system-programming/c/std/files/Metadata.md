# File Size

1. Go to the end of file using `fseek(file, 0, SEEK_END)`
2. Get the index of the last bit of the file using `ftell(file)`

# File Number

```c
int fileno(FILE *)
```

Returns the file descriptor of a file.

- This is not part of the standard C library; needs `_GNU_SOURCE` or
  `_POSIX_SOURCE` to use
