```c
ssize_t getline(**ptr, *capcity, FILE *)
```

`getline` is a POSIX extension and not i C standard. define
`_GNU_SOURCE` if `getline` is not available by default

Reads a line (including `\n` at the end) from a file stream

- Returns number of characters on the line (including a hidden `\n`)
- `ptr` is a **double pointer**; the pointer it points to will hold the
  line after returns;
- `capactiy` should be a **pointer** that represent how large
  the pointer pointed to by `ptr` can hold
- `FILE *`: a file stream to read a line from
- Be sure to **initialize `ptr` and `capacity` to default values**;
- `ptr` and `capactiy` can be reused for future `getline` calls
  to conserve memory;
- **`ptr` points to heap allocated memory, be sure to `free`**

```c
fscanf(FILE *, char *, args...)
```

Parse from a file stream
