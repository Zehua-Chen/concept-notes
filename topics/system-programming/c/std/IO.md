```c
getchar()
```

Read a character from stdin

- Character can be `EOF`, end of file

```c
putchar(int)
```

Print a character to stdout

```c
puts(ptr)
```

Print a string to stdout, with an `\n` at the end

```c
gets(ptr)
```

Reads a string (until `EOF`) from the command line

- If the input string is bigger than the pointer can hold, then bad
  things can happen

```c
int sscanf(str, format, ptrs...)
```

Parse variables specified in format from a string and store them into
the location pointed to by pointers

- **Whatever comes format must be pointers**;
- Returns the number of variables parsed;
- To prevent string overflow **use `\%xs%` where `x` is the number of
  characters that should be parsed**; - **`x` should be one less than what the pointer can holds**, for `\0` - if the input **string contains a string whose length is bigger than `x`**,
  then the string variable is **not considered to be successfully parsed**;

```
scanf(...)
```

Works the same as `sscanf`

- `scanf(...)` parse from standard in
