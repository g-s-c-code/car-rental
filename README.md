# Car Rental

This project serves as a practical illustration of a three-layered architecture, built in Blazor WebAssembly using HTML, CSS, Bootstrap, and C#. 

## Preview (click to enlarge)
| **Home** | **Fleet** | **Testimonials** | **About** |**Contact** |**Booking Engine** |
|:-------------------------:|:-------------------------:|:-------------------------:|:-------------------------:|:-------------------------:|:-------------------------:|
| <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/car-rental/blob/main/CarRental/wwwroot/images/Screenshots/screenshot0.png" width="300" height="160"/> | <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/car-rental/blob/main/CarRental/wwwroot/images/Screenshots/screenshot1.png" width="300" height="160"/> | <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/car-rental/blob/main/CarRental/wwwroot/images/Screenshots/screenshot2.png" width="300" height="160"/> | <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/car-rental/blob/main/CarRental/wwwroot/images/Screenshots/screenshot3.png" width="300" height="160"/> | <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/car-rental/blob/main/CarRental/wwwroot/images/Screenshots/screenshot4.png" width="300" height="160"/> | <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/car-rental/blob/main/CarRental/wwwroot/images/Screenshots/screenshot5.png" width="300" height="160"/> |

## Architecture
The application embodies a three-layered architecture:

- **Presentation Layer**: The user interface, thoughtfully designed with HTML, CSS, Bootstrap 5.3, and Blazor WebAssembly, facilitates seamless interactions for adding vehicles and customers, viewing current bookings, and managing vehicle rentals.
- **Business Logic Layer**: Addresses tasks such as adding a new vehicle, validating customer data, and overseeing the processes of vehicle rentals and returns.
- **Data Access Layer**: Initially bootstrapped with in-memory collections, the application now harnesses a `.json` file for seeding data, thus simulating a more realistic data storage environment, yet maintaining its lightweight nature. Future versions aim to integrate a more comprehensive storage solution.

## Features
- **Data Seeding**: With a transition from in-memory seed data, the application now uses a `.json` file to seed its initial data, making it more extensible and manageable.
- **List Management**: Enables users to view current bookings, available vehicles, and registered customers.
- **Add Vehicles and Customers**: Intuitive forms support users in adding cars, motorcycles, and customers.
- **Rent & Return**: Streamlines the process for renting and returning vehicles.
- **Simple Validation**: Implements checks on customer details to ensure alignment with expected formats.
- **Toggle Instructions**: An inclusive guide caters to users who may be new to the system.

## How to Use
1. **Start the App**: The initial view displays available vehicles, current bookings, and registered customers.
2. **Adding**: Users can populate the provided forms with details of a new car, motorcycle, or customer.
3. **Renting**: The application allows users to select a vehicle and a customer to initiate a rental transaction.
4. **Returning**: Post rental, the system offers an option to register the vehicle as returned.

### Note:
The application has evolved from using in-memory SeedData to employing a `.json` file as its data placeholder. Future versions have aspirations to integrate with a more robust data storage solution.
