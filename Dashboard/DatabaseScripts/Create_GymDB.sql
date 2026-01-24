
IF DB_ID('GymDB') IS NULL
    CREATE DATABASE GymDB;
GO


USE GymDB;
GO


CREATE TABLE [dbo].[CoachsTbl] (
    [CId]         INT          IDENTITY (1, 1) NOT NULL,
    [CName]       VARCHAR (50) NOT NULL,
    [CGen]        VARCHAR (50) NOT NULL,
    [CDOB]        DATE         NOT NULL,
    [CPhone]      VARCHAR (50) NOT NULL,
    [CExperience] VARCHAR (50) NOT NULL,
    [CAddress]    VARCHAR (50) NOT NULL,
    [CPass]       VARCHAR(20)   NOT NULL,
    PRIMARY KEY CLUSTERED ([CId] ASC)
);
GO

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
        [MPhone] VARCHAR(20) NOT NULL,
        [MTiming] VARCHAR(20) NOT NULL,
        [MStatus] VARCHAR(20) NOT NULL,
        [IsDeleted] BIT NOT NULL DEFAULT 0,
        CONSTRAINT FK1 FOREIGN KEY (MMembership) REFERENCES MembershipsTbl(MShipid),
        CONSTRAINT FK2 FOREIGN KEY (MCoach) REFERENCES CoachsTbl(CId)
    );
END
GO


IF OBJECT_ID('dbo.FinanceTbl', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[FinanceTbl]
    (
        [BillId] INT IDENTITY(1,1) PRIMARY KEY,
        [Agent] INT NOT NULL,
        [Member] INT NOT NULL,
        [BPeriod] VARCHAR(50) NOT NULL,
        [BDate] DATE NOT NULL,
        [BAmount] INT NOT NULL,

        CONSTRAINT FK_Finance_Receptionist
            FOREIGN KEY (Agent) REFERENCES ReceptionistTbl(ReceptId),

        CONSTRAINT FK_Finance_Member
            FOREIGN KEY (Member) REFERENCES MembersTbl(MId)
    );
END
GO


IF OBJECT_ID('dbo.AdminTbl', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[AdminTbl] (
        [AdminId]   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
        [AdminName] VARCHAR(50) NOT NULL,
        [AdminPass] VARCHAR(50) NOT NULL
    );

    -- Optional: Insert default admin
    INSERT INTO AdminTbl (AdminName, AdminPass)
    VALUES ('admin', '123');
END


IF OBJECT_ID('dbo.TrackerTbl', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[TrackerTbl] (
        [SessionId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [MemberId] INT NOT NULL,
        [StartTime] DATETIME NOT NULL,
        [EndTime] DATETIME NULL,
        [Status] VARCHAR(20) NOT NULL,
        [Duration] INT NOT NULL,
        CONSTRAINT FK5 FOREIGN KEY ([MemberId]) REFERENCES [dbo].[MembersTbl]([MId]) ON DELETE CASCADE
    );
END
GO
