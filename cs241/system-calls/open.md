# open(path, flags, mode)

Open a file at a specified path with flags, if create the file, use "mode".
When done with the file, use `close(descriptor)` to flush the content;

## Returns

Returns a file descriptor, value is the lowest unused file descriptor
(including standard output and standard error).

Returns `-1` if fails `errno`