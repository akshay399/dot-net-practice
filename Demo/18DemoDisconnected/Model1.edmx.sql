
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/03/2023 18:45:53
-- Generated from EDMX file: C:\Users\caksh\Desktop\my-git-class-lab-internal\dotnet-git\Demo\18DemoDisconnected\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [punedb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EmpDept]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Emps] DROP CONSTRAINT [FK_EmpDept];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Emps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Emps];
GO
IF OBJECT_ID(N'[dbo].[Tests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tests];
GO
IF OBJECT_ID(N'[dbo].[Depts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Depts];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Emps'
CREATE TABLE [dbo].[Emps] (
    [no] int  NOT NULL,
    [name] varchar(10)  NULL,
    [address] varchar(10)  NULL,
    [DeptDeptId] int  NOT NULL
);
GO

-- Creating table 'Tests'
CREATE TABLE [dbo].[Tests] (
    [TestNo] int  NOT NULL,
    [TestName] varchar(50)  NULL
);
GO

-- Creating table 'Depts'
CREATE TABLE [dbo].[Depts] (
    [DeptId] int IDENTITY(1,1) NOT NULL,
    [DeptName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [no] in table 'Emps'
ALTER TABLE [dbo].[Emps]
ADD CONSTRAINT [PK_Emps]
    PRIMARY KEY CLUSTERED ([no] ASC);
GO

-- Creating primary key on [TestNo] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([TestNo] ASC);
GO

-- Creating primary key on [DeptId] in table 'Depts'
ALTER TABLE [dbo].[Depts]
ADD CONSTRAINT [PK_Depts]
    PRIMARY KEY CLUSTERED ([DeptId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptDeptId] in table 'Emps'
ALTER TABLE [dbo].[Emps]
ADD CONSTRAINT [FK_EmpDept]
    FOREIGN KEY ([DeptDeptId])
    REFERENCES [dbo].[Depts]
        ([DeptId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpDept'
CREATE INDEX [IX_FK_EmpDept]
ON [dbo].[Emps]
    ([DeptDeptId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------