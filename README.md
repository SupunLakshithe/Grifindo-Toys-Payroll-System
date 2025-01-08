# Grifindo Toys Payroll System

A comprehensive payroll management system developed for Grifindo Toys using C# and Windows Forms. The system handles employee management, salary calculations, attendance tracking, and administrative settings.

## Features

### Employee Management
- Add, update, and delete employee records
- Track employee details including name, NIC, phone number, branch, and job type
- Manage employee allowances and overtime rates

### Payroll Processing
- Automated salary calculations
- Support for overtime hours
- Tax deductions
- Allowance management
- No-pay leave calculations
- Generate salary reports

### Attendance Management
- Track employee absences
- Manage leave requests
- Record overtime hours
- Configurable maximum absence limits

### Administrative Features
- Job type management with customizable salary scales
- Branch management
- Configurable tax rates and other system settings
- Cycle-based payroll processing
- User authentication system

## Screen Shots

![image](https://github.com/user-attachments/assets/a339911f-e7e3-468d-a16b-f793f337d891)
![image](https://github.com/user-attachments/assets/2472eded-6852-4f0a-b85f-635b2043f4ed)
![image](https://github.com/user-attachments/assets/c26eda46-fc35-47b5-ac9e-d77f481a16e0)

Database Diagram:-
- ![image](https://github.com/user-attachments/assets/1eeb9939-2be4-4ecb-b0af-bb2d31e125cb)


## Technical Details

### Requirements
- Windows Operating System
- .NET Framework
- SQL Server Express
- Visual Studio (for development)

### Database Configuration
The system uses SQL Server with the following connection string:
```
Data Source=LAPTOP-LENOVOI5\\SQLEXPRESS;Initial Catalog="Grifindo Toys";Integrated Security=True
```

### Project Structure
- `Admin_setting.cs` - Administrative settings management
- `Admin_Home.cs` - Main administrator dashboard
- `Admin_employee.cs` - Employee management interface
- `Employee.cs` - Employee class definition and operations
- `Salary.cs` - Salary calculation and processing
- `db.cs` - Database operations and connectivity
- Other supporting classes for specific functionalities

## Installation

1. Clone the repository
2. Open the solution in Visual Studio
3. Restore NuGet packages if required
4. Update the database connection string in `db.cs` to match your SQL Server instance
5. Build and run the application

## Usage

1. Launch the application
2. Log in with administrative credentials
3. Use the main dashboard to access different modules:
   - Employee Management
   - Salary Processing
   - Attendance Management
   - System Settings

## Security Features
- User authentication system
- Role-based access control
- Secure database operations
- Input validation and error handling

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- Developed for Grifindo Toys
- Built using Microsoft .NET Framework
- Uses Windows Forms for the user interface
- SQL Server for database management

## Contact

Supun Lakshithe - [slsomarathna47@gmail.com](mailto:slsomarathna47@gmail.com)

Project Link: [https://github.com/SupunLakshithe/Grifindo-Toys-Payroll-System](https://github.com/SupunLakshithe/bus-seat-reservation-system)
