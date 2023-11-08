

namespace H_W_28._10._23
{
    using System;
    using System.Collections.Generic;


    internal class Lab_Tumakov_9
    {
        static void Main(string[] args)
        {
            // EX 9.1-9.3 Updated Bank
            Console.WriteLine("Updated Bank");
            BankAccount account1 = new BankAccount(1000, AccountType.Checking);
            BankAccount account2 = new BankAccount(500, AccountType.Savings);
            account1.Deposit(500);
            account1.Withdraw(200);
            account1.Transfer(account2, 300);
            // account1.Dispose();
            // account2.Dispose();
            Console.WriteLine($"Account 1 balance: {account1.Balance}");
            Console.WriteLine($"Account 2 balance: {account2.Balance}");
            // H-W 9.1 Updated Song
            Console.WriteLine("Updated Song");
            List<Song> songs = new List<Song>();

            Song song1 = new Song("Song 'Rain'", "Author - Rainy", null);
            Song song2 = new Song("Song 'Sunrise'", "Author - Rize", song1);
            Song song3 = new Song("Song 'Tornado'", "Author - Tor", song2);
            Song song4 = new Song("Song 'Fog'", "Author - Tumakov", song3);

            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);

            foreach (Song song in songs)
            {
                Console.WriteLine("Title: " + song.Title());
            }

            if (song1.Equals(song2))
            {
                Console.WriteLine("The first and second songs in the list are equal.");
            }
            else
            {
                Console.WriteLine("The first and second songs in the list are not equal.");
            }
            Song mySong = new Song();
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
