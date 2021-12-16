use Test
CREATE Table Warehouses (
	warehouseId int IDENTITY(1,1) Primary Key,
	place Varchar(100) not null, 
	capacity int not null
);

CREATE Table Boxes (
	refNumber Char(5) Primary Key,
	content Varchar(100) not null,
	price int not null, 
	warehouseId int Foreign Key References Warehouses(warehouseId)
);

ALTER Table Warehouses
ADD city Varchar(80) not null

INSERT INTO Warehouses (place, capacity, city) 
Values ('North', 32, 'Boston'),
('South', 13, 'Seattle'),
('North', 98, 'Concord'),
('East', 73, 'Hampstead'),
('South', 42, 'New York'),
('West', 3, 'Portland')

SELECT warehouseId, place, capacity, city from Warehouses 