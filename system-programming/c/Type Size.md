# Type Size

- C standard does not enforce the numbers of bits of types (eg. `int`, `long`),
except `char`; instead, the standard requires a minimum number of bits;
    - Ints are required to be at least 16 bits in size;
- Maximum and minimum values of number types are defined in `limits.h`;
- A character is exactly one byte (not necessarily 8 bits, see below);
    - `CHAR_BITS` provides the number of bits used to implement a a `char`

## Byte

- C standard does not require a byte to be 8 bits;
