// See https://aka.ms/new-console-template for more information
using ConsoleApp1;


// Usage
King kralj1;
kralj1= King.getInstance();
King kralj2;
kralj2 = King.getInstance();

if(kralj1==kralj2)

Console.WriteLine("Postoji samo jedan kralj!");  // Da li su vracene 2 iste instance iz klase, odnosno da li postoji samo jedan kralj?
