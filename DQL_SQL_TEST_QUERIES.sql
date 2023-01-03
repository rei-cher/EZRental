--selecting database
USE EZRentalDB;

--Insert statements for DRIVERLICENSE table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from DRIVERLICENSE;

--Insert query
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('111111111', '01/15/2022', 'NY');
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('222222222', '02/15/2022', 'NY');
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('333333333', '03/15/2022', 'NJ');
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('444444444', '04/15/2022', 'NJ');
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('555555555', '05/15/2022', 'AL');

Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('666666666', '01/15/2022', 'NY');
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('777777777', '02/15/2022', 'NY');
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('888888888', '03/15/2022', 'NJ');
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('999999999', '04/15/2022', 'NJ');
Insert into DRIVERLICENSE(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
values ('000000000', '05/15/2022', 'AL');

/*Select statement after inserting values into the table
  The output is populated table*/

Select * from DRIVERLICENSE;




--Insert statements for CUSTOMERUSERACCOUNT table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from CUSTOMERUSERACCOUNT;

--Insert query
Insert into CUSTOMERUSERACCOUNT(Username, Password, Email)
values ('Cust111', 'Pas111', 'cust111@mail.com');
Insert into CUSTOMERUSERACCOUNT(Username, Password, Email)
values ('Cust222', 'Pas222', 'cust222@mail.com');
Insert into CUSTOMERUSERACCOUNT(Username, Password, Email)
values ('Cust333', 'Pas333', 'cust333@mail.com');
Insert into CUSTOMERUSERACCOUNT(Username, Password, Email)
values ('Cust444', 'Pas444', 'cust444@mail.com');
Insert into CUSTOMERUSERACCOUNT(Username, Password, Email)
values ('Cust555', 'Pas555', 'cust555@mail.com');

/*Select statement after inserting values into the table
  The output is populated table*/

Select * from CUSTOMERUSERACCOUNT;




--Insert statements for CUSTOMER table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from CUSTOMER;

--Insert query
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode,
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID, 
			CustomerType)
values('Johan', 'Wilks', '11/22/2022', '1111 Jay St.', '', 'Brooklyn', 'NY', '11209', 'USA',
			'(505) 111-1111', 'johanwilks@mail.com', '111111111', 
			'EC8556C9-DDC4-4689-9966-070597C8B1AF', 'R');
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,
			CustomerType)
values('Velma', 'Hulme', '11/22/2006', '5555 Jay St.', '', 'Brooklyn', 'NY', '11259', 'USA',
			'(505) 555-5555', 'Velma@mail.com', '555555555', 
			'6550AC12-1175-4FF3-AEEB-0A7596E0EE6E', 'R');
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID, 
			CustomerType)
values('Mikhaeel', 'Hussain', '11/22/1985', '4444 Jay St.', '', 'Manhattan', 'NY', '11249', 'USA',
			'(505) 444-4444', 'Mikhaeel@mail.com', '444444444', 
			'99869F5A-9765-47CA-8BB5-3007E6218052', 'R');
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID, 
			CustomerType)
values('Samual', 'Nicholls', '11/22/2000', '2222 Jay St.', '', 'Trenton', 'NJ', '11229', 'USA', 
			'(505) 222-2222', 'Samual@mail.com', '222222222',
			'ED033858-4ECC-42BE-9EA8-41D0F36450C0', 'R');
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode,
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID, 
			CustomerType)
values('Silas', 'Decker', '11/22/1996', '3333 Jay St.', '', 'Trenton', 'NJ', '11239', 'USA',
			'(505) 333-3333', 'Silas@mail.com', '333333333', 
			'D209E432-042A-4839-BE7E-77DCB5FCF3F4', 'R');

Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode,
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID, 
			CustomerType)
values('Johan', 'Wilks', '11/22/2022', '1111 Jay St.', '', 'Brooklyn', 'NY', '11209', 'USA',
			'(505) 111-1111', 'johanwilks6@mail.com', '666666666', 
			'EC8556C9-DDC4-4689-9966-070597C8B1AF', 'C');
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,
			CustomerType)
values('Velma', 'Hulme', '11/22/2006', '5555 Jay St.', '', 'Brooklyn', 'NY', '11259', 'USA',
			'(505) 555-5555', 'Velma7@mail.com', '777777777', 
			'6550AC12-1175-4FF3-AEEB-0A7596E0EE6E', 'C');
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID, 
			CustomerType)
values('Mikhaeel', 'Hussain', '11/22/1985', '4444 Jay St.', '', 'Manhattan', 'NY', '11249', 'USA',
			'(505) 444-4444', 'Mikhaeel8@mail.com', '888888888', 
			'99869F5A-9765-47CA-8BB5-3007E6218052', 'C');
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID, 
			CustomerType)
values('Samual', 'Nicholls', '11/22/2000', '2222 Jay St.', '', 'Trenton', 'NJ', '11229', 'USA', 
			'(505) 222-2222', 'Samual9@mail.com', '999999999',
			'ED033858-4ECC-42BE-9EA8-41D0F36450C0', 'C');
Insert into CUSTOMER(FirstName, LasrName, BirthDate, AddressLine1, AddressLine2, City, StateCode,
			ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID, 
			CustomerType)
values('Silas', 'Decker', '11/22/1996', '3333 Jay St.', '', 'Trenton', 'NJ', '11239', 'USA',
			'(505) 333-3333', 'Silas0@mail.com', '000000000', 
			'D209E432-042A-4839-BE7E-77DCB5FCF3F4', 'C');

/*Select statement after inserting values into the table
  The output is populated table*/

Select * from CUSTOMER;





--Insert statements for CREDITCARDMERCHANT table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from CREDITCARDMERCHANT;

--Insert query
Insert into CREDITCARDMERCHANT(MerchantCode, MerchantName)
values (1, 'Stax by Fattmerchant');
Insert into CREDITCARDMERCHANT(MerchantCode, MerchantName)
values (2, 'Helcim');
Insert into CREDITCARDMERCHANT(MerchantCode, MerchantName)
values (3, 'Dharma Merchant Services');
Insert into CREDITCARDMERCHANT(MerchantCode, MerchantName)
values (4, 'Payment Depot');
Insert into CREDITCARDMERCHANT(MerchantCode, MerchantName)
values (5, 'National Processing');

/*Select statement after inserting values into the table
  The output is populated table*/

Select * from CREDITCARDMERCHANT;





--Insert statements for CREDITCARD table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from CREDITCARD;

--Insert query
Insert into CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,
	MerchantCode, ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode, Country,
	CreditCardLimit, CreditCardBalance, ActivationStatus)
values ('1111111111111111', 'Johan Wilks', 'American Express', 1, '01/01/2024', '1111 Jay St.',
	'', 'Brooklyn', 'NY', '11209', 'USA', 10000.00, 256.21, 'True');
Insert into CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,
	MerchantCode, ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode, Country,
	CreditCardLimit, CreditCardBalance, ActivationStatus)
values ('2222222222222222', 'Samual Nicholls', 'TD Bank', 1, '03/20/2024', '2222 Jay St.',
	'', 'Trenton', 'NJ', '11229', 'USA', 8000.00, 4230.86, 'True');
Insert into CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,
	MerchantCode, ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode, Country,
	CreditCardLimit, CreditCardBalance, ActivationStatus)
values ('3333333333333333', 'Silas Decker', 'American Express', 1, '05/22/2025', '3333 Jay St.',
	'', 'Trenton', 'NJ', '11239', 'USA', 10000.00, 256.21, 'True');
Insert into CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,
	MerchantCode, ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode, Country,
	CreditCardLimit, CreditCardBalance, ActivationStatus)
values ('4444444444444444', 'Mikhaeel Hussain', 'Chase Bank', 1, '01/01/2024', '4444 Jay St.',
	'', 'Manhattan', 'NY', '11249', 'USA', 10000.00, 256.21, 'False');
Insert into CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,
	MerchantCode, ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode, Country,
	CreditCardLimit, CreditCardBalance, ActivationStatus)
values ('5555555555555555', 'Velma Hulme', 'American Express', 1, '01/01/2024', '5555 Jay St.',
	'', 'Brooklyn', 'NY', '11259', 'USA', 500.00, 256.21, 'True');
Insert into CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,
	MerchantCode, ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode, Country,
	CreditCardLimit, CreditCardBalance, ActivationStatus)
values ('6666666666666666', 'Artur Smith', 'American Express', 3, '01/01/2024', '6666 Jay St.',
	'', 'Brooklyn', 'NY', '11269', 'USA', 500.00, 0.00, 'True');


