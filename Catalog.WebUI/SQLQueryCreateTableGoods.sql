﻿CREATE TABLE Goods
(
[Id] INT NOT NULL IDENTITY(1,1),
[StoreId] INT NOT NULL,
[Name] NVARCHAR(100) NOT NULL,
[Description] NVARCHAR(500) NOT NULL,
CONSTRAINT prim_goods PRIMARY KEY CLUSTERED (Id, StoreId),
CONSTRAINT foreign_goods1 FOREIGN KEY(StoreId) REFERENCES Stores(Id) ON DELETE CASCADE ON UPDATE CASCADE
);