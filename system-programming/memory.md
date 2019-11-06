# Heap and Stack

## Setting Memory's Contents

```c
void memset(void *ptr, int value, size_t bytes)
```

- Set the content of a memory block (specified by pointer and bytes)
  to a specified value

## Heap

### Heap Allocation

```c
void* malloc(size_t bytes);
```

- Returns a pointer to the start of a heap memory block if it can be found;
- Returns a null pointer if there is insufficient memory;

```c
void *calloc(count, type_size);
```

- **When working with string related functions, use this instead of `malloc`
  to avoid memory errors**

### Heap Free

```c
void free(void *ptr);
```

- Put a memory block back to the heap;
- **Only have one free for every malloc**;
- Memory **freeed should not be considered valid** anymore;
- Set pointer freed to be null to **avoid dangling pointers**;
