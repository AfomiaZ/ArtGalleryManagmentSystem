
create database artgallerymanagmentsystem 

use artgallerymanagmentsystem
create table Artists( FullName varchar(20),ProfilePicture image, 
			 contact int ,email varchar(50), ArtistsId varchar(50))

create table Sales (CustomersName varchar(50), contact int ,email varchar(50),
			 IssuedDate date,AtrworkName varchar (50))

create table Arts(ArtName varchar (50), ArtistName varchar(50),
			 PurchaseDate date , PriceOfArt int,Quantity int,TypeOfArtWork varchar(50))

create table Manager(Name varchar(50),UserName varchar(50), Password varchar(50),
			 Email varchar(50),contact int) 



Create procedure addArtists2
@fullname varchar(50),
@profilepicture image,
@contact int,
@email varchar(50),
@artistsId varchar(50)

as 
begin

insert into Artists
values (@fullname,@profilepicture,@contact,@email,@artistsId)
end

Create procedure addsales
@customername varchar(50),
@contact int,
@email varchar(50),
@issuedDate date,
@artworkname varchar(50)

as 
begin

insert into Sales
values (@customername,@contact,@email,@issuedDate,@artworkname)
end


create procedure insertarts

@artname varchar(50),
@artistname varchar(50),
@purchasedate date,
@priceofart int,
@quantity int,
@typeofartwork varchar(50)

as
begin

insert into Arts
values (@artname,@artistname,@purchasedate,@priceofart,@quantity,@typeofartwork)
end


Create procedure addmanager
@name varchar(50),
@username varchar(50),
@password varchar(50),
@email varchar(50),
@contact int

as 
begin

insert into Manager
values (@name,@username,@password,@email,@contact)
end

