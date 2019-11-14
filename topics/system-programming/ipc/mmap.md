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
