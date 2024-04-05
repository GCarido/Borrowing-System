CREATE TABLE inventory(
	 equipmentID INT,
     equipmentName VARCHAR(255),
     equipmentDescription VARCHAR(255),
     quantity INT,
     condition_ VARCHAR(255),
     PRIMARY KEY(equipmentID)
);

CREATE TABLE students(
	studentID VARCHAR(255),
    studentName VARCHAR(255),
    course VARCHAR (255),
    yearLevel INT,
    PRIMARY KEY (studentID)
);

CREATE TABLE employee(
	employeeID VARCHAR(255),
    firstname VARCHAR(255),
    lastname VARCHAR(255),
    username VARCHAR(255),
    password_ VARCHAR(255),
    position VARCHAR(50),
    PRIMARY KEY (employeeID)
);

CREATE TABLE orders(
	orderID INT,
    subject_code VARCHAR(255),
    equipment_ID INT,
    student_ID VARCHAR(100),
    employee_ID VARCHAR(100),
    order_DATE DATE,
    order_TIME DATETIME,
	PRIMARY KEY(orderID),
    FOREIGN KEY (equipment_ID)
		REFERENCES inventory(equipmentID),
    FOREIGN KEY(student_ID)
		REFERENCES students(studentID),
    FOREIGN KEY(employee_ID)
		REFERENCES employee(employeeID)
);

CREATE TABLE log(
	logID INT,
    order_ID INT,
    return_DATE DATE,
    return_TIME DATETIME,
    PRIMARY KEY (logID),
	FOREIGN KEY (order_ID)
		REFERENCES orders(orderID)
);