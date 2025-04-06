create database MVVMLoginDb
go
use MVVMLoginDb
go
create table [User]
(
	Id UNIQUEIDENTIFIER primary Key default NEWID(),
	Username nvarchar (50) unique not null,
	[Password] nvarchar (100) not null,
	[Name]nvarchar (50) not null,
	LastName nvarchar (50) not null,
	Email  nvarchar (100) unique not null
)
go
insert into [User] values (NEWID(), 'admin', 'admin','Captain','Paulie', 'kfc4life@gmail.com')
insert into [User] values (NEWID(), 'romeo', 'test','Romeo','Dulz', 'romayo@gmail.com')
insert into [User] values (NEWID(), 'jake', 'test','Jake','Gillie', 'jakethemusc@gmail.com')
go

select *from [User]