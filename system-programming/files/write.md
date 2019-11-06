# `write(file, ptr, byte)`

Write x byte of a pointer to a file, described by a file descriptor.

## File Descriptor

A file descriptor is esentially an integer id of a file. Can be created using
`open`.

### Standard Descriptors

- standard output: `STDOUT_FILENO`
- standard error: `STDERR_FILENO`

Only standard output can be directed to files

- standard error will be shown when the program is piped into a file
