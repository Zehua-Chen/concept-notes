Remote procedure call appear like functions, but may be executed remotely:

- Different process
- Different machine

# Overhead

RPC introduce the following overheads

- Marshalling
- Unmarshalling
- Error handling
- Authentication
- Heap allocation

# Motivations

- Priviledge separation
  - JavaScript interpreter
  - File system access
- Remote machines have more computing powers

# Dummy Implementation

```cpp
char *GetName(int key) {
  write(fd, "getname:", 8);
  write(fd, &key, sizeof(key));

  read(fd, &length, sizeof(size_t));

  char *result = malloc(length);
  read(fd, result, length);

  return result;
}
```

# Communication with the Remote

- **Stub code**: code that transfers information across the network
- **Server stub code**: stub code on the server
- **Marshalling**: the process of serializing information for transmission
  to remote locations
- **Unmarshalling**: the process of deserializing information from remote
  transmissions

## Marshalling Options

- **Binary**
  - Does not work well across architectures
- **ASCII** representation is
  - Network hog, more bytes to send
  - CPU hog, have to parse the number
- Floating points:
  - **IEEE**
- Structured data:
  - **Google Protocol Buffers**
    - Generate code to multiple languages
    - Versioning (default values for missing fields)
  - **JSON**
    - Readable
    - Dynamic: no requirements for fields
  - **XML**
    - Wordy (openning and closing tags)
    - More resources to send
    - Allows valid relationships between tags
    - Tags can carry attributes

# IDL

IDLs are domain specific languages that describe the RPCs.
