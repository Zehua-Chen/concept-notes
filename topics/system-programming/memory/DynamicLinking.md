# Global Pointers

Dynamic libraries have no fixed location in memory, therefore the global
pointers in dynamic libraries must only be **stored as place holders during
build time**, and **written with values during load time**. This **dirties the
memory and cuts the connection between the memory and on storage of the library
on disk**. This behavior results in the following side effects

- Lower start up time (linker has to side pointers)
- Increased memory usage; different process cannot share metadata pages because
  they are now dirty
- Increased file size; relocations have be recorded on disk
- All process pay for all meta-data, no matter if they are used
- 64-bit pointers are big
- ASLR (everything is relative) causes even the executable to have the above
  issues

**Solution**: [relative pointers](https://www.youtube.com/watch?v=G3bpj-4tWVU)
