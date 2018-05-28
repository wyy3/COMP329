--DROP TABLE Booking;
--DROP TABLE Room;
--DROP TABLE Accommodation;
--DROP TABLE Company;
--DROP TABLE Customer;

CREATE TABLE Company (
  CompanyID integer NOT NULL,
  CName varchar(255),
  password varchar(20),
  phone varchar(16),
  email varchar(255),
  CONSTRAINT company_pk PRIMARY KEY (CompanyID)
);

CREATE TABLE Accommodation (
  Aid integer NOT NULL,
  AName varchar(255),
  street varchar(255),
  city varchar(255),
  region varchar(255),
  description varchar(1024),
  CompanyID integer NOT NULL,
  CONSTRAINT accommodation_pk PRIMARY KEY (Aid),
  CONSTRAINT Accommodation_Company_fk 
  FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID)
);

CREATE TABLE Room (
  RoomTypeID integer NOT NULL,
  price DECIMAL(4,2),
  description varchar(1024),
  quantity integer,
  RName varchar(255),
  AccommodationID integer NOT NULL,
  CONSTRAINT room_pk PRIMARY KEY (RoomTypeID),
  CONSTRAINT Room_Accommodation_fk
  FOREIGN KEY (AccommodationID) REFERENCES Accommodation(Aid)
);

CREATE TABLE Customer (
  CustomerID integer NOT NULL,
  CFName varchar(255),
  CLName varchar(255),
  DoB date,
  phone varchar(16),
  email varchar(255),
  CONSTRAINT cutomer_pk PRIMARY KEY (CustomerID)
);

CREATE TABLE Booking (
  BookingID integer NOT NULL,
  price DECIMAL(4,2),
  CheckInDate date,
  RoomTypeID integer,
  CONSTRAINT booking_pk PRIMARY KEY (BookingID),
  CONSTRAINT Booking_Room_fk
  FOREIGN KEY (RoomTypeID) REFERENCES Room(RoomTypeID),
  CustomerID integer,
  CONSTRAINT Booking_Customer_fk
  FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

set escape '\';

INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (1,'Angelworth','Angelworth','70580407399','angelworth@gmail.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (2,'Linden','Linden','46935768099','linden@gmail.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (3,'Fontenay','Fontenay','21701273299','fontenay@gmail.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (4,'Sheraton','Sheraton','82245786499','sheraton@gmail.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (5,'Radisson','Radisson','18668789599','radisson@gmail.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (6,'Deomai','Deomai','37414736099','deomai@outlook.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (7,'Spanninger','Spanninger','02887880199','spanninger@hotmail.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (8,'TSG Enterprises','TSG Enterprises','38358560399','tsg@gmail.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (9,'Saratoga','Saratoga','16743121099','saratoga@gmail.com');
INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (10,'Dan Campbell','Dan Campbell','60376763999','dancampbell@outlook.com');

INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (1,'Atlantis Orb Hotel','609 Blandit Avenue','Taupo','Bay of Plenty','Hotel',1);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (2,'Azure Mountain Hotel','8382 Magna, Street','Hamilton','Waikato','Hotel',3);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (3,'Gentle Beach Resort','2768 Iaculis Street','Christchurch','Canterbury','Beach Resort',8);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (4,'Silver Emperor Hotel','5305 Est Road','Kerikeri','Northland','Hotel',2);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (5,'Marina Emperor Hotel','2877 Duis Road','Cambridge','Waikato','Hotel',1);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (6,'Twin Obelisk Motel','369 Ut Street.','Ashburton','Canterbury','Motel',9);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (7,'Relaxation Hotel','9857 Ipsum Road','Nelson','Nelson','Hotel',9);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (8,'Nimbus Hotel \& Spa','963 Adipiscing Avenue','Hastings','Hawke''s Bay','Hotel \& Spa',10);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (9,'Northern Motel \& Cafe','7326 Aliquam Road','Whangarei','Northland','Motel \& Cafe',4);
INSERT INTO Accommodation (Aid,AName,street,city,region,description,CompanyID) VALUES (10,'Fish Lake Lodge','2677 Tempor Road','New Plymout','Taranaki','Lodge',10);

INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (1,'22.17','For one person',5,'Single Room',8);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (2,'91.36','For two people',13,'Double Room',6);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (3,'34.47','For three people',14,'Triple Room',5);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (4,'52.00','For four people',20,'Quad Room',7);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (5,'26.97','With a queen-sized bed',17,'Queen Room',6);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (6,'70.86','With a king-sized bed',2,'King Room',7);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (7,'56.89','With two beds',9,'Twin Room',5);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (8,'69.57','With two double-beds',8,'Double-Double Room',10);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (9,'90.59','With a studio bed',10,'Studio Bed',8);
INSERT INTO Room (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (10,'10.59','Living room connected to one or more bedrooms',2,'Master Suite',9);

INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (1,'Gabriel','Haney','25/04/1994','1604092471799','g.haney@gmail.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (2,'Kameko','Burris','20/12/1992','1610052607599','burris@gmail.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (3,'Bethany','Huber','23/03/1984','1680072476499','bethanyhuber@outlook.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (4,'Lee','Thornton','01/02/1992','1687072180499','lee.thornton@gmail.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (5,'Jerry','Bowen','17/09/1984','1674120113299','bowenjerry@gmail.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (6,'Orson','Woodward','13/10/1993','1699122129299','o.woodward@hotmail.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (7,'Pascale','Nunez','05/11/1988','1675011912499','pascale.n@outlook.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (8,'Kim','Gates','16/01/1982','1687081597999','kim.gates@gmail.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (9,'Oprah','Roach','17/01/1990','1650063069299','roach.oprah@gmail.com');
INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (10,'Garrett','Barton','02/09/1982','1676060721599','g.barton@outlook.com');

INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (1,'76.39','06/05/2016',7,1);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (2,'17.33','27/11/2014',9,4);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (3,'2.86','08/08/2014',5,2);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (4,'38.66','09/09/2014',5,8);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (5,'41.73','21/03/2016',4,6);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (6,'21.59','16/01/2015',3,6);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (7,'59.11','05/06/2015',2,2);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (8,'77.83','24/11/2016',4,7);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (9,'50.04','08/04/2015',4,6);
INSERT INTO Booking (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (10,'71.67','24/03/2015',2,10);


--auto_increment keys
CREATE sequence companyID start with 11
increment by 1;

--Accommodation Table
CREATE sequence accommodationID start with 11
increment by 1;

--Room Table
CREATE sequence roomID start with 11
increment by 1;

--Customer Table
CREATE sequence customerID start with 11
increment by 1;

--Booking Table
CREATE sequence bookingID start with 11
increment by 1;


