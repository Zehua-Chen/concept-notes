# Transportation Protocols

Transportation protocols determine how data are sent between points on a
network, including

- Segmentation
- Acknoledgement
- Multiplexing

## UDP (User Datagram Protocol)

### Characteristics

- Connectionless (send and don't chare if the target can be reached)
- Very limited error correction
- Limited in transmission size, the bigger the transmission, the easier it would
  drop
- Use this if the application **prefer to handle missing packets over late
  packets**

## TCP (Transmission Control Protocol)

### Characteristics

- Takes up more system resources
- Connection based (connect first, and then send)
  - **Performs handshake** first
- Flow control
- Resend lost packets
- 2 way
- Can be used with `read`, `write` system calls

### Handshaking Process

A **round trip** refers to a message to **get from client to server and back to
client**.

1. SYN (client to server)
2. SYN-ACK (server to client)
3. ACK (client to server)

Meaninful data can be sent as early as the third step "ACK":
