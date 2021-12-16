CREATE Table Customers (
	CustomerID int IDENTITY(1,1) Primary Key,
	Shipping_Address varchar(50) not null, 
	Discount float not null, 
	Balance float not null, 
	Credit_Limit float not null,
);

CREATE Table Orders (
	OrderID int IDENTITY(1,1) Primary Key,
	Shipping_Address varchar(50) not null,
	Order_Date datetime not null, 
	Quantity int not null
);

CREATE Table Item (
	ItemID int IDENTITY(1,1) Primary Key,
	Item_Name varchar(50) not null,
	Item_Description varchar(100) not null

);

CREATE Table Factory (
	FactoryID int IDENTITY(1,1) Primary Key,
	Factory_Contact# int not null

);

CREATE Table Customer_Order (
	OrderID int Foreign Key References Orders(OrderID),
	CustomerID int Foreign Key References Customers(CustomerID)
);

CREATE Table Order_Item (
	OrderID int IDENTITY(1,1) Foreign Key References Orders(OrderID),
	ItemID int IDENTITY(1,1) Foreign Key References Item(ItemID)
);

CREATE Table Item_Factory (
	ItemID int IDENTITY(1,1) Primary Key,
	FactoryID int IDENTITY(1,1) Foreign Key
);




