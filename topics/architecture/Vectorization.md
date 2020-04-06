# Vectorization

For a loop to be vectorized, its semantics must not change, that is,

- The data dependecy between loops must not be broken after vectorization.
- There is no aliasing problem

Whether or not compilers vectorize vectorizable code differs from language
to language and from compilers to compilers

# Data Dependency

## Read after Write

The address is read after being written to.

- **Not vectorizable** if the interval between read and write is smaller than
  the size of SIMD operations

```cpp
int a[5] = {0,1,2,3,4};
int b[5] = {5,6,7,8,9};

for (i=1; i<5; i++) {
  a[i] = a[i-1] + b[i];
}
```

## Write after Read

The address is written after it is read

- **Always vectorizable**

## Write after Write

The address is written to twice

- Can become undefined behavior if vectorized
- **Not vectorizable** if the interval between the writings is smaller than
  the size of SIMD operations

## Read after Read

- **Always vectorizable**

## Aliasing

If the memory of two pointers overlap, then there is dependency issues that
may or may not be solvable
