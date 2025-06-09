create database SerenityGym
Go
use SerenityGym

create table Users
(
userid int IDENTITY(1,1) PRIMARY KEY,
membership_type varchar(50), -----to be altered----
fname varchar(50) not null,
lname varchar(50) not null,
phone_num bigint unique not null,
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
phone_num bigint not null,
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
Split varchar(50) CHECK(Split IN('Low-Carb','High-Carb','Keto','PSMF','Arnold','General','Upper-Lower','Push-Pull-Leg')),
)
create table Tracker
(
planid int not null,
USER_ID int,
TRAINER_ID int,
progress DECIMAL(5,2) CHECK (progress BETWEEN 0 AND 100) not null,
goal varchar(50) not null,
primary key(planid,goal,progress),
foreign key (planid) references Plans ON Update No action On delete no action,
foreign key (USER_ID) references Users ON Update No action On delete set null,
foreign key (TRAINER_ID) references Staff ON Update No action On delete set null
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
Mood varchar(50),
foreign key (userid) references Users ON DELETE SET NULL ON UPDATE CASCADE,
feed_message varchar(250) not null,
feed_date date not null
)
create table Registration
(
registrationid int IDENTITY(1,1) PRIMARY KEY,
Paymentamount int not null,
method varchar(50) CHECK (method IN ('Cash', 'Credit')),
starthour time,
endhour time,
regdate date not null,
regtype varchar(50) not null CHECK (regtype IN ('Padel', 'Private', 'Membership')),
userid int,
membership_type varchar(50),
foreign key (userid) references Users ON DELETE SET NULL ON UPDATE CASCADE,
TrainerID int references Staff ON DELETE SET NULL ON UPDATE CASCADE,
S_ID int references Staff ON DELETE no action ON UPDATE no action
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

alter table Users add foreign key (membership_type) references Membership

INSERT INTO Users (membership_type, fname, lname, phone_num, user_address, expiry_d, upassword)
VALUES
(NULL, 'Ahmed', 'Ali', 1051112233, 'Giza', NULL, '123456'),
(NULL, 'Mona', 'Hassan', 1061223344, 'Alexandria', NULL, '123456'),
(NULL, 'Sara', 'Youssef', 1071334455, 'Cairo', NULL, '123456'),
(NULL, 'Hany', 'Fouad', 1081445566, 'Giza', NULL, '123456'),
(NULL, 'Alaa', 'Khaled', 1091556677, 'Alexandria', NULL, '123456'),
(NULL, 'Omar', 'Nabil', 1101667788, 'Cairo', NULL, '123456'),
(NULL, 'Fatma', 'Shady', 1111778899, 'Giza', NULL, '123456'),
(NULL, 'Youssef', 'Karim', 1121889900, 'Cairo', NULL, '123456'),
(NULL, 'Laila', 'Osman', 1131990011, 'Alexandria', NULL, '123456'),
(NULL, 'Nada', 'Maher', 1142001122, 'Giza', NULL, '123456'),
(NULL, 'Adham', 'Tamer', 1152112233, 'Cairo', NULL, '123456'),
(NULL, 'Sherif', 'Hossam', 1162223344, 'Alexandria', NULL, '123456'),
(NULL, 'Amira', 'Mohamed', 1172334455, 'Giza',NULL, '123456'),
(NULL, 'Ayman', 'Gamal', 1182445566, 'Cairo', NULL, '123456'),
(NULL, 'Nourhan', 'Reda', 1192556677, 'Alexandria', NULL, '123456'),
(NULL, 'Khaled', 'Ahmed', 1052667788, 'Luxor', NULL, '123456'),
(NULL, 'Heba', 'Salem', 1063778899, 'Aswan', NULL, '123456'),
(NULL, 'Samir', 'Maged', 1074889900, 'Suez', NULL, '123456'),
(NULL, 'Reem', 'Hassan', 1085990011, 'Port Said', NULL, '123456'),
(NULL, 'Aya', 'Fathy', 1096001122, 'Ismailia', NULL, '123456'),
(NULL, 'Ahmed', 'Khaled', 1098765433, 'Tanta', NULL, '123456'),
(NULL, 'Sarah', 'Yusuf', 1087654322, 'Mansoura', NULL, '123456'),
(NULL, 'Mohamed', 'Ali', 1076543211, 'Port Said', NULL, '123456'),
(NULL, 'Marwa', 'Osman', 1065432100, 'Suez', NULL, '123456'),
(NULL, 'Youssef', 'Tarek', 1054321099, 'Faiyum',NULL, '123456');

insert into Staff
values
(10001, 'Giza', 'Laila', 'Youssef', 1098765432, 'Receptionist', '123456'),
(10002, 'Cairo', 'Sara', 'Farid', 1087654321, 'Receptionist', '123456'),
(10003, 'Alexandria', 'Noha', 'Magdy', 1076543210, 'Receptionist', '123456'),
(10004, 'Cairo', 'Dina', 'Karam', 1065432109, 'Receptionist', '123456'),
(20001, 'Cairo', 'Omar', 'Ibrahim', 1032109876, 'Trainer', '123456'),
(20002, 'Giza', 'Khaled', 'Mostafa', 1021098765, 'Trainer', '123456'),
(20003, 'Alexandria', 'Adham', 'Fouad', 1010987654, 'Trainer', '123456'),
(20004, 'Cairo', 'Ali', 'Mahmoud', 1009876543, 'Trainer', '123456'),
(30000, 'Cairo', 'Samy', 'Abouelezz', 1006543210, 'Manager', '123456');


insert into Plans
values
(1, 20002, 'Food', 'Keto'),
(1, 20002, 'Training', 'Arnold'),
(2, 20001, 'Food', 'Low-Carb'),
(2, 20001, 'Training', 'Upper-Lower'),
(3, 20003, 'Food', 'High-Carb'),
(3, 20003, 'Training', 'Push-Pull-Leg'),
(4, 20004, 'Food', 'General'),
(4, 20004, 'Training', 'Arnold'),
(5, 20002, 'Food', 'Keto'),
(5, 20002, 'Training', 'Upper-Lower'),
(6, 20001, 'Food', 'Low-Carb'),
(6, 20001, 'Training', 'Push-Pull-Leg'),
(7, 20003, 'Food', 'High-Carb'),
(7, 20003, 'Training', 'General'),
(8, 20004, 'Food', 'Keto'),
(8, 20004, 'Training', 'Arnold'),
(9, 20002, 'Food', 'Low-Carb'),
(9, 20002, 'Training', 'Upper-Lower'),
(10, 20001, 'Food', 'High-Carb'),
(10, 20001, 'Training', 'Push-Pull-Leg'),
(11, 20003, 'Food', 'General'),
(11, 20003, 'Training', 'Arnold'),
(12, 20004, 'Food', 'Keto'),
(12, 20004, 'Training', 'Upper-Lower'),
(13, 20002, 'Food', 'Low-Carb'),
(13, 20002, 'Training', 'Push-Pull-Leg'),
(14, 20001, 'Food', 'High-Carb'),
(14, 20001, 'Training', 'General'),
(15, 20003, 'Food', 'Keto'),
(15, 20003, 'Training', 'Arnold'),
(16, 20004, 'Food', 'Low-Carb'),
(16, 20004, 'Training', 'Upper-Lower'),
(17, 20002, 'Food', 'High-Carb'),
(17, 20002, 'Training', 'Push-Pull-Leg'),
(18, 20001, 'Food', 'General'),
(18, 20001, 'Training', 'Arnold'),
(19, 20003, 'Food', 'Keto'),
(19, 20003, 'Training', 'Upper-Lower'),
(20, 20004, 'Food', 'Low-Carb'),
(20, 20004, 'Training', 'Push-Pull-Leg');

insert into Membership
values
('Bronze',1000),
('Silver',2800),
('Gold',5000),
('Platinum',7500);

-- Update Users Table with Membership Type and Expiry Date for 25 Users
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 1;
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 2;
UPDATE Users SET membership_type = 'Platinum', expiry_d = DATEADD(YEAR, 1, GETDATE()) WHERE userid = 3;
UPDATE Users SET membership_type = 'Silver', expiry_d = DATEADD(MONTH, 3, GETDATE()) WHERE userid = 4;
UPDATE Users SET membership_type = 'Silver', expiry_d = DATEADD(MONTH, 3, GETDATE()) WHERE userid = 5;
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 6;
UPDATE Users SET membership_type = 'Platinum', expiry_d = DATEADD(YEAR, 1, GETDATE()) WHERE userid = 7;
UPDATE Users SET membership_type = 'Silver', expiry_d = DATEADD(MONTH, 3, GETDATE()) WHERE userid = 8;
UPDATE Users SET membership_type = 'Bronze', expiry_d = DATEADD(MONTH, 1, GETDATE()) WHERE userid = 9;
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 10;
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 11;
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 12;
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 13;
UPDATE Users SET membership_type = 'Silver', expiry_d = DATEADD(MONTH, 3, GETDATE()) WHERE userid = 14;
UPDATE Users SET membership_type = 'Platinum', expiry_d = DATEADD(YEAR, 1, GETDATE()) WHERE userid = 15;
UPDATE Users SET membership_type = 'Bronze', expiry_d = DATEADD(MONTH, 1, GETDATE()) WHERE userid = 16;
UPDATE Users SET membership_type = 'Silver', expiry_d = DATEADD(MONTH, 3, GETDATE()) WHERE userid = 17;
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 18;
UPDATE Users SET membership_type = 'Platinum', expiry_d = DATEADD(YEAR, 1, GETDATE()) WHERE userid = 19;
UPDATE Users SET membership_type = 'Silver', expiry_d = DATEADD(MONTH, 3, GETDATE()) WHERE userid = 20;
UPDATE Users SET membership_type = 'Bronze', expiry_d = DATEADD(MONTH, 1, GETDATE()) WHERE userid = 21;
UPDATE Users SET membership_type = 'Silver', expiry_d = DATEADD(MONTH, 3, GETDATE()) WHERE userid = 22;
UPDATE Users SET membership_type = 'Gold', expiry_d = DATEADD(MONTH, 6, GETDATE()) WHERE userid = 23;
UPDATE Users SET membership_type = 'Platinum', expiry_d = DATEADD(YEAR, 1, GETDATE()) WHERE userid = 24;
UPDATE Users SET membership_type = 'Bronze', expiry_d = DATEADD(MONTH, 1, GETDATE()) WHERE userid = 25;





INSERT INTO Feedback (userid, Mood, feed_message, feed_date)
VALUES
(1, 'Happy', 'Great gym with excellent facilities!', '2024-12-28'),
(2, 'Neutral', 'Good service, but equipment needs improvement.', '2024-12-28'),
(3, 'Happy', 'Love the new yoga classes!', '2024-12-28'),
(5, 'Happy', 'Best gym I have ever joined!', '2024-12-28'),
(6, 'Sad', 'Facilities are great, but the customer service can improve.', '2024-12-28'),
(7, 'Excited', 'Love the variety of classes offered.', '2024-12-28'),
(8, 'Frustrated', 'The machines are often unavailable due to maintenance.', '2024-12-28'),
(9, 'Neutral', 'The gym is okay for the price.', '2024-12-28'),
(10, 'Satisfied', 'Amazing personal trainers and clean facilities.', '12-28-2024'),
(11, 'Happy', 'I achieved my fitness goals with their support!', '12-28-2024'),
(12, 'Neutral', 'Good gym but too crowded at peak hours.', '12-28-2024'),
(13, 'Angry', 'The registration process was too slow.', '12-28-2024'),
(14, 'Excited', 'The new classes are fantastic!', '12-28-2024'),
(15, 'Sad', 'I expected more flexibility in membership plans.', '12-28-2024'),
(16, 'Frustrated', 'Many machines are under maintenance.', '12-28-2024'),
(17, 'Content', 'Affordable prices and friendly staff.', '12-28-2024'),
(18, 'Happy', 'The app integration makes tracking progress easy.', '12-28-2024'),
(19, 'Neutral', 'I like it but parking is an issue.', '12-28-2024'),
(20, 'Satisfied', 'The best gym in the city.', '12-28-2024'),
(21, 'Angry', 'No Wi-Fi in some areas of the gym.', '12-28-2024'),
(22, 'Excited', 'The personal trainers are highly professional.', '12-28-2024'),
(23, 'Happy', 'I love the community events they organize.', '12-28-2024'),
(24, 'Frustrated', 'Membership costs are a bit high.', '12-28-2024'),
(25, 'Sad', 'The facilities are great, but parking is difficult.', '12-28-2024');



insert into Equipment
values
('01-10-2025', 'Hack Squat Machine', 'Available'),
('01-15-2025', 'Shoulder Press Machine', 'In Maintenance'),
('01-18-2025', 'Leg Press Machine', 'Available'),
('02-05-2025', 'Lat Pulldown Machine', 'In Maintenance'),
('02-20-2025', 'Cable Crossover Machine', 'Available'),
('02-25-2025', 'Chest Press Machine', 'Available'),
('03-05-2025', 'Smith Machine', 'In Maintenance'),
('03-15-2025', 'Seated Row Machine', 'Available'),
('04-01-2025', 'Preacher Curl Bench', 'Available'),
('04-10-2025', 'Dumbbell Rack', 'Available'),
('04-15-2025', 'Incline Bench Press', 'In Maintenance'),
('05-01-2025', 'Triceps Dip Machine', 'Available'),
('05-10-2025', 'Pull-Up Bar', 'Available'),
('05-20-2025', 'Treadmill', 'In Maintenance'),
('06-01-2025', 'Elliptical Trainer', 'Available'),
('06-15-2025', 'Stationary Bike', 'Available'),
('07-01-2025', 'Leg Curl Machine', 'In Maintenance'),
('07-15-2025', 'Pec Deck Machine', 'Available'),
('08-01-2025', 'Calf Raise Machine', 'Available'),
('08-15-2025', 'Rowing Machine', 'In Maintenance');

INSERT INTO Notifications
VALUES
('Sports tournament registration closes on January 15th', '1-2-2024'),
('New Year party event on January 5th', '01-05-2024'),
('Valentine’s Day offer: Couples get 50% off', '01-10-2024'),
('Spring special: 9 months for 900 geneh', '02-15-2024'),
('Ramadan discount extended: 6 months for 600 geneh', '03-01-2024'),
('Join our charity marathon event on March 12th', '03-12-2024'),
('Eid holiday offer: Family plans at 25% off', '04-05-2024'),
('Summer special deal: 12 months for 1200 geneh', '05-15-2024'),
('New event: Cultural night on June 25th', '06-10-2024'),
('Back-to-school promo: 6 months for 600 geneh', '08-20-2024'),
('Autumn festival event on October 1st', '09-15-2024'),
('Black Friday sale: 1-year plan at 50% off', '11-10-2024'),
('Winter carnival event on December 20th', '12-01-2024'),
('Exclusive New Year offer: 2 months free on yearly subscription', '12-15-2024'),
('Our special Christmas offer: 3 months for 300 geneh', '12-20-2024'),
('Halloween special: Join for 3 months and get 1 month free', '10-15-2024'),
('Thanksgiving offer: Discounted family plans', '11-20-2024'),
('Christmas Eve event: Free yoga class', '12-24-2024'),
('Early bird special for 2025: Pay for 10 months, get 2 free', '12-31-2024'),
('Valentine’s Day couples competition on February 14th', '01-25-2025'),
('Special January offer: Bring a friend and get 20% off', '01-01-2024'),
('New Zumba classes starting February 10th', '02-01-2024'),
('Spring promotion: Annual plans at 30% off', '03-01-2024'),
('Eid holiday special: Pay for 6 months, get 2 free', '04-10-2024'),
('Join the summer fitness challenge starting May 1st', '05-01-2024'),
('New equipment arriving in June: Stay tuned!', '06-01-2024'),
('Celebrate National Fitness Day on July 15th', '07-01-2024'),
('Back-to-school promo: Family memberships at 20% off', '08-01-2024'),
('Autumn wellness workshops every Saturday in October', '09-01-2024'),
('Black Friday: One-day deals up to 50% off', '11-01-2024'),
('Christmas yoga retreat on December 24th', '12-01-2024'),
('January New Year Resolution challenge', '01-01-2025'),
('Celebrate Valentine’s Day with free couple sessions', '02-01-2025'),
('March marathon registration now open', '03-01-2025'),
('April fitness carnival with free trial classes', '04-01-2025'),
('Personal training discounts all May', '05-01-2025'),
('New cycling classes available in June', '06-01-2025'),
('Half-yearly sale: Up to 40% off memberships', '07-01-2025'),
('Enjoy weekend bootcamps this August', '08-01-2025'),
('Get your fitness assessment free this September', '09-01-2025');


INSERT INTO Gets_Notified VALUES
(1, 'Gold'),
(2, 'Silver'),
(3, 'Bronze'),
(4, 'Platinum'),
(5, 'Gold'),
(6, 'Silver'),
(7, 'Bronze'),
(8, 'Platinum'),
(9, 'Gold'),
(10, 'Silver'),
(11, 'Bronze'),
(12, 'Platinum'),
(13, 'Gold'),
(14, 'Silver'),
(15, 'Bronze'),
(16, 'Gold'),
(17, 'Silver'),
(18, 'Bronze'),
(19, 'Platinum'),
(20, 'Gold'),
(21, 'Gold'),
(22, 'Silver'),
(23, 'Bronze'),
(24, 'Platinum'),
(25, 'Gold'),
(26, 'Silver'),
(27, 'Bronze'),
(28, 'Platinum'),
(29, 'Gold'),
(30, 'Silver'),
(31, 'Bronze'),
(32, 'Platinum'),
(33, 'Gold'),
(34, 'Silver'),
(35, 'Bronze'),
(36, 'Gold'),
(37, 'Silver'),
(38, 'Bronze'),
(39, 'Platinum'),
(40, 'Gold');

INSERT INTO Tracker
VALUES
(1, 1, 20002, 25.50, 'Lose Weight'),
(1, 1, 20002, 40.00, 'Build Strength'),
(2, 2, 20001, 30.75, 'Gain Muscle'),
(2, 2, 20001, 50.00, 'Improve Endurance'),
(3, 3, 20003, 10.00, 'Rehabilitation'),
(4, 4, 20004, 15.25, 'Flexibility'),
(1, 1, 20002, 75.50, 'Nutrition Improvement'),
(1, 2, 20001, 80.25, 'Strength Training'),
(1, 3, 20003, 65.00, 'Weight Loss'),
(2, 4, 20004, 90.00, 'Muscle Building'),
(2, 5, 20002, 70.50, 'Cardio'),
(2, 6, 20001, 85.75, 'Flexibility'),
(3, 7, 20003, 78.25, 'Endurance'),
(3, 8, 20004, 82.00, 'Recovery'),
(4, 9, 20002, 88.00, 'Performance'),
(4, 10, 20001, 95.00, 'Speed Training'),
(5, 11, 20003, 60.50, 'Strength Maintenance'),
(5, 12, 20004, 72.00, 'Fat Loss'),
(6, 13, 20002, 79.25, 'Injury Prevention'),
(6, 14, 20001, 68.75, 'Mental Wellness'),
(7, 15, 20003, 84.50, 'Agility'),
(7, 16, 20004, 91.00, 'Conditioning'),
(8, 17, 20002, 70.25, 'Posture Improvement'),
(8, 18, 20001, 77.50, 'Body Composition'),
(9, 19, 20003, 85.25, 'Flexibility Improvement'),
(9, 20, 20004, 66.00, 'Speed Endurance');


insert into Registration
values
(400,'Credit','14:00:00','15:00:00','12-25-2024','Private',1,null,20001,null),
(250,'Cash','14:00:00','15:00:00','12-25-2024','Padel',2,null,null,null),
(250,'Cash','15:00:00','16:00:00','12-25-2024','Padel',2,null,null,null),
(400,'Credit','20:00:00','21:00:00','12-25-2024','Private',4,null,20004,null),
(400,'Credit','14:00:00','15:00:00','12-27-2024','Private',1,null,20001,null),
(250,'Cash','14:00:00','15:00:00','12-27-2024','Padel',2,null,null,null),
(250,'Cash','15:00:00','16:00:00','12-27-2024','Padel',2,null,null,null),
(400,'Credit','20:00:00','21:00:00','12-27-2024','Private',4,null,20004,null),
(500, 'Credit', '15:00:00', '16:00:00', '12-30-2024', 'Private', 5, 'Gold', 20002, NULL),
(300, 'Cash', '16:00:00', '17:00:00', '12-30-2024', 'Padel', 6, 'Silver', NULL, NULL),
(250, 'Cash', '17:00:00', '18:00:00', '12-30-2024', 'Padel', 7, 'Bronze', NULL, NULL),
(400, 'Credit', '18:00:00', '19:00:00', '12-30-2024', 'Private', 8, 'Platinum', 20003, NULL),
(450, 'Credit', '19:00:00', '20:00:00', '12-30-2024', 'Private', 9, 'Gold', 20004, NULL);

INSERT INTO Attendance (att_status, att_date, staffid)
VALUES
('Clocked in', '12-28-2024', 10001),
('Clocked out', '12-28-2024', 10001),
('Clocked in', '12-28-2024', 10002),
('Clocked out', '12-28-2024', 10002),
('Clocked in', '12-28-2024', 10003),
('Clocked out', '12-28-2024', 10003),
('Clocked in', '12-28-2024', 10004),
('Clocked out', '12-28-2024', 10004),
('Clocked in', '12-28-2024', 20001),
('Clocked out', '12-28-2024', 20001),
('Clocked in', '12-28-2024', 20002),
('Clocked out', '12-28-2024', 20002),
('Clocked in', '12-28-2024', 20003),
('Clocked out', '12-28-2024', 20003),
('Clocked in', '12-28-2024', 20004),
('Clocked out', '12-28-2024', 20004),
('Clocked in', '12-28-2024', 30000),
('Clocked out', '12-28-2024', 30000);
