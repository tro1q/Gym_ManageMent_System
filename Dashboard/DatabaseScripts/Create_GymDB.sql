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
