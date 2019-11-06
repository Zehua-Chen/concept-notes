# `exec(path, ...)`

Replace the current process image with a new process image created from
the executable file created from `path`

## Memory

Previous **allocated heap memory will not be considered as leak, even though
they are not deallocated**, as the current memory image is part of
the current system image, which is replaced during `exec`.
