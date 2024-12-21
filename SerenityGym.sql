create database SerenityGym	
Go
use SerenityGym

create table Users
(
userid int IDENTITY(1,1) PRIMARY KEY,
membership_type varchar(50), -----to be altered----
fname varchar(50) not null,
lname varchar(50) not null,
phone_num int unique not null,
user_address varchar(50),
expiry_d date,
upassword varchar(50) not null
)
create table Staff
(
staffid int PRIMARY KEY,
staff_address varchar(50),
fname varchar(50) not null,
lname varchar(50) not null,
phone_num int not null,
staff_type varchar(50) CHECK (staff_type IN ('Manager', 'Receptionist', 'Trainer')),
spassword varchar(50) not null
)

create table Plans
(
planid int IDENTITY(1,1) PRIMARY KEY,
userid int,
foreign key (userid) references Users ON DELETE CASCADE ON UPDATE CASCADE,
staffid int,
foreign key (staffid) references Staff ON DELETE SET NULL ON UPDATE CASCADE,
plan_type varchar(50) CHECK (plan_type IN ('Food', 'Training')),
)
create table Tracker
(
planid int,
progress DECIMAL(5,2) CHECK (progress BETWEEN 0 AND 100) not null,
goal varchar(50),
foreign key (planid) references Plans,
)
create table Membership
(
membership_type varchar(50) PRIMARY KEY CHECK (membership_type IN ('Bronze', 'Silver', 'Gold', 'Platinum')),
cost int not null,
)
create table Notifications
(
notificationid int IDENTITY(1,1) PRIMARY KEY,
notif_message varchar(250) not null,
notif_date date not null
)
create table Feedback
(
feedbackid int IDENTITY(1,1) PRIMARY KEY,
userid int,
foreign key (userid) references Users ON DELETE SET NULL ON UPDATE CASCADE,
feed_message varchar(250) not null,
feed_date date not null
)
create table Registration
(
registrationid int IDENTITY(1,1) PRIMARY KEY,
starthour time,
duration int not null,
regdate date not null,
regtype varchar(50) not null CHECK (regtype IN ('Padel', 'Private','Physiotherapy', 'Membership')),
userid int not null,
membership_type varchar(50),
TrainerID int references Staff ON DELETE SET NULL ON UPDATE CASCADE
)
create table Payments
(
paymentid int IDENTITY(1,1) PRIMARY KEY,
amount int not null,
paymentdate date not null,
method varchar(50) CHECK (method IN ('Cash', 'Credit')),
staffid int ,
foreign key (staffid) references Staff ON DELETE SET NULL ON UPDATE CASCADE
)
create table Equipment
(
equipmentid int IDENTITY(1,1) PRIMARY KEY,
maint_schedule date not null,
equip_name varchar(50) not null,
equip_status varchar(50) CHECK (equip_status IN ('In Maintenance', 'Available')) not null
)
create table Attendance
(
att_status varchar(50) CHECK (att_status IN ('Clocked in', 'Clocked out')),
att_date date not null,
staffid int not null,
foreign key (staffid) references Staff ON DELETE CASCADE ON UPDATE CASCADE,
primary key (att_status,att_date,staffid)
)
create table Gets_Notified
(
notifid int not null,
membership_type varchar(50) not null,
foreign key (notifid) references Notifications,
foreign key (membership_type) references Membership,
primary key (notifid,membership_type)
)
create table Transactions
(
regid int not null,
paymentid int not null,
foreign key (regid) references Registration,
foreign key (paymentid) references Payments,
primary key (paymentid)
)

alter table Users add foreign key (membership_type) references Membership

insert into Users
values
(null,'Ahmed','Hamed',1066778817,'Giza','12-25-2025','$$$$')

insert into Staff
values
(10000,'Cairo','Zein','Effat',52347869,'Receptionist','$$$$'),
(20000,'Cairo','Ahmed','Refeat',52344869,'Trainer','%%%%'),
(30000,'Cairo','Rana','Ahmed',58885569,'Manager','****')

insert into Membership
values
('Bronze',1000),
('Silver',2800),
('Gold',5000),
('Platinum',7500)

update Users set membership_type ='Gold' where userid = 1


