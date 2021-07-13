CREATE DATABASE Session1
--
GO
--
USE Session1
--
GO
--
CREATE TABLE AssetGroups(
ID INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50)
)
--
CREATE TABLE Assets(
ID INT IDENTITY(1,1) PRIMARY KEY,
AssetSN VARCHAR(50),
AssetName VARCHAR(50),
DepartmentLocationID INT,
EmployeeID INT,
AssetGroupID INT,
Decription VARCHAR(100),
WarrantyDate DATETIME
)
--
CREATE TABLE AssetPhotos(
ID INT IDENTITY(1,1) PRIMARY KEY,
AssetID INT,
AssetPhoTo CHAR(50),
)
--
ALTER TABLE AssetPhotos
ADD FOREIGN KEY(AssetID) REFERENCES Assets(ID)
--
CREATE TABLE Employees(
ID INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
Phone CHAR(12)
)
--
CREATE TABLE DepartmentLocations(
ID INT IDENTITY(1,1) PRIMARY KEY,
DepartmentID INT, 
LocationID INT,
StartDate DATETIME,
EndDate DATETIME
)
--
CREATE TABLE Locations(
ID INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50)
)
--
CREATE TABLE Departments(
ID INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50)
)
--
CREATE TABLE AssetTransferLogs(
ID INT IDENTITY(1,1) PRIMARY KEY,
AssetID INT,
FromAssetSN VARCHAR(100),
ToAssetSN VARCHAR(100),
FromDepartmentLocationID INT,
ToDepartmentLocationID INT,
TransferDate DATETIME
)
--
GO
--
ALTER TABLE Assets
ADD FOREIGN KEY(DepartmentLocationID) REFERENCES DepartmentLocations(ID),
FOREIGN KEY(EmployeeID) REFERENCES Employees(ID),
FOREIGN KEY(AssetGroupID) REFERENCES AssetGroups(ID)
--
ALTER TABLE AssetTransferLogs
ADD FOREIGN KEY(AssetID) REFERENCES Assets(ID),
FOREIGN KEY(FromDepartmentLocationID) REFERENCES DepartmentLocations(ID),
FOREIGN KEY(ToDepartmentLocationID) REFERENCES DepartmentLocations(ID)
--
ALTER TABLE DepartmentLocations
ADD FOREIGN KEY(DepartmentID) REFERENCES Departments(ID),
FOREIGN KEY(LocationID) REFERENCES Locations(ID)

