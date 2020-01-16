using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantReservation.Data.EntityModels;

namespace RestaurantReservation.Data.EF
{
    public static class MyDbInit
    {
        public static void Run(MyContext _context)
        {
           
            if (_context.Rezervacija.Any())
            {
                return; // DB has been seeded
            }
            
            List<Soba> sobe = new List<Soba>();
            List<Korisnik> korisnici = new List<Korisnik>();
            List<Rezervacija> rezervacije = new List<Rezervacija>();


            sobe.Add(new Soba { Naziv = "Jednokrevetna"});
            sobe.Add(new Soba { Naziv = "Dvokrevetna"});
            sobe.Add(new Soba { Naziv = "Trokrevetna"});
            sobe.Add(new Soba { Naziv = "Bracna soba"});
            sobe.Add(new Soba { Naziv = "Cetverokrevetna"});
            sobe.Add(new Soba { Naziv = "Predjesnicki apartman"});
            

            korisnici.Add(new Korisnik { Ime ="Lejla", Prezime ="Spago",Mail="lejla.spago@edu.fit.ba", KorisnickiNalog = new KorisnickiNalog { KorisnickoIme = "Korisnik1", Lozinka = "test" } });
            korisnici.Add(new Korisnik { Ime = "Sejla", Prezime = "Spago", Mail = "sejla.spago@edu.fit.ba", KorisnickiNalog = new KorisnickiNalog { KorisnickoIme = "Korisnik2", Lozinka = "test" } });
            korisnici.Add(new Korisnik { Ime = "Jasmina", Prezime = "Spago", Mail = "jasmina.spago@edu.fit.ba", KorisnickiNalog = new KorisnickiNalog { KorisnickoIme = "Korisnik3", Lozinka = "test" } });
            korisnici.Add(new Korisnik { Ime = "Amina", Prezime = "Catic", Mail = "amina.catic@edu.fit.ba", KorisnickiNalog = new KorisnickiNalog { KorisnickoIme = "Korisnik4", Lozinka = "test" } });
            korisnici.Add(new Korisnik { Ime = "Melisa", Prezime = "Dzeko", Mail = "melisa.dzeko@edu.fit.ba", KorisnickiNalog = new KorisnickiNalog { KorisnickoIme = "Korisnik5", Lozinka = "test" } });


            for (int i = 0; i < 10; i++)
            {
                rezervacije.Add(new Rezervacija { Korisnik = korisnici.MyRandom(), DatumDolaska = DateTime.Now, DatumOdlaska = DateTime.Now, BrojOsoba = 5, BrojDjece = 0, BrojSoba = 1 });
            }
           
           

            _context.Soba.AddRange(sobe);
            _context.Korisnik.AddRange(korisnici);
            _context.Rezervacija.AddRange(rezervacije);
          
          

            _context.SaveChanges();
        }

      


        static readonly Random random = new Random();

        private static T MyRandom<T>(this List<T> lista)
        {
            int r = random.Next(0, lista.Count);
            return lista[r];
        }

    }
}