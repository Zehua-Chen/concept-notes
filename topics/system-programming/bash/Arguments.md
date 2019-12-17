# Arguments

```c
int main(int argc, char * argv[]) { return 0; }
```

- `argc`: number of arguments;
- `argv`: an array of arguments where each argument is a string;
  - `argv` has `argc + 1` elements, though the last element is always `NULL`;

## Execution Name

`argv[0]` is always the execution name (including path) of the program,
therefore, `argc` is always bigger than 0, and `argv[0]` is always valid.
