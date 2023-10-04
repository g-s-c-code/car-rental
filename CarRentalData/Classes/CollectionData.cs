﻿using CarRentalCommon.Classes;
using CarRentalCommon.Enums;
using CarRentalCommon.Interfaces;

namespace CarRentalData.Classes
{
    public class CollectionData : IData
    {
        private readonly Dictionary<Type, object> _data = new();
        private readonly HashSet<string> _checkForDuplicates = new();

        public CollectionData() => SeedData();

        public IEnumerable<T> Get<T>() where T : class => GetOrCreateList<T>();

        public T Single<T>(Func<T, bool> predicate) where T : class => GetOrCreateList<T>().Single(predicate);

        public void Add<T>(T entity) where T : class
        {
            CheckForDuplicates(entity);
            GetOrCreateList<T>().Add(entity);
        }

        void SeedData()
        {
            var customers = GetOrCreateList<IPerson>();
            var vehicles = GetOrCreateList<IVehicle>();

            Add<IPerson>(new Customer("891010-0168", "Charlie", "Sharp"));
            Add<IPerson>(new Customer("690830-8572", "Visilia", "Studiya"));
            Add<IPerson>(new Customer("821003-6612", "Blaine", "Bootstrap"));

            Add<IVehicle>(new Car("AND243", "Porche", 5500, 1f, VehicleType.Touring, 2));
            Add<IVehicle>(new Car("AWL853", "Ford", 6000, 1f, VehicleType.Touring, 0));
            Add<IVehicle>(new Car("PQZ552", "Duesenberg", 1000, 1.5f, VehicleType.Luxury, 2));
            Add<IVehicle>(new Car("VUQ516", "Buick", 5600, 1f, VehicleType.Convertible, 2));
            Add<IVehicle>(new Car("IEN716", "Chevrolet", 2950, 1f, VehicleType.Hardtop, 2));
            Add<IVehicle>(new Car("ENN712", "Chevrolet", 9700, 1f, VehicleType.Convertible, 2));
            Add<IVehicle>(new Motorcycle("MBU852", "Yamaha", 8780, 0.5f, VehicleType.Standard, 1));
            Add<IVehicle>(new Motorcycle("WCK661", "Benelli", 7370, 0.5f, VehicleType.Standard, 2));

            Add<IBooking>(new Booking(vehicles[5], customers[0]));
            Add<IBooking>(new Booking(vehicles[6], customers[1]));
            Add<IBooking>(new Booking(vehicles[7], customers[2]));
        }

        private void CheckForDuplicates<T>(T entity) where T : class
        {
            if (entity is IVehicle v && !_checkForDuplicates.Add(v.RegNo))
                throw new ArgumentException($"Vehicle with RegNo {v.RegNo} already exists.");

            if (entity is IPerson c && !_checkForDuplicates.Add(c.SSN))
                throw new ArgumentException($"Customer with SSN {c.SSN} already exists.");
        }

        private List<T> GetOrCreateList<T>() where T : class
        {
            Type actualType = typeof(T);
            if (!_data.TryGetValue(actualType, out var list))
            {
                list = new List<T>();
                _data[actualType] = list;
            }
            return (List<T>)list;
        }
    }
}
