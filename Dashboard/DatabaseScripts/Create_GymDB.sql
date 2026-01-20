-- Create the database
IF DB_ID('GymDB') IS NULL
    CREATE DATABASE GymDB;
GO

-- Use the database
USE GymDB;
GO

-- Create the CoachsTbl table
CREATE TABLE [dbo].[CoachsTbl]
(
    [CId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CName] VARCHAR(50) NOT NULL, 
    [CGen] VARCHAR(50) NOT NULL,
    [CDOB] DATE NOT NULL, 
    [CPhone] VARCHAR(50) NOT NULL, 
    [CExperience] VARCHAR(50) NOT NULL, 
    [CAddress] VARCHAR(50) NOT NULL, 
    [CPass] NCHAR(10) NULL
);
GO

-- Create MembershipsTbl if it does not exist
IF OBJECT_ID('dbo.MembershipsTbl', 'U') IS NULL
CREATE TABLE [dbo].[MembershipsTbl]
(
    [MShipid] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MName] VARCHAR(50) NOT NULL, 
    [MDuration] INT NOT NULL, 
    [MGoal] VARCHAR(50) NOT NULL, 
    [MCost] INT NOT NULL
);
GO

--Receptionist Table
IF OBJECT_ID('dbo.ReceptionistTbl', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[ReceptionistTbl]
    (
        [ReceptId] INT IDENTITY(1,1) PRIMARY KEY,
        [RecepName] VARCHAR(50) NOT NULL,
        [RecepGen] VARCHAR(50) NOT NULL,
        [RecepDOB] DATE NOT NULL,
        [RecepAdd] VARCHAR(50) NOT NULL,
        [RecepPhone] VARCHAR(50) NOT NULL,
        [RecepPass] VARCHAR(50) NOT NULL
    );
END
GO

/* =========================
   Members Table
   ========================= */
IF OBJECT_ID('dbo.MembersTbl', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[MembersTbl]
    (
        [MId] INT IDENTITY(1,1) PRIMARY KEY,
        [MName] VARCHAR(50) NOT NULL,
        [MGen] VARCHAR(10) NOT NULL,
        [MDOB] DATE NOT NULL,
        [MJDate] DATE NOT NULL,
        [MMembership] INT NOT NULL,
        [MCoach] INT NOT NULL,
        [MPhone] VARCHAR(10) NOT NULL,
        [MTiming] VARCHAR(10) NOT NULL,
        [MStatus] VARCHAR(10) NOT NULL,

        CONSTRAINT FK1 
            FOREIGN KEY (MMembership) REFERENCES MembershipsTbl(MShipid),

        CONSTRAINT FK2 
            FOREIGN KEY (MCoach) REFERENCES CoachsTbl(CId)
    );
END
GO
