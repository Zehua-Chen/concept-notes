# IO

## `getchar()`

Read a character from stdin

- Character can be `EOF`, end of file

## `putchar(int)`

Print a character to stdout

## `puts(ptr)`

Print a string to stdout, with an `\n` at the end

## `gets(ptr)`

Reads a string (until `EOF`) from the command line

- If the input string is bigger than the pointer can hold, then bad
  things can happen

## `int sscanf(str, format, ptrs...)`

Parse variables specified in format from a string and store them into
the location pointed to by pointers

- **Whatever comes format must be pointers**;
- Returns the number of variables parsed;
- To prevent string overflow **use `\%xs%` where `x` is the number of
  characters that should be parsed**; - **`x` should be one less than what the pointer can holds**, for `\0` - if the input **string contains a string whose length is bigger than `x`**,
  then the string variable is **not considered to be successfully parsed**;

## `scanf(...)` and `fscanf(stream, ...)`

Works the same as `sscanf`

- `scanf(...)` parse from standard in
- `fscanf(stream, ...)` parse from a file stream

## `ssize_t getline(**ptr, *capcity, FILE *)`

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
