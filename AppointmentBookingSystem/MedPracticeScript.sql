use MedPractice;
create schema MedPractice;

CREATE TABLE MedPractice.staff(ID INTEGER NOT NULL, FirstName VARCHAR(255), LastName VARCHAR(255), Address VARCHAR(255), RoleId INT, UserId INT, PRIMARY KEY(ID))
CREATE TABLE MedPractice.patient(ID INT NOT NULL, FirstName VARCHAR(255), LastName VARCHAR(50), Address VARCHAR(255), ContactNumber VARCHAR(255), email VARCHAR(255), PRIMARY KEY(ID)) 
CREATE TABLE MedPractice.appointment(ID INT NOT NULL, staffID INT NOT NULL, patientId INT NOT NULL, appointmentDatetime DATETIME, appointmentDuration DATETIME, PRIMARY KEY(ID))
CREATE TABLE MedPractice.patientNotes(ID INT NOT NULL, staffId INT NOT NULL, patientId INT NOT NULL, patientNotes TEXT, PRIMARY KEY(ID))
CREATE TABLE MedPractice.usercredentials(ID INT NOT NULL, username VARCHAR(255), password VARCHAR(255), PRIMARY KEY(ID))
CREATE TABLE MedPractice.userRole(ID INT NOT NULL, userRole VARCHAR(255), PRIMARY KEY(ID))

ALTER TABLE MedPractice.staff ADD FOREIGN KEY (RoleId) REFERENCES MedPractice.userRole
ALTER TABLE MedPractice.staff ADD FOREIGN KEY (UserId) REFERENCES MedPractice.userCredentials
ALTER TABLE MedPractice.appointment ADD FOREIGN KEY (staffId) REFERENCES MedPractice.staff
ALTER TABLE MedPractice.appointment ADD FOREIGN KEY (patientId) REFERENCES MedPractice.patient
ALTER TABLE MedPractice.patientNotes ADD FOREIGN KEY (staffId) REFERENCES MedPractice.staff
ALTER TABLE MedPractice.patientNotes ADD FOREIGN KEY (patientId) REFERENCES MedPractice.patient

INSERT INTO MedPractice.userRole VALUES(1, 'Administrator')
INSERT INTO MedPractice.userRole VALUES(2, 'Receptionist')
INSERT INTO MedPractice.userRole VALUES(3, 'Medical Practicioner')

INSERT INTO MedPractice.usercredentials VALUES(1, 'test', 'test')

INSERT INTO MedPractice.staff VALUES(1, 'Mark', 'Porter', 'Foyle', 1, 1)
INSERT INTO MedPractice.staff VALUES(1, 'Doctor', 'Mark', 'Foyle', 1, 1)

INSERT INTO MedPractice.patient VALUES (1, 'Sickly', 'OldMan', 'Foyle', '07921344293', 'sicklyoldman@hotmail.com')


