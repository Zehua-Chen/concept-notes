# Types of Encryptions

## Symmetric Encryptions

A single key is used to both encrypt and decrypt the message

- Not secure as the key can be intercepted

## Asymmetric Encryptions

- The reciever has two keys
  - **Public Key**: given to the sender to encrypt the message
  - **Private Key**: kept securely to decrypt the message
  - Generated using RSA algorithms
  - Two keys are mathmetically related, but having one key does not lead to
    having the other key
- The sender use the **public key** of the receiver to encrypt the message
  - Only the receiver with the corresponding private key can view the message
- **Algorithms**
  - **RSA**: RSA function can't accomodate messages that are longer than the
    key; we solve that problem with block cipher modes

### Signature

Signatures are used to ensure integrity (the data received is not tempered
with). To create a signature:

1. **Decrypt** the message using the private key to get the signature
2. **Encrypt** the signature using the public key (given to the receiver).
3. The result from step 2 should equal the original message if integrity is
   maintained

As RSA function cannot process long messages, we use a hash of the message
instead (decrypt the hash, encrypt the signature and compare hashes)

# Hashes

- SHA256 hasing cannot practically produce collisions
  - Collisions are only theoretically possible
