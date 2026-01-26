/* =========================================
   Gym Management System - Database Script
   ========================================= */
CREATE DATABASE GymDB;
GO

USE GymDB;
GO

-- =========================
-- 1. Receptionist Table
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ReceptionistTbl')
BEGIN
    CREATE TABLE [dbo].[ReceptionistTbl] (
        [ReceptId] INT IDENTITY(1,1) NOT NULL,
        [RecepName] VARCHAR(50) NOT NULL,
        [RecepGen] VARCHAR(50) NOT NULL,
        [RecepDOB] DATE NOT NULL,
        [RecepAdd] VARCHAR(50) NOT NULL,
        [RecepPhone] VARCHAR(50) NOT NULL,
        CONSTRAINT PK_Receptionist PRIMARY KEY CLUSTERED ([ReceptId])
    );
END
GO

-- =========================
-- 2. User Table
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'UserTbl')
BEGIN
    CREATE TABLE [dbo].[UserTbl] (
        [UserId] INT IDENTITY(1,1) NOT NULL,
        [Username] NVARCHAR(50) NOT NULL,
        [Password] NVARCHAR(50) NOT NULL,
        [Role] NVARCHAR(50) NOT NULL,
        [StaffId] INT NULL,
        CONSTRAINT PK_User PRIMARY KEY CLUSTERED ([UserId]),
        CONSTRAINT FK_User_Receptionist 
            FOREIGN KEY ([StaffId]) 
            REFERENCES [dbo].[ReceptionistTbl] ([ReceptId]) 
            ON DELETE CASCADE
    );
END
GO

-- =========================
-- 3. Coach Table
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CoachsTbl')
BEGIN
    CREATE TABLE [dbo].[CoachsTbl] (
        [CId] INT IDENTITY(1,1) NOT NULL,
        [CName] VARCHAR(50) NOT NULL,
        [CGen] VARCHAR(50) NOT NULL,
        [CDOB] DATE NOT NULL,
        [CPhone] VARCHAR(50) NOT NULL,
        [CExperience] VARCHAR(50) NOT NULL,
        [CAddress] VARCHAR(50) NOT NULL,
        [UserId] INT NULL,
        CONSTRAINT PK_Coachs PRIMARY KEY CLUSTERED ([CId]),
        CONSTRAINT FK_Coach_User 
            FOREIGN KEY ([UserId]) 
            REFERENCES [dbo].[UserTbl] ([UserId]) 
            ON DELETE CASCADE
    );
END
GO

-- =========================
-- 4. Memberships Table
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MembershipsTbl')
BEGIN
    CREATE TABLE [dbo].[MembershipsTbl] (
        [MShipid] INT IDENTITY(1,1) NOT NULL,
        [MName] VARCHAR(50) NOT NULL,
        [MDuration] INT NOT NULL,
        [MGoal] VARCHAR(50) NOT NULL,
        [MCost] INT NOT NULL,
        CONSTRAINT PK_Memberships PRIMARY KEY CLUSTERED ([MShipid])
    );
END
GO

-- =========================
-- 5. Members Table
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MembersTbl')
BEGIN
    CREATE TABLE [dbo].[MembersTbl] (
        [MId] INT IDENTITY(1,1) NOT NULL,
        [MName] VARCHAR(50) NOT NULL,
        [MGen] VARCHAR(10) NOT NULL,
        [MDOB] DATE NOT NULL,
        [MJDate] DATE NOT NULL,
        [MMembership] INT NOT NULL,
        [MCoach] INT NOT NULL,
        [MPhone] VARCHAR(20) NOT NULL,
        [MTiming] VARCHAR(20) NOT NULL,
        [MStatus] VARCHAR(20) NOT NULL,
        [IsDeleted] BIT NOT NULL DEFAULT (0),
        CONSTRAINT PK_Members PRIMARY KEY CLUSTERED ([MId]),
        CONSTRAINT FK_Member_Membership 
            FOREIGN KEY ([MMembership]) 
            REFERENCES [dbo].[MembershipsTbl] ([MShipid]),
        CONSTRAINT FK_Member_Coach 
            FOREIGN KEY ([MCoach]) 
            REFERENCES [dbo].[CoachsTbl] ([CId])
    );
END
GO

-- =========================
-- 6. Finance Table
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FinanceTbl')
BEGIN
    CREATE TABLE [dbo].[FinanceTbl] (
        [BillId] INT IDENTITY(1,1) NOT NULL,
        [Agent] INT NOT NULL,
        [Member] INT NOT NULL,
        [BPeriod] VARCHAR(50) NOT NULL,
        [BDate] DATE NOT NULL,
        [BAmount] INT NOT NULL,
        CONSTRAINT PK_Finance PRIMARY KEY CLUSTERED ([BillId]),
        CONSTRAINT FK_Finance_User 
            FOREIGN KEY ([Agent]) 
            REFERENCES [dbo].[UserTbl] ([UserId]),
        CONSTRAINT FK_Finance_Member 
            FOREIGN KEY ([Member]) 
            REFERENCES [dbo].[MembersTbl] ([MId])
    );
END
GO

-- =========================
-- 7. Tracker Table
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TrackerTbl')
BEGIN
    CREATE TABLE [dbo].[TrackerTbl] (
        [SessionId] INT IDENTITY(1,1) NOT NULL,
        [MemberId] INT NOT NULL,
        [StartTime] DATETIME NOT NULL,
        [EndTime] DATETIME NULL,
        [Status] VARCHAR(20) NOT NULL,
        [Duration] INT NOT NULL,
        CONSTRAINT PK_Tracker PRIMARY KEY CLUSTERED ([SessionId]),
        CONSTRAINT FK_Tracker_Member 
            FOREIGN KEY ([MemberId]) 
            REFERENCES [dbo].[MembersTbl] ([MId]) 
            ON DELETE CASCADE
    );
END
GO

-- =========================
-- Initial Admin User
-- =========================
IF NOT EXISTS (SELECT * FROM UserTbl WHERE Username = 'admin')
BEGIN
    INSERT INTO UserTbl (Username, [Password], Role, StaffId)
    VALUES ('admin', '123', 'Admin', NULL);
END
GO
