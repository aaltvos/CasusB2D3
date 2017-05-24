
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/24/2017 10:13:04
-- Generated from EDMX file: C:\Users\woute\Documents\Visual Studio 2017\Projects\ErgoBackEnd\ErgoBackEnd\Models\DBModel\ErgoDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ergo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_HAND_GEBHAND_SUB_GEB_PROD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HAND_SUB_GEB_PROD] DROP CONSTRAINT [FK_HAND_GEBHAND_SUB_GEB_PROD];
GO
IF OBJECT_ID(N'[dbo].[FK_SUB_BEGHAND_SUB_GEB_PROD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HAND_SUB_GEB_PROD] DROP CONSTRAINT [FK_SUB_BEGHAND_SUB_GEB_PROD];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODHAND_SUB_GEB_PROD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HAND_SUB_GEB_PROD] DROP CONSTRAINT [FK_PRODHAND_SUB_GEB_PROD];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODREV]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REVs] DROP CONSTRAINT [FK_PRODREV];
GO
IF OBJECT_ID(N'[dbo].[FK_USERREV]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REVs] DROP CONSTRAINT [FK_USERREV];
GO
IF OBJECT_ID(N'[dbo].[FK_CATEntity1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CAT_PROD] DROP CONSTRAINT [FK_CATEntity1];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODEntity1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CAT_PROD] DROP CONSTRAINT [FK_PRODEntity1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[HAND_GEB]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HAND_GEB];
GO
IF OBJECT_ID(N'[dbo].[PRODs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PRODs];
GO
IF OBJECT_ID(N'[dbo].[HAND_SUB_GEB_PROD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HAND_SUB_GEB_PROD];
GO
IF OBJECT_ID(N'[dbo].[SUB_BEG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SUB_BEG];
GO
IF OBJECT_ID(N'[dbo].[REVs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[REVs];
GO
IF OBJECT_ID(N'[dbo].[USERs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERs];
GO
IF OBJECT_ID(N'[dbo].[CATs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CATs];
GO
IF OBJECT_ID(N'[dbo].[CAT_PROD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CAT_PROD];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'HAND_GEB'
CREATE TABLE [dbo].[HAND_GEB] (
    [Hand_ID] int IDENTITY(1,1) NOT NULL,
    [Hand_Name] nvarchar(max)  NOT NULL,
    [Hand_IMG] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PRODs'
CREATE TABLE [dbo].[PRODs] (
    [Prod_ID] int IDENTITY(1,1) NOT NULL,
    [Prod_Name] nvarchar(max)  NOT NULL,
    [Prod_Dat] datetime  NOT NULL,
    [Prod_Size] nvarchar(max)  NOT NULL,
    [Prod_Weight] nvarchar(max)  NOT NULL,
    [Prod_Cost] nvarchar(max)  NULL,
    [Prod_Covered] bit  NULL,
    [Prod_Avail] nvarchar(max)  NULL,
    [Prod_Desc] nvarchar(max)  NULL,
    [Prod_Spec] nvarchar(max)  NULL,
    [Prod_Req] nvarchar(max)  NULL,
    [Prod_Mov] nvarchar(max)  NULL,
    [Prod_Views] bigint  NULL,
    [Prod_Validator] nvarchar(max)  NOT NULL,
    [Prod_Val_Dat] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HAND_SUB_GEB_PROD'
CREATE TABLE [dbo].[HAND_SUB_GEB_PROD] (
    [Hand_ID] int  NOT NULL,
    [SUB_ID] int  NOT NULL,
    [Prod_ID] int  NOT NULL,
    [HAND_GEB_Hand_ID] int  NOT NULL,
    [SUB_BEG_Sub_ID] int  NOT NULL,
    [PROD_Prod_ID] int  NOT NULL
);
GO

-- Creating table 'SUB_BEG'
CREATE TABLE [dbo].[SUB_BEG] (
    [Sub_ID] int IDENTITY(1,1) NOT NULL,
    [Sub_Name] nvarchar(max)  NOT NULL,
    [Sub_IMG] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'REVs'
CREATE TABLE [dbo].[REVs] (
    [Rev_Id] int IDENTITY(1,1) NOT NULL,
    [Prod_id] nvarchar(max)  NOT NULL,
    [User_ID] nvarchar(max)  NOT NULL,
    [Rev_text] nvarchar(max)  NOT NULL,
    [PROD_Prod_ID] int  NOT NULL,
    [USER_USER_Id] int  NOT NULL
);
GO

-- Creating table 'USERs'
CREATE TABLE [dbo].[USERs] (
    [USER_Id] int IDENTITY(1,1) NOT NULL,
    [USER_Name] nvarchar(max)  NOT NULL,
    [USER_PW] nvarchar(max)  NOT NULL,
    [USER_Sec] nvarchar(max)  NOT NULL,
    [User_Val_dat] datetime  NOT NULL
);
GO

-- Creating table 'CATs'
CREATE TABLE [dbo].[CATs] (
    [CAT_Id] int IDENTITY(1,1) NOT NULL,
    [CAT_Name] nvarchar(max)  NOT NULL,
    [CAT_IMG] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CAT_PROD'
CREATE TABLE [dbo].[CAT_PROD] (
    [CAT_Id] int  NOT NULL,
    [PROD_ID] int  NOT NULL,
    [CAT_CAT_Id] int  NOT NULL,
    [PROD_Prod_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Hand_ID] in table 'HAND_GEB'
ALTER TABLE [dbo].[HAND_GEB]
ADD CONSTRAINT [PK_HAND_GEB]
    PRIMARY KEY CLUSTERED ([Hand_ID] ASC);
GO

-- Creating primary key on [Prod_ID] in table 'PRODs'
ALTER TABLE [dbo].[PRODs]
ADD CONSTRAINT [PK_PRODs]
    PRIMARY KEY CLUSTERED ([Prod_ID] ASC);
GO

-- Creating primary key on [Hand_ID], [SUB_ID], [Prod_ID] in table 'HAND_SUB_GEB_PROD'
ALTER TABLE [dbo].[HAND_SUB_GEB_PROD]
ADD CONSTRAINT [PK_HAND_SUB_GEB_PROD]
    PRIMARY KEY CLUSTERED ([Hand_ID], [SUB_ID], [Prod_ID] ASC);
GO

-- Creating primary key on [Sub_ID] in table 'SUB_BEG'
ALTER TABLE [dbo].[SUB_BEG]
ADD CONSTRAINT [PK_SUB_BEG]
    PRIMARY KEY CLUSTERED ([Sub_ID] ASC);
GO

-- Creating primary key on [Rev_Id] in table 'REVs'
ALTER TABLE [dbo].[REVs]
ADD CONSTRAINT [PK_REVs]
    PRIMARY KEY CLUSTERED ([Rev_Id] ASC);
GO

-- Creating primary key on [USER_Id] in table 'USERs'
ALTER TABLE [dbo].[USERs]
ADD CONSTRAINT [PK_USERs]
    PRIMARY KEY CLUSTERED ([USER_Id] ASC);
GO

-- Creating primary key on [CAT_Id] in table 'CATs'
ALTER TABLE [dbo].[CATs]
ADD CONSTRAINT [PK_CATs]
    PRIMARY KEY CLUSTERED ([CAT_Id] ASC);
GO

-- Creating primary key on [CAT_Id], [PROD_ID] in table 'CAT_PROD'
ALTER TABLE [dbo].[CAT_PROD]
ADD CONSTRAINT [PK_CAT_PROD]
    PRIMARY KEY CLUSTERED ([CAT_Id], [PROD_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [HAND_GEB_Hand_ID] in table 'HAND_SUB_GEB_PROD'
ALTER TABLE [dbo].[HAND_SUB_GEB_PROD]
ADD CONSTRAINT [FK_HAND_GEBHAND_SUB_GEB_PROD]
    FOREIGN KEY ([HAND_GEB_Hand_ID])
    REFERENCES [dbo].[HAND_GEB]
        ([Hand_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HAND_GEBHAND_SUB_GEB_PROD'
CREATE INDEX [IX_FK_HAND_GEBHAND_SUB_GEB_PROD]
ON [dbo].[HAND_SUB_GEB_PROD]
    ([HAND_GEB_Hand_ID]);
GO

-- Creating foreign key on [SUB_BEG_Sub_ID] in table 'HAND_SUB_GEB_PROD'
ALTER TABLE [dbo].[HAND_SUB_GEB_PROD]
ADD CONSTRAINT [FK_SUB_BEGHAND_SUB_GEB_PROD]
    FOREIGN KEY ([SUB_BEG_Sub_ID])
    REFERENCES [dbo].[SUB_BEG]
        ([Sub_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SUB_BEGHAND_SUB_GEB_PROD'
CREATE INDEX [IX_FK_SUB_BEGHAND_SUB_GEB_PROD]
ON [dbo].[HAND_SUB_GEB_PROD]
    ([SUB_BEG_Sub_ID]);
GO

-- Creating foreign key on [PROD_Prod_ID] in table 'HAND_SUB_GEB_PROD'
ALTER TABLE [dbo].[HAND_SUB_GEB_PROD]
ADD CONSTRAINT [FK_PRODHAND_SUB_GEB_PROD]
    FOREIGN KEY ([PROD_Prod_ID])
    REFERENCES [dbo].[PRODs]
        ([Prod_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODHAND_SUB_GEB_PROD'
CREATE INDEX [IX_FK_PRODHAND_SUB_GEB_PROD]
ON [dbo].[HAND_SUB_GEB_PROD]
    ([PROD_Prod_ID]);
GO

-- Creating foreign key on [PROD_Prod_ID] in table 'REVs'
ALTER TABLE [dbo].[REVs]
ADD CONSTRAINT [FK_PRODREV]
    FOREIGN KEY ([PROD_Prod_ID])
    REFERENCES [dbo].[PRODs]
        ([Prod_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODREV'
CREATE INDEX [IX_FK_PRODREV]
ON [dbo].[REVs]
    ([PROD_Prod_ID]);
GO

-- Creating foreign key on [USER_USER_Id] in table 'REVs'
ALTER TABLE [dbo].[REVs]
ADD CONSTRAINT [FK_USERREV]
    FOREIGN KEY ([USER_USER_Id])
    REFERENCES [dbo].[USERs]
        ([USER_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USERREV'
CREATE INDEX [IX_FK_USERREV]
ON [dbo].[REVs]
    ([USER_USER_Id]);
GO

-- Creating foreign key on [CAT_CAT_Id] in table 'CAT_PROD'
ALTER TABLE [dbo].[CAT_PROD]
ADD CONSTRAINT [FK_CATEntity1]
    FOREIGN KEY ([CAT_CAT_Id])
    REFERENCES [dbo].[CATs]
        ([CAT_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CATEntity1'
CREATE INDEX [IX_FK_CATEntity1]
ON [dbo].[CAT_PROD]
    ([CAT_CAT_Id]);
GO

-- Creating foreign key on [PROD_Prod_ID] in table 'CAT_PROD'
ALTER TABLE [dbo].[CAT_PROD]
ADD CONSTRAINT [FK_PRODEntity1]
    FOREIGN KEY ([PROD_Prod_ID])
    REFERENCES [dbo].[PRODs]
        ([Prod_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODEntity1'
CREATE INDEX [IX_FK_PRODEntity1]
ON [dbo].[CAT_PROD]
    ([PROD_Prod_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------