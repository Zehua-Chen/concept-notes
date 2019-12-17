# `sizeof`

sizeof can be used in two cases

- when used with types or variables, `sizeof` gives the size of the variable, or
  type in bytes - **Note** stack allocated arrays are not considered to be
  pointers, therefore `sizeof` does not give 8 or 4, instead, it gives **the
  number of bytes array would take up**.

- when used with string literals, `sizeof` gives the length of the string,
  **counting the trailing `\0` character** - **Note**: `sizeof` does not stop at
  `\0` in the middle of the string, like `strlen` will