/*Select statement after inserting values into the table
  The output is populated table*/

Select * from CREDITCARD;





--Insert statements for CUSTOMER_CREDITCARD table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from CUSTOMER_CREDITCARD;

--Insert query
Insert into CUSTOMER_CREDITCARD(CreditCardNumber, CustomerID)
values('1111111111111111', 1);
Insert into CUSTOMER_CREDITCARD(CreditCardNumber, CustomerID)
values('2222222222222222', 4);
Insert into CUSTOMER_CREDITCARD(CreditCardNumber, CustomerID)
values('3333333333333333', 5);
Insert into CUSTOMER_CREDITCARD(CreditCardNumber, CustomerID)
values('4444444444444444', 3);
Insert into CUSTOMER_CREDITCARD(CreditCardNumber, CustomerID)
values('5555555555555555', 2);


/*Select statement after inserting values into the table
  The output is populated table*/

Select * from CUSTOMER_CREDITCARD;





--Insert statements for DISCOUNT table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from DISCOUNT;

--Insert query
Insert into DISCOUNT(DiscountCode, DiscountCodeDesc)
values('AAA9970054', 'AAA Membership Discount - 25% off base
	rate plus 10% donated for breast cancer research');
Insert into DISCOUNT(DiscountCode, DiscountCodeDesc)
values('GOV8756921', 'Government Employee Discount - 30% off
	base rate');
Insert into DISCOUNT(DiscountCode, DiscountCodeDesc)
values('STA3415632', 'State Employee Discount for 25% off base
	rate');
Insert into DISCOUNT(DiscountCode, DiscountCodeDesc)
values('VET2055179', 'Veteran Discount 35% off base rate Plus
	10% donation to veteran’s family fund');
Insert into DISCOUNT(DiscountCode, DiscountCodeDesc)
values('AAA9974432', 'AAA Membership Discount - 10% off base
	rate plus 60% donated for breast cancer research');


/*Select statement after inserting values into the table
  The output is populated table*/

Select * from DISCOUNT;




--Insert statements for EZPLUS table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from EZPLUS;

--Insert query
Insert into EZPLUS(EZPLusRewardCode, EZPlusRewardEarnedPoints)
values ('EZP9009854637', 10000);
Insert into EZPLUS(EZPLusRewardCode, EZPlusRewardEarnedPoints)
values ('EZP1000192461', 500);
Insert into EZPLUS(EZPLusRewardCode, EZPlusRewardEarnedPoints)
values ('EZP6493238865', 159000);
Insert into EZPLUS(EZPLusRewardCode, EZPlusRewardEarnedPoints)
values ('EZP2005135627', 23000);
Insert into EZPLUS(EZPLusRewardCode, EZPlusRewardEarnedPoints)
values ('EZP6842134756', 850000);


/*Select statement after inserting values into the table
  The output is populated table*/

Select * from EZPLUS;




--Insert statements for RETAILCUSTOMER table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from RETAILCUSTOMER;

--Insert query
Insert into RETAILCUSTOMER(CustomerID, DiscountID, EZPlusID)
values (1, 2, 1);
Insert into RETAILCUSTOMER(CustomerID, DiscountID, EZPlusID)
values (2, 3, 2);
Insert into RETAILCUSTOMER(CustomerID, DiscountID, EZPlusID)
values (3, 4, 3);
Insert into RETAILCUSTOMER(CustomerID, DiscountID, EZPlusID)
values (4, 5, 4);
Insert into RETAILCUSTOMER(CustomerID, DiscountID, EZPlusID)
values (5, 6, 5);


/*Select statement after inserting values into the table
  The output is populated table*/

Select * from RETAILCUSTOMER;





--Insert statements for COMPANY table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from COMPANY;

--Insert query
Insert into COMPANY(CompanyID, CompanyName, AddressLine1, AddressLine2,
	City, StateCode, ZipCode, Country, CompanyRepName, ContactPhone,
	ContactEmail, CorporateDiscountPercentageRate)
values(1, 'Company 1', '1111 Jay st.', '', 'Brroklyn', 'NY', '11209', 
	'USA', 'Jack Reacher', '(718) 111-1111', 'JackReacher@mail.com', 23.56);
Insert into COMPANY(CompanyID, CompanyName, AddressLine1, AddressLine2,
	City, StateCode, ZipCode, Country, CompanyRepName, ContactPhone,
	ContactEmail, CorporateDiscountPercentageRate)
values(2, 'Company 2', '2222 Jay st.', '', 'Brroklyn', 'NY', '11219', 
	'USA', 'Malachi Proctor', '(718) 222-2222', 'MalachiProctor@mail.com', 2.50);
Insert into COMPANY(CompanyID, CompanyName, AddressLine1, AddressLine2,
	City, StateCode, ZipCode, Country, CompanyRepName, ContactPhone,
	ContactEmail, CorporateDiscountPercentageRate)
values(3, 'Company 3', '3333 Jay st.', '', 'Brroklyn', 'NY', '11229', 
	'USA', 'Gilbert Dennis', '(718) 333-3333', 'GilbertDennis@mail.com', 42.13);
Insert into COMPANY(CompanyID, CompanyName, AddressLine1, AddressLine2,
	City, StateCode, ZipCode, Country, CompanyRepName, ContactPhone,
	ContactEmail, CorporateDiscountPercentageRate)
values(4, 'Company 4', '4444 Jay st.', '', 'Brroklyn', 'NY', '11239', 
	'USA', 'Jude Hudson', '(718) 444-4444', 'JudeHudson@mail.com', 20.35);
Insert into COMPANY(CompanyID, CompanyName, AddressLine1, AddressLine2,
	City, StateCode, ZipCode, Country, CompanyRepName, ContactPhone,
	ContactEmail, CorporateDiscountPercentageRate)
values(5, 'Company 5', '5555 Jay st.', '', 'Brroklyn', 'NY', '11249', 
	'USA', 'Frazer Downs', '(718) 555-5555', 'FrazerDowns@mail.com', 68.00);
Insert into COMPANY(CompanyID, CompanyName, AddressLine1, AddressLine2,
	City, StateCode, ZipCode, Country, CompanyRepName, ContactPhone,
	ContactEmail, CorporateDiscountPercentageRate)
values(6, 'Company 6', '6666 Jay st.', '', 'Brroklyn', 'NY', '11259', 
	'USA', 'Frazer Downs', '(718) 666-6666', 'FrazerDowns6@mail.com', 68.00);


/*Select statement after inserting values into the table
  The output is populated table*/

Select * from COMPANY;




--Insert statements for CORPORATECUSTOMER table

/*Select statement before inserting any values into the table
  The output is an empty table*/

Select * from CORPORATECUSTOMER;

--Insert query
Insert into CORPORATECUSTOMER (CustomerID, CompanyID)
values (16, 1);
Insert into CORPORATECUSTOMER (CustomerID, CompanyID)
values (17, 2);
Insert into CORPORATECUSTOMER (CustomerID, CompanyID)
values (18, 3);
Insert into CORPORATECUSTOMER (CustomerID, CompanyID)
values (19, 4);
Insert into CORPORATECUSTOMER (CustomerID, CompanyID)
values (20, 5);


/*Select statement after inserting values into the table
  The output is populated table*/

Select * from CORPORATECUSTOMER;
Select * from EZPLUS;




--Select statements

Select * from CUSTOMER where CustomerID = 1;

Select * from CUSTOMER where StateCode = 'NY';

Select c.FirstName, c.LasrName, c.Phone, d.DiscountCode, d.DiscountCodeDesc, 
	e.EZPLusRewardCode, e.EZPlusRewardEarnedPoints
from CUSTOMER as c, DISCOUNT as d, EZPLUS as e, RETAILCUSTOMER as r
where r.CustomerID = c.CustomerID and d.DiscountID = r.DiscountID and 
	e.EZPlusID = r.EZPlusID and e.EZPlusRewardEarnedPoints > 20000
order by c.LasrName;





--Update statements

Select * from EZPLUS;

Update EZPLUS
set EZPLusRewardCode = 'NEW9009854637',
	EZPlusRewardEarnedPoints = 99999
where EZPlusID = 1;



Select * from CREDITCARD;

Update CREDITCARD
set MerchantCode = '2', CreditCardBalance = 15632.26, ActivationStatus = 'False'
where CreditCardNumber = '5555555555555555';





--Delete statements

Select * from COMPANY;

Delete
from COMPANY
where CompanyID = 6;


Select * from CREDITCARD;

Delete
from CREDITCARD
where CreditCardBalance = 0;