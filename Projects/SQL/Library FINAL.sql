/*************************************
***********FINAL**********************
**************************************/

--CREATE DATABASE OR USE DATABASE

CREATE DATABASE LIBRARY
GO

USE LIBRARY
GO

--CREATE TABLE--
	--Book

		CREATE TABLE tbl_book -- child to tbl_Publisher 
		(book_ID INT PRIMARY KEY IDENTITY (1,1),book_title VARCHAR (50), fk_publisher_ID INT FOREIGN KEY REFERENCES tbl_publisher(publisher_ID))

		CREATE TABLE tbl_bookAuthor-- child to tbl_book
		(bookAuthor_ID INT PRIMARY KEY IDENTITY (100,1),fk_book_ID INT FOREIGN KEY REFERENCES tbl_book(book_ID), bookAuthor_authorName VARCHAR (100))

		CREATE TABLE tbl_publisher--
		(publisher_ID INT PRIMARY KEY IDENTITY (200,1),publisher_name VARCHAR (50), publisher_phone VARCHAR (50))

		CREATE TABLE tbl_bookLoan -- child to tbl_librarybranch and child to tbl_borrower and child to tbl_book
		(bookLoan_ID INT PRIMARY KEY IDENTITY (300,1), fk_book_ID INT FOREIGN KEY REFERENCES tbl_book(book_ID), fk_borrow_ID INT FOREIGN KEY REFERENCES tbl_borrower(borrower_ID), bookLoan_checkOut DATE, bookLoan_dueDate DATE)

		CREATE TABLE tbl_bookCopies -- child to tbl_book and tbl_libraryBranch
		(bookCopies_ID INT PRIMARY KEY IDENTITY (400,1),fk_book_ID INT FOREIGN KEY REFERENCES tbl_book(book_ID), fk_libraryBranch_ID INT FOREIGN KEY REFERENCES tbl_libraryBranch(libraryBranch_ID), bookCopies_numberofCopies INT)

		CREATE TABLE tbl_libraryBranch  
		(libraryBranch_ID INT PRIMARY KEY IDENTITY (600,1), libraryBranch_branchName VARCHAR (50),libraryBranch_Address VARCHAR (100))

		CREATE TABLE tbl_borrower 
		(borrower_ID INT PRIMARY KEY IDENTITY (500,1),borrow_name VARCHAR (50), borrower_Address VARCHAR (100), borrower_phone VARCHAR (20))	

--POPULATE TABLES--

