﻿using CarRentalCommon.Enums;
using CarRentalCommon.Interfaces;

namespace CarRentalData.Interfaces;

public interface IData
{
    IEnumerable<IBooking> GetBookings();
    IEnumerable<ICustomer> GetCustomers();
    IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default);
}
