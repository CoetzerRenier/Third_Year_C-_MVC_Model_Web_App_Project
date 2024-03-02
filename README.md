# GroovyBooks

Welcome to the Groovy Books Store! This project aims to develop a robust online platform for Books, where customers can seamlessly browse, search, and purchase items from the comfort of their homes. This README will guide you through setting up the project and understanding its key features.

# Features
# User Registration and Profiles:
Customers can easily register and create profiles to manage their purchases and preferences.

# Item Viewing and Details:
Customers can view detailed information about items available in the store.

# Inventory Search:
Customers can search the inventory based on various parameters to find specific items quickly.

# Shopping Cart Functionality:
Customers can add multiple items to their shopping cart for later purchase.

# Checkout Process:
Customers can proceed with the checkout process to finalize their purchases (Mock payment for Sprint 1).

# Persistent Cart:
Each user's cart is persisted between devices, ensuring a seamless shopping experience.

# Authentication:
Customers must be logged in to add items to their cart, ensuring security and personalized shopping experiences.

# Logging of Unsuccessful Login Attempts:
Failed login attempts are logged for security purposes.

# Installation
To get started, follow these steps:

Clone this repository to your local machine:

 bash
Copy code
git clone https://github.com/your-username/books-online-store.git](https://github.com/OpenZipper/GroovyBooks)
Navigate to the project directory:

# Usage
Once the project is set up and running, you can start exploring and using its features:

Register as a new user or log in with your existing credentials.
Browse through the available items, view their details, and search for specific items using the search functionality.
Add items to your shopping cart by clicking on the "Add to Cart" button.
Proceed to checkout to finalize your purchases (Note: Payment functionality is mocked for Sprint 1).

# SSMS
CREATE DATABASE GroovyBooks

CREATE TABLE Registration(
RegistrationID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Username VARCHAR(25),
Password VARCHAR(25),
Email VARCHAR(25),
DateOfBirth Date,
PhoneNo INT,
Address VARCHAR(50)
);

CREATE TABLE Profile(
ProfileID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Email VARCHAR(25) NOT NULL,
Password VARCHAR(25) NOT NULL
);

CREATE TABLE Product(
ProductID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Description VARCHAR(50) NOT NULL,
Name VARCHAR(25) NOT NULL,
Price VARCHAR(25) NOT NULL,
Stock VARCHAR(4) NOT NULL
);

CREATE TABLE Cart(
OrderID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Quantity INT,
TotalCost INT,
ProductID INT FOREIGN KEY REFERENCES Product(ProductID)
);

INSERT INTO Product VALUES('Ai vs Human Intelligence', 'Deep Thinking', 'R275', 'Yes');
INSERT INTO Product VALUES('Brothers by birth. Enemies by blood.', 'When the Lion Feeds', 'R499', 'Yes');
INSERT INTO Product VALUES('Spanning a lifetime of love and loss.', 'Atlas', 'R299', 'N/A');
INSERT INTO Product VALUES('All five novel goodness!', 'A Game of Thrones', 'R999', 'Yes');
INSERT INTO Product VALUES('The price of victory and the cost of war.', 'Dune', 'R199', 'N/A');

# License
This project is licensed under the MIT License - see the LICENSE file for details.

# Acknowledgements
Special thanks to Jarod Neidoo for saving our butts on this project thanks to his knowledge of cshtml.
