# EzPzEncrypt
EzEncrypt but with a slightly more complex algorithm (i think) and in C#
going to add decrypt algo soon, you can see where i'm up to on it, but should be done by next week

Encryption works by taking plaintext, converting each char to ascii value, mulitplying by a random number (between 10 and 100) then adding that random number, then converting that int back to a char using the ascii values from before. the orignal random number is then converted to a string, and each char is sepeterated, multiplyed by 42 and then added to the end of the string of encrypted text, this way the key is transfered with the text

Understand it's not secure at all compared to any other actual encryption algo, since it's symmetric, and effectively just a substitution cipher, but it's a fun little project
