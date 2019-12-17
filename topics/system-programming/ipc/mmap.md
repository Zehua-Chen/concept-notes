```c
void *
mmap(void *addr, size_t len, int prot, int flags, int fd, off_t offset);
```

- Can only map to
  - Files
  - Physical storage
  - Shared objects
  - **NO** pipes
  - **NO** sockets
- Loads memory lazily
  - No loading upon initial mapping
- **Use file streams** if most **reads are performed sequentially**

# ANON Mapping

`mmap` that does not map to files.

- Can be used to create shared memory between parents and children
- Enable using `MAP_ANON`
- To enable memorying sharing, use `MAP_SHARED`
- Some mallocs implementations using `mmap` on each allocation
