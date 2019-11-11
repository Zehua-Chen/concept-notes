# Pages

A page is a block of memory where data of a process is stored.

- A page only belongs to a single process
- A process can have many pages

# Directories, Tables and Pages

In a two-level virtual memory system, directories, tables and pages
are laied out in the following order

- Directories
  - Tables
    - Pages

# Addressing

In two-level virtual addressing, an address is split into the following
components

- **Page directory offset**: used to find a table in a directory
  associated with a process
- **Page table offset**: used to find a page in a table
- **Page offset**: used to find acutal data in a page

**Note that the number of bits used for offsets ideally would match
the exact number of bits used to index a single page table.**

# TLB

The translation lookaside buffer is a CPU component that cache a lookup
table with the keys being a virtual addresses and the values being the
beginning of pages.

- A TLB is faster than a memory management unit
- TLBs need to be flushed when the executing process changes (context
  change)

When a virtual address is lookedup, the TLB and the memory management unit
will both be queried for the virtual address, if the TLB contains
the page address, then TLB's response will be used. If TLB did not
find anything, then the memory management unit will provide
the page address.