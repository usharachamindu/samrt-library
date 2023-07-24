-- Create the libraryzone database if it does not exist
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'smartlibraryzone')
CREATE DATABASE smartlibraryzone;

USE smartlibraryzone;

-- Create the mainbranch table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mainbranch]') AND type in (N'U'))
BEGIN
  CREATE TABLE mainbranch (
    MainBranchId INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Address VARCHAR(50) NOT NULL,
    Contact VARCHAR(10) NOT NULL,
    Email VARCHAR(50) DEFAULT NULL,
    PRIMARY KEY (MainBranchId),
    UNIQUE (Email)
  );

  -- Insert values into the mainbranch table
  INSERT INTO mainbranch (MainBranchId, Name, Address, Contact, Email) VALUES
    (1, 'Colombo ', '123 Main St', '1234567890', 'mainbranch1@example.com'),
    (2, 'Kandy', '456 Elm St', '9876543210', 'mainbranch2@example.com'),
	(3, 'Matara', '212 abc St', '5646554567', 'mainbranch3@example.com');
END

-- Create the mainadmin table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mainadmin]') AND type in (N'U'))
BEGIN
  CREATE TABLE mainadmin (
    UserName VARCHAR(15) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    NIC VARCHAR(10) NOT NULL,
    Address VARCHAR(50) NOT NULL,
    Contact VARCHAR(10) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    MainBranchId INT NOT NULL,
    PRIMARY KEY (UserName),
    FOREIGN KEY (MainBranchId) REFERENCES mainbranch(MainBranchId)
  );

  -- Insert values into the mainadmin table
  INSERT INTO mainadmin (UserName, FirstName, LastName, NIC, Address, Contact, Email, MainBranchId) VALUES
    ('UsharaC', 'Admin', 'One', '1234567890', '123 Main St', '1234567890', 'admin1@example.com', 1),
    ('TharushaR', 'Admin', 'Two', '0987654321', '456 Elm St', '9876543210', 'admin2@example.com', 2);
END

-- Create the mainadminlogin table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mainadminlogin]') AND type in (N'U'))
BEGIN
  CREATE TABLE mainadminlogin (
    UserName VARCHAR(15) NOT NULL,
    Password VARCHAR(20) NOT NULL,
    PRIMARY KEY (UserName),
    FOREIGN KEY (UserName) REFERENCES mainadmin(UserName)
  );

  -- Insert values into the mainadminlogin table
  INSERT INTO mainadminlogin (UserName, Password) VALUES
    ('ushara', 'chamindu'),
    ('tharusha', 'rasanjana');
END

-- Create the branch table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[branch]') AND type in (N'U'))
BEGIN
  CREATE TABLE branch (
    BranchId INT NOT NULL,
    BranchName VARCHAR(25) NOT NULL,
    Address VARCHAR(50) NOT NULL,
    Contact VARCHAR(10) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    MainBranchId INT NOT NULL,
    PRIMARY KEY (BranchId),
    FOREIGN KEY (MainBranchId) REFERENCES mainbranch(MainBranchId)
  );

  -- Insert values into the branch table
  INSERT INTO branch (BranchId, BranchName, Address, Contact, Email) VALUES
    (1, 'L-Zone Matara', 'Matara', '0411111111', 'lzonematara@gmail.com'),
    (2, 'L-Zone Galle', 'Galle', '0911111111', 'lzonegalle@gmail.com'),
    (3, 'L-Zone Colombo', 'Colombo', '0111111111', 'lzonecolombo@gmail.com'),
    (4, 'L-Zone Hambantota', 'Hambantota', '0412222222', 'lzonehambantota@gmail.com'),
    (5, 'L-Zone Kalutara', 'Kalutara', '0112424242', 'lzonekalutara@gmail.com');
END

-- Create the employee table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[employee]') AND type in (N'U'))
BEGIN
  CREATE TABLE employee (
    UserName VARCHAR(15) NOT NULL,
    FirstName VARCHAR(25) NOT NULL,
    LastName VARCHAR(25) NOT NULL,
    NIC VARCHAR(10) NOT NULL,
    Address VARCHAR(50) NOT NULL,
    DateOfBirth DATETIME DEFAULT NULL,
    Contact VARCHAR(10) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    RegisteredDate DATETIME DEFAULT NULL,
    BranchId INT NOT NULL,
    PRIMARY KEY (UserName),
    FOREIGN KEY (BranchId) REFERENCES branch(BranchId)
  );

  -- Insert values into the employee table
  INSERT INTO employee (UserName, FirstName, LastName, NIC, Address, DateOfBirth, Contact, Email, RegisteredDate, BranchId) VALUES
    ('JohnDoe', 'John', 'Doe', '9012345678', '123 Main St', '1990-05-15', '1234567890', 'johndoe@gmail.com', '2023-01-01 09:00:00', 1),
    ('EmilyJohnson', 'Emily', 'Johnson', '8901234567', '456 Elm St', '1995-10-20', '9876543210', 'emilyjohnson@gmail.com', '2023-02-01 09:00:00', 2),
    ('SarahSmith', 'Sarah', 'Smith', '7801234567', '789 Oak St', '1988-12-10', '7894561230', 'sarahsmith@gmail.com', '2023-03-01 09:00:00', 3),
    ('MichaelBrown', 'Michael', 'Brown', '6701234567', '567 Pine St', '1992-08-05', '5678901234', 'michaelbrown@gmail.com', '2023-04-01 09:00:00', 4),
    ('JenniferLee', 'Jennifer', 'Lee', '5601234567', '890 Maple St', '1993-06-18', '6789012345', 'jenniferlee@gmail.com', '2023-05-01 09:00:00', 5);
END

-- Create the branchadminlogin table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[branchadminlogin]') AND type in (N'U'))
BEGIN
  CREATE TABLE branchadminlogin (
    UserName VARCHAR(15) NOT NULL,
    Password VARCHAR(20) NOT NULL,
    PRIMARY KEY (UserName),
    FOREIGN KEY (UserName) REFERENCES employee(UserName)
  );

  -- Insert values into the branchadminlogin table
  INSERT INTO branchadminlogin (UserName, Password) VALUES
    ('Danuka', 'Ds@96'),
    ('Nadeera66', 'Nm@98'),
    ('Tp2001', 'Tp@91'),
    ('Thisara03', 'td@123'),
    ('eranda09', 'Ej@456');
END

-- Create the member table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[member]') AND type in (N'U'))
BEGIN
  CREATE TABLE member (
    UserName VARCHAR(15) NOT NULL,
    MemberID INT NOT NULL,
    FirstName VARCHAR(25) NOT NULL,
    LastName VARCHAR(25) NOT NULL,
    Address VARCHAR(25) NOT NULL,
    DateOfBirth DATE DEFAULT NULL,
    Contact VARCHAR(10) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    RegisteredDate DATE DEFAULT NULL,
    BranchId INT NOT NULL,
    PRIMARY KEY (UserName),
    FOREIGN KEY (BranchId) REFERENCES branch(BranchId)
  );

  -- Insert values into the member table
  INSERT INTO member (UserName, MemberID, FirstName, LastName, Address, DateOfBirth, Contact, Email, RegisteredDate, BranchId) VALUES
    ('JohnDoe', 1001, 'John', 'Doe', '123 Main St', '1990-05-15', '1234567890', 'johndoe@gmail.com', '2023-01-01', 1),
    ('EmilyJohnson', 1002, 'Emily', 'Johnson', '456 Elm St', '1995-10-20', '9876543210', 'emilyjohnson@gmail.com', '2023-02-01', 2),
    ('SarahSmith', 1003, 'Sarah', 'Smith', '789 Oak St', NULL, '7894561230', 'sarahsmith@gmail.com', '2023-03-01', 3);
END

-- Create the ebook table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ebook]') AND type in (N'U'))
BEGIN
  CREATE TABLE ebook (
    eBookId INT NOT NULL,
    eBookName VARCHAR(100) NOT NULL,
    Author VARCHAR(50) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    BookAddedDate DATETIME DEFAULT NULL,
    BranchId INT NOT NULL,
    PRIMARY KEY (eBookId),
    FOREIGN KEY (BranchId) REFERENCES branch(BranchId)
  );

  -- Insert values into the ebook table
  INSERT INTO ebook (eBookId, eBookName, Author, Category, BookAddedDate, BranchId) VALUES
    (1, 'Organic Chemistry', 'abcd efg', 'Educational', '2023-07-08 00:00:00', 1),
    (2, 'aqwqwq', 'aaaa', 'aaaa', '2023-07-08 00:00:00', 1),
    (3, 'Harry Potter', 'JK Rowlings', 'Kids', '2023-07-08 00:00:00', 1),
    (4, 'Load of the Ring', 'abcd', 'Stories', '2023-07-08 00:00:00', 1),
    (5, 'Guru Geethaya', 'chingis aithmathau', 'History', '2023-09-18 00:00:00', 1);
END

-- Create the ebookuploadfile table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ebookuploadfile]') AND type in (N'U'))
BEGIN
  CREATE TABLE ebookuploadfile (
    eBookId INT NOT NULL,
    pdf_file VARCHAR(7000) NOT NULL,
    PRIMARY KEY (eBookId),
    FOREIGN KEY (eBookId) REFERENCES ebook(eBookId)
  );

  -- Insert values into the ebookuploadfile table
  INSERT INTO ebookuploadfile (eBookId, pdf_file) VALUES
    (1, 'organic_chemistry.pdf'),
    (2, 'aqwqwq.pdf'),
    (3, 'harry_potter.pdf'),
    (4, 'load_of_the_ring.pdf'),
    (5, 'guru_geethaya.pdf');
END

-- Create the book table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[book]') AND type in (N'U'))
BEGIN
  CREATE TABLE book (
    BookId INT NOT NULL,
    BookName VARCHAR(50) NOT NULL,
    AuthorName VARCHAR(50) NOT NULL,
    Pages INT NOT NULL,
    Category VARCHAR(25) NOT NULL,
    BranchId INT NOT NULL,
    PRIMARY KEY (BookId),
    FOREIGN KEY (BranchId) REFERENCES branch(BranchId)
  );

  -- Insert values into the book table
  INSERT INTO book (BookId, BookName, AuthorName, Pages, Category, BranchId) VALUES
    (1, 'Learn Python', 'John Smith', 300, 'Programming', 1),
    (2, 'The Great Gatsby', 'F. Scott Fitzgerald', 250, 'Fiction', 2),
    (3, 'Introduction to Physics', 'Jane Doe', 400, 'Science', 1),
    (4, 'Harry Potter and the Sorcerer''s Stone', 'J.K. Rowling', 500, 'Fantasy', 3),
    (5, 'To Kill a Mockingbird', 'Harper Lee', 350, 'Classic', 2);
END

-- Create the bookissue table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[bookissue]') AND type in (N'U'))
BEGIN
  CREATE TABLE bookissue (
    IssueDate DATE NOT NULL,
    BookId INT NOT NULL,
    BookName VARCHAR(50) DEFAULT NULL,
    UserName VARCHAR(15) NOT NULL,
    FinalDate DATE DEFAULT NULL,
    PRIMARY KEY (IssueDate, BookId),
    FOREIGN KEY (BookId) REFERENCES book(BookId),
    FOREIGN KEY (UserName) REFERENCES member(UserName)
  );

  -- Insert values into the bookissue table
  INSERT INTO bookissue (IssueDate, BookId, BookName, UserName, FinalDate) VALUES
    ('2023-01-02', 3, 'Introduction to Physics', 'JohnDoe', '2023-02-02'),
    ('2023-02-05', 4, 'Harry Potter and the Sorcerer''s Stone', 'JohnDoe', '2023-03-05'),
    ('2023-03-10', 2, 'The Great Gatsby', 'EmilyJohnson', '2023-04-10'),
    ('2023-04-15', 5, 'To Kill a Mockingbird', 'SarahSmith', '2023-05-15'),
    ('2023-05-20', 1, 'Learn Python', 'JenniferLee', '2023-06-20');
END

-- Create the bookreceive table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[bookreceive]') AND type in (N'U'))
BEGIN
  CREATE TABLE bookreceive (
    BookId INT NOT NULL,
    UserName VARCHAR(15) NOT NULL,
    IssueDate DATE NOT NULL,
    FinalDate DATE NOT NULL,
    ReceiveDate DATE NOT NULL,
    PRIMARY KEY (BookId),
    FOREIGN KEY (BookId) REFERENCES book(BookId),
    FOREIGN KEY (UserName) REFERENCES member(UserName)
  );

  -- Insert values into the bookreceive table
  INSERT INTO bookreceive (BookId, UserName, IssueDate, FinalDate, ReceiveDate) VALUES
    (2, 'JohnDoe', '2023-02-05', '2023-03-05', '2023-03-05'),
    (3, 'JohnDoe', '2023-01-02', '2023-02-02', '2023-02-02'),
    (4, 'EmilyJohnson', '2023-03-10', '2023-04-10', '2023-04-10'),
    (5, 'SarahSmith', '2023-05-20', '2023-06-20', '2023-06-20'),
    (1, 'JenniferLee', '2023-04-15', '2023-05-15', '2023-05-15');
END
