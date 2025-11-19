create database schoolmanagement;
use schoolmanagement;
create table stafftable(
		stf_id varchar(8) primary key ,
		stf_fullname varchar(255),
		stf_dob date,
		stf_gender varchar(10),
		stf_photo varchar(10),
		stf_aadhar varchar(14),
		stf_joiningdate date,
		stf_mobileno varchar(15),
		stf_email varchar(255),
	     fk_stf_designationid varchar(100) foreign key,
		stf_status varchar(100),
		stf_password varchar(10)
	     fk_stf_addressid int foreign key,
		stf_localaddress text
		
		);
 create table designationtable( --first create table
		stf_designationid varchar(100) primary key,
		stf_designation varchar(10) unique not null,
		stf_department varchar(50)
		);
create table qualificationtable(
		stf_qualificationid int auto_increment primary key,
		stf_highestqualification varchar(100),
		stf_specialisation varchar(100),
		stf_certification varchar(100),
		stf_experienceyear int
		);
create table addresstable(
		addressid int auto_increment primary key,
		country varchar(100),
		state varchar(100),
		district varchar(100),
		city varchar(10),
		pincode int
		);
create table salarytable(
	stf_salaryid int primary key auto_increment,
	fk_stf_id varchar(8) foreign key,
	stf_salaryamount decimal(10,2),
	stf_bankaccountno bigint unique,
	stf_ifsc varchar(100),
	stf_pan varchar(12) unique,
	stf_salarytype varcahr(100)
	);


CREATE TABLE studentData (
    std_abcid BIGINT PRIMARY KEY,
    std_firstname VARCHAR(50),
    std_midlename VARCHAR(50),
    std_lastname VARCHAR(50),
    std_motherName VARCHAR(50),
    std_gender CHAR(1),
    std_DOB DATE,
    std_mobile VARCHAR(15),
    std_parentMobile VARCHAR(15),
    std_email VARCHAR(100),
    std_adharno VARCHAR(20),
    std_photo VARCHAR(255),
    std_localaddress TEXT,
    std_religion VARCHAR(50),
    std_category VARCHAR(50),
    std_cast VARCHAR(50),
    std_mothertoung VARCHAR(50),
    fk_std_addressid INT foreign key,
FOREIGN KEY (fk_std_addressid) REFERENCES addresstable(addressid)

);

-- added two more fields to student data regid and regdate
alter table studentData add column regid int unique auto_increment, add column regdate timestamp not null DEFAULT current_timestamp;

CREATE TABLE studentAcademicData (
    academicid INT AUTO_INCREMENT PRIMARY KEY,
    std_abcid BIGINT,
    passingyear YEAR,
    class VARCHAR(20),
    oldmarks DECIMAL(5,2),
    schoolname VARCHAR(100),
    currentyear YEAR,
    currentclass VARCHAR(20),
    division VARCHAR(10),
    rollno INT,
    regdate DATE,
    currentschoolname VARCHAR(100),
    FOREIGN KEY (std_abcid) REFERENCES studentData(std_abcid)
);

CREATE TABLE documentsSubmitted (
    docid INT AUTO_INCREMENT PRIMARY KEY,
    accid INT,
    tc BOOLEAN DEFAULT FALSE,
    adharcard BOOLEAN DEFAULT FALSE,
    oldmarksheet BOOLEAN DEFAULT FALSE,
    submission_date DATE DEFAULT CURRENT_DATE,
    FOREIGN KEY (accid) REFERENCES studentAcademicData(accid)
);

CREATE TABLE feesTable (
    feeid INT AUTO_INCREMENT PRIMARY KEY,
    accid INT,
    total_fees DECIMAL(10,2),
    paid DECIMAL(10,2),
    due DECIMAL(10,2),
    remarkdue TEXT,
    payment_status VARCHAR(20) DEFAULT 'Pending',
    FOREIGN KEY (accid) REFERENCES studentAcademicData(accid)
);

CREATE TABLE marks (
    markid INT AUTO_INCREMENT PRIMARY KEY,
    accid INT,
    stdid VARCHAR(20),
    totalmark INT,
    obtainedmark INT,
    math INT,
    science INT,
    english INT,
    history INT,
    geography INT,
    marathi INT,
    hindi INT,
    exam_date DATE,
    FOREIGN KEY (accid) REFERENCES studentAcademicData(accid)
);


