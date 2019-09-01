# Struct

## Syntax

```c
struct Name {
    // Contents
};

struct Name name;
```

- Without using typedefs or macros, the `struct` keywords must be used
everytime to declare a struct;

## Syntax Using Typedefs

```c
typedef struct Name name_t;
name_t name;
```

```c
typedef struct {
    // Contents
} Name;

Name name;
```