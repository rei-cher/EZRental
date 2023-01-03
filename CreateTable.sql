--creating database
CREATE DATABASE EZRentalDB;

--selecting database
USE EZRentalDB;

--creating DRIVERLICENSE table
CREATE TABLE DRIVERLICENSE(
	DriverLicenseNumber		VARCHAR(25)		PRIMARY KEY,
	DriverLicenseExpDate	DATE			NOT NULL,
	DriverLicenseState		CHAR(2)			NOT NULL
);

--creating CUSTOMERUSERACCOUNT table
CREATE TABLE CUSTOMERUSERACCOUNT(
	CustomerUserAccountID	UNIQUEIDENTIFIER	PRIMARY KEY DEFAULT newid(),
	Username				VARCHAR(50)			UNIQUE	NOT NULL,
	Password				VARCHAR(20)			NOT NULL,
	Email					VARCHAR(100)		UNIQUE	NOT NULL
);

--creating CUSTOMER table
CREATE TABLE CUSTOMER(
	CustomerID				INT IDENTITY		PRIMARY KEY,
	FirstName				VARCHAR(50)			NOT NULL,
	LasrName				VARCHAR(50)			NOT NULL,
	BirthDate				DATE				NOT NULL, 
	AddressLine1			VARCHAR(50)			NOT NULL,
	AddressLine2			VARCHAR(50)			NULL, 
	City					VARCHAR(30)			NOT NULL,
	StateCode				CHAR(2)				NOT NULL, 
	ZipCode					VARCHAR(10)			NOT NULL,
	Counrty					VARCHAR(50)			NOT NULL,
	Phone					VARCHAR(20)			NOT NULL,
	Email					VARCHAR(100)		UNIQUE NOT NULL,
	DriverLicenseNumber		VARCHAR(25)			UNIQUE NOT NULL,
	CustomerUserAccountID	UNIQUEIDENTIFIER	NULL,
	CustomerType			CHAR(1)				NOT NULL,

	CONSTRAINT fk_DriverLicenseNumber FOREIGN KEY (DriverLicenseNumber) REFERENCES DRIVERLICENSE(DriverLicenseNumber) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_CustomerUserAccountID FOREIGN KEY (CustomerUserAccountID) REFERENCES CUSTOMERUSERACCOUNT(CustomerUserAccountID) ON DELETE CASCADE ON UPDATE CASCADE
);

--creating CREDITCARDMERCHANT table
CREATE TABLE CREDITCARDMERCHANT(
	MerchantCode	TINYINT			PRIMARY KEY CHECK(MerchantCode>=1 AND MerchantCode<=20),
	MerchantName	VARCHAR(50)		NOT NULL
);

--creating CREDITCARD table
CREATE TABLE CREDITCARD(
	CreditCardNumber			VARCHAR(16)		PRIMARY KEY,
	CreditCardOwnerName			VARCHAR(50)		NOT NULL,
	CreditCardIssuingCompany	VARCHAR(50)		NOT NULL,
	MerchantCode				TINYINT			NOT NULL CHECK(MerchantCode>=1 AND MerchantCode<=20),
	ExpDate						DATE			NOT NULL,
	AddressLine1				VARCHAR(50)		NOT NULL,
	AddressLine2				VARCHAR(50)		NULL, 
	City						VARCHAR(30)		NOT NULL,
	StateCode					CHAR(2)			NOT NULL, 
	ZipCode						VARCHAR(10)		NOT NULL,
	Counrty						VARCHAR(50)		NOT NULL,
	CreditCardLimit				DECIMAL(8,2)	NOT NULL,
	CreditCardBalance			DECIMAL(8,2)	NOT NULL,
	ActivationStatus			BIT				NOT NULL,

	CONSTRAINT fk_MerchantCode FOREIGN KEY (MerchantCode) REFERENCES CREDITCARDMERCHANT(MerchantCode) ON DELETE CASCADE ON UPDATE CASCADE
);

--creating CUSTOMER_CREDITCARD table
CREATE TABLE CUSTOMER_CREDITCARD(
	CreditCardNumber	VARCHAR(16)		NOT NULL,
	CustomerID			INT				NOT NULL,

	CONSTRAINT pk_CreditCardNumber_CustomerID PRIMARY KEY (CreditCardNumber,CustomerID),
	CONSTRAINT fk_CreditCardNumber FOREIGN KEY (CreditCardNumber) REFERENCES CREDITCARD(CreditCardNumber) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_CustomerID FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(CustomerID) ON DELETE CASCADE ON UPDATE CASCADE
);

--creating EZPLUS table 
CREATE TABLE EZPLUS(
	EZPlusID					INT IDENTITY	PRIMARY KEY,
	EZPLusRewardCode			VARCHAR(13)		UNIQUE NOT NULL,
	EZPlusRewardEarnedPoints	VARCHAR(150)	NOT NULL
);

--creating DISCOUNT table
CREATE TABLE DISCOUNT(
	DiscountID			INT IDENTITY	PRIMARY KEY,
	DiscountCode		CHAR(10)		UNIQUE NOT NULL,
	DiscountCodeDesc	VARCHAR(150)	NOT NULL
);

--creating RETAILCUSTOMER table
CREATE TABLE RETAILCUSTOMER(
	CustomerID		INT		NOT NULL,
	DiscountID		INT		NULL,
	EZPlusID		INT		NULL,

	CONSTRAINT pk_Retail_CustomerID PRIMARY KEY (CustomerID),
	CONSTRAINT fk_Retail_CustomerID FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(CustomerID) ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_DiscountID FOREIGN KEY (DiscountID) REFERENCES DISCOUNT(DiscountID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_EZPlusID FOREIGN KEY (EZPlusID) REFERENCES EZPLUS(EZPlusID) ON DELETE CASCADE ON UPDATE CASCADE
);

--creating COMPANY table
CREATE TABLE COMPANY(
	CompanyID							INT				PRIMARY KEY CHECK(CompanyID>=1 AND CompanyID<=50000),
	CompanyName							VARCHAR(50)		UNIQUE NOT NULL,
	AddressLine1						VARCHAR(50)		NOT NULL,
	AddressLine2						VARCHAR(50)		NULL, 
	City								VARCHAR(30)		NOT NULL,
	StateCode							CHAR(2)			NOT NULL, 
	ZipCode								VARCHAR(10)		NOT NULL,
	Counrty								VARCHAR(50)		NOT NULL,
	CompanyRepName						VARCHAR(100)	NOT NULL,
	ContactPhone						VARCHAR(20)		NOT NULL,
	ContactEmail						VARCHAR(100)	UNIQUE NOT NULL,
	CorporateDiscountPercentageRate		DECIMAL(4,2)	NOT NULL
);

--creating CORPORATECUSTOMER table
CREATE TABLE CORPORATECUSTOMER(
	CustomerID	INT		NOT NULL,
	CompanyID	INT		NOT NULL CHECK(CompanyID>=1 AND CompanyID<=50000),

	CONSTRAINT pk_Corporate_CustomerID PRIMARY KEY (CustomerID),
	CONSTRAINT fk_Corporate_CustomerID FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(CustomerID) ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_CompanyID FOREIGN KEY (CompanyID) REFERENCES COMPANY(CompanyID) ON DELETE CASCADE ON UPDATE CASCADE
);

--creating USSTATES table
CREATE TABLE USSTATES(
	StateID			TINYINT			PRIMARY KEY CHECK(StateID between 1 and 75),
	StateCode2Char	CHAR(2)			UNIQUE NOT NULL,
	StateName		VARCHAR(50)		NOT NULL
);

--creating COUNTRY table
CREATE TABLE COUNTRY(
	CountyID			TINYINT			PRIMARY KEY CHECK(CountyID between 1  and 250),
	CountryCode2Char	CHAR(2)			UNIQUE NOT NULL,
	CountryCode3Char	CHAR(3)			UNIQUE NOT NULL,
	CountryName			VARCHAR(100)	NOT NULL
);