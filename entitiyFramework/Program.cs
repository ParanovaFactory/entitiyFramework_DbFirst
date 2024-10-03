using entitiyFramework.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitiyFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbVisitEntities dbVisitEntities = new DbVisitEntities();
            void list()
            {
                var values = dbVisitEntities.TblPersons.ToList();
                foreach (var value in values)
                {
                    Console.WriteLine(value.personId + " " + value.personName + " " + value.personCity);
                }
            }

            //TblPerson tblPerson = new TblPerson();
            //tblPerson.personName = Console.ReadLine();
            //tblPerson.personCity = Console.ReadLine();
            //dbVisitEntities.TblPersons.Add(tblPerson);
            //dbVisitEntities.SaveChanges();
            //list();

            //list();
            //int id = int.Parse(Console.ReadLine());
            //string name = Console.ReadLine();
            //string city = Console.ReadLine();
            //var valueUpdate = dbVisitEntities.TblPersons.Find(id);
            //valueUpdate.personName = name;
            //valueUpdate.personCity = city;
            //dbVisitEntities.SaveChanges();
            //list();

            //list();
            //int id = int.Parse(Console.ReadLine());
            //var valueDelete = dbVisitEntities.TblPersons.Find(id);
            //dbVisitEntities.TblPersons.Remove(valueDelete);
            //dbVisitEntities.SaveChanges();
            //list();

            //var query = dbVisitEntities.TblPersons.Where(x => x.personId == 1).ToList();
            //foreach (var value in query)
            //{
            //    Console.WriteLine(value.personName + " " + value.personCity);
            //}

            //string country = Console.ReadLine();
            //var query = dbVisitEntities.TblCountries.Where(x => x.countryName == country).ToList();
            //foreach (var value in query)
            //{
            //    Console.WriteLine(value.countryName + " " + value.countryCapital);
            //}

            //int departure = int.Parse(Console.ReadLine());
            //int arrival = int.Parse(Console.ReadLine());
            //var query = dbVisitEntities.TblFlights.Where(x => x.flightDeparture == departure && x.flightArrival == arrival).ToList();
            //foreach (var value in query)
            //{
            //    Console.WriteLine(value.flightPrice + " " + value.flightDate);
            //}

            //int departure = int.Parse(Console.ReadLine());
            //int arrival = int.Parse(Console.ReadLine());
            //var query = dbVisitEntities.TblFlights.Where(x => x.flightDeparture == departure || x.flightArrival == arrival).ToList();
            //foreach (var value in query)
            //{
            //    Console.WriteLine(value.flightPrice + " " + value.flightDate);
            //}

            //var query = dbVisitEntities.TblFlights.Count();
            //Console.WriteLine(query);

            //var query = dbVisitEntities.TblFlights.Sum(x => x.flightPrice);
            //Console.WriteLine(query);

            //var query = dbVisitEntities.TblFlights.Average(x => x.flightPrice);
            //Console.WriteLine(query);

            //var query = dbVisitEntities.TblFlights.Sum(x => x.flightPrice * x.flightCapacity);
            //Console.WriteLine(query);

            //var query = dbVisitEntities.TblCountries.Where(x => x.countryName == "Italy").Select(y => y.countryId).FirstOrDefault();
            //var location = dbVisitEntities.TblFlights.Where(x => x.flightDeparture == query).ToList();
            //foreach(var value in location)
            //{
            //    Console.WriteLine(value.flightPrice + " " + value.flightDate);
            //}

            var location = dbVisitEntities.TblFlights.Where(x => x.flightDeparture == (dbVisitEntities.TblCountries.Where(y => y.countryName == "Italy").Select(y => y.countryId).FirstOrDefault())).ToList();
            foreach (var value in location)
            {
                Console.WriteLine(value.flightPrice + " " + value.flightDate);
            }
        }
    }
}
