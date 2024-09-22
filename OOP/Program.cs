using OOP.OOP_Principles.Abstraction;
using OOP.OOP_Principles.Encapsulation;
using OOP.OOP_Principles.Inheritance;
using OOP.OOP_Principles.Polymorphism;

// Encapsulation: Encapsulation is the process of bundling the data (attributes) and methods
// (functions) that operate on the data into a single unit called a class. Encapsulation helps
// to hide the internal state of an object and only expose the necessary information to the
// outside world. In the example above, the BankAccount class uses encapsulation to hide the
// internal state of the object (the balance) and only expose the necessary methods (Deposit,
// Withdraw, and GetBalance) to interact with the object. This helps to protect the integrity
// of the object by preventing direct access to its internal state and enforcing the use of
// defined methods to interact with the object.

var badAccont = new BadBankAccount
{
    balance = 100
};

var account = new BankAccount();
account.Deposit(100);
account.Withdraw(50);

Console.WriteLine(badAccont.balance);
Console.WriteLine(account.GetBalance());

// Abstraction: Abstraction is the process of hiding the implementation details of an object
// and only showing the essential features of the object. Abstraction helps to simplify the
// complexity of an object by focusing on what an object does rather than how it does it. In
// the example above, the EmailService class uses abstraction to hide the details of connecting
// to an email server, authenticating, and disconnecting from the server. The SendEmail method
// provides a simple interface for sending an email without exposing the internal implementation
// details. This helps to make the code more maintainable and easier to understand by hiding
// unnecessary details from the user of the class.

var emailService = new EmailService();
emailService.SendEmail();

// Inheritance: Inheritance is a mechanism in object-oriented programming that allows a class
// to inherit properties and behavior from another class. Inheritance helps to promote code
// reusability by allowing classes to share common attributes and methods. In the example above,
// the Vehicle class defines common properties and methods for vehicles, and the Car class inherits
// these properties and methods. The Car class can then add additional properties and methods specific
// to cars without duplicating the common code. This helps to reduce code duplication and promote
// code reusability.

var car = new Car
{
    Brand = "Toyota",
    Model = "Corolla",
    Year = 2020
};
car.Start();
car.Stop();

// Polymorphism: Polymorphism is the ability of an object to take on multiple forms. In object-oriented
// programming, polymorphism allows objects of different classes to be treated as objects of a common
// superclass. This enables objects to be used interchangeably based on their common interface, even
// though they may have different implementations. In the example above, the Vehicle class defines
// common methods Start and Stop, and the Car and Motorcycle classes override these methods with
// specific implementations. The code can then treat vehicles of different types (Car, Motorcycle) as
// objects of the common superclass (Vehicle) and call the Start and Stop methods without knowing the
// specific type of the vehicle. This helps to write more flexible and maintainable code by allowing
// objects to be used interchangeably based on their common interface.

var vehicles = new List<Vehicle>
{
    new Car
    {
        Brand = "Toyota",
        Model = "Corolla",
        Year = 2020
    },
    new Motorcycle
    {
        Brand = "Honda",
        Model = "CBR",
        Year = 2021
    },
    new Plane
    {
        Brand = "Boeing",
        Model = "747",
        Year = 2022
    }
};

foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}