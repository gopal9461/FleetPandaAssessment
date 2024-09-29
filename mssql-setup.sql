create DATABASE FleetPandaAssessment;

use FleetPandaAssessment;

create table Customer(
    CustomerId INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100),
    [Email] VARCHAR(40) unique,
    [Phone] VARCHAR(50) unique
);

create table Location (
    LocationId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT FOREIGN KEY REFERENCES Customer(CustomerId),
    [Address] NVARCHAR(200)
);

INSERT INTO Customer([Name],[Phone],[Email])
VALUES
  ('Garrison Donaldson','(146) 651-0877','nascetur@hotmail.com'),
  ('Dara Kramer','(815) 909-0398','eget.dictum@protonmail.com'),
  ('Griffin Grant','1-396-323-3378','ullamcorper.viverra.maecenas@google.org'),
  ('Pandora Santana','(974) 241-4881','vitae.sodales@google.net'),
  ('Tasha Barber','1-815-203-6331','quisque.porttitor@icloud.ca'),
  ('Melanie Mccarthy','(490) 739-0459','feugiat.nec@hotmail.org'),
  ('Ulysses Howell','1-224-384-4657','morbi.non.sapien@aol.edu'),
  ('Jesse Hogan','(147) 916-3182','integer@icloud.ca'),
  ('Cecilia Randall','1-737-865-0338','ut.eros@yahoo.org'),
  ('Flynn Wheeler','(492) 250-5364','fringilla.purus@hotmail.ca'),
  ('Kirsten Charles','(498) 531-8687','urna@hotmail.net'),
  ('Harlan Woodard','(358) 428-6509','dapibus@aol.ca'),
  ('Octavius Wise','1-718-316-5398','odio.etiam@aol.org'),
  ('Armando Vance','(688) 452-8304','nec.tellus.nunc@outlook.edu'),
  ('Caleb Kirkland','1-848-280-2541','a.facilisis@aol.couk'),
  ('Joshua Goff','1-892-451-1226','lorem@aol.com'),
  ('Faith Gibson','(218) 495-4642','quis.accumsan@protonmail.org'),
  ('Lucy Hodges','1-751-457-4876','ipsum@protonmail.org'),
  ('Hop Oliver','1-603-554-8853','non.arcu.vivamus@outlook.edu'),
  ('Joel Case','1-445-441-7785','ac.mattis@aol.edu');

INSERT INTO Location([CustomerId],[Address])
VALUES
  (1,'971-8549 Nulla Rd.'),
  (1,'P.O. Box 712, 3347 Nec St.'),
  (2,'Ap #576-2159 In Avenue'),
  (2,'P.O. Box 710, 8478 Ultrices Road'),
  (2,'P.O. Box 356, 4632 In Avenue'),
  (3,'P.O. Box 729, 5466 Eget Av.'),
  (3,'107-3102 Quis, St.'),
  (4,'758-7711 Quisque Rd.'),
  (4,'Ap #619-1275 Mauris, Rd.'),
  (4,'Ap #619-4137 A, Rd.'),
  (5,'580-270 Magna St.'),
  (5,'242-3196 Ipsum. Road'),
  (6,'Ap #110-3780 Non, Road'),
  (6,'5626 Egestas. St.'),
  (7,'Ap #249-801 Diam Street'),
  (7,'836-6967 Egestas Road'),
  (7,'Ap #770-3691 Orci Rd.'),
  (8,'2606 Sapien, St.'),
  (8,'150-6219 Eu Ave'),
  (9,'187-8092 In Road'),
  (9,'Ap #979-8843 Integer Av.'),
  (10,'507-2434 Mauris Avenue'),
  (10,'P.O. Box 218, 4530 Nec St.'),
  (10,'Ap #940-6858 Nulla. St.'),
  (11,'690-5263 Augue St.'),
  (11,'6455 Dolor. Rd.'),
  (12,'5372 Ultrices. Av.'),
  (12,'Ap #753-9789 Nulla Rd.'),
  (13,'Ap #858-733 Vehicula Ave'),
  (13,'Ap #110-7768 Diam Street'),
  (13,'Ap #392-7904 Tellus. Avenue'),
  (14,'2472 Consequat Av.'),
  (14,'Ap #952-9580 Non, Avenue'),
  (15,'839-5792 Malesuada Road'),
  (15,'P.O. Box 951, 1264 Sem, Av.'),
  (15,'253-8045 Ante St.'),
  (16,'432-2250 Mauris Rd.'),
  (16,'P.O. Box 456, 7716 Suspendisse Rd.'),
  (17,'2168 Nunc Road'),
  (17,'675-8171 Libero Ave'),
  (17,'357-8279 Molestie Av.'),
  (18,'3790 Arcu Rd.'),
  (18,'Ap #967-8372 Scelerisque Road'),
  (18,'P.O. Box 419, 4943 Sapien St.'),
  (19,'P.O. Box 952, 6085 Nulla Rd.'),
  (19,'Ap #924-6673 Et Ave'),
  (19,'Ap #156-8033 Nibh Rd.'),
  (20,'Ap #818-2674 Quis, St.'),
  (20,'Ap #635-7347 Nisl St.'),
  (20,'Ap #914-1659 Est. Road');

