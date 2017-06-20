
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/20/2017 10:56:01
-- Generated from EDMX file: C:\Users\woute\Source\Repos\d\CasusB2D3\TechnoBackend\TechnoBackend\DatabaseModel\DBModel.edmx
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
IF OBJECT_ID(N'[dbo].[FK_PRODHAND_SUB_GEB_PROD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HAND_SUB_GEB_PROD] DROP CONSTRAINT [FK_PRODHAND_SUB_GEB_PROD];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODREV]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REVs] DROP CONSTRAINT [FK_PRODREV];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODEntity1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CAT_PROD] DROP CONSTRAINT [FK_PRODEntity1];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODPRODTAGS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PRODTAGS] DROP CONSTRAINT [FK_PRODPRODTAGS];
GO
IF OBJECT_ID(N'[dbo].[FK_SUB_BEGHAND_SUB_GEB_PROD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HAND_SUB_GEB_PROD] DROP CONSTRAINT [FK_SUB_BEGHAND_SUB_GEB_PROD];
GO
IF OBJECT_ID(N'[dbo].[FK_USERREV]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REVs] DROP CONSTRAINT [FK_USERREV];
GO
IF OBJECT_ID(N'[dbo].[FK_USERSESSIONS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SESSIONS] DROP CONSTRAINT [FK_USERSESSIONS];
GO
IF OBJECT_ID(N'[dbo].[FK_CATEntity1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CAT_PROD] DROP CONSTRAINT [FK_CATEntity1];
GO
IF OBJECT_ID(N'[dbo].[FK_TAGSPRODTAGS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PRODTAGS] DROP CONSTRAINT [FK_TAGSPRODTAGS];
GO
IF OBJECT_ID(N'[dbo].[FK_NewsUSERs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NEWS] DROP CONSTRAINT [FK_NewsUSERs];
GO
IF OBJECT_ID(N'[dbo].[FK_EVENTUSERs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EVENTs] DROP CONSTRAINT [FK_EVENTUSERs];
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
IF OBJECT_ID(N'[dbo].[SUB_GEB]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SUB_GEB];
GO
IF OBJECT_ID(N'[dbo].[REVs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[REVs];
GO
IF OBJECT_ID(N'[dbo].[USERs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERs];
GO
IF OBJECT_ID(N'[dbo].[CATs1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CATs1];
GO
IF OBJECT_ID(N'[dbo].[CAT_PROD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CAT_PROD];
GO
IF OBJECT_ID(N'[dbo].[SESSIONS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SESSIONS];
GO
IF OBJECT_ID(N'[dbo].[TAGS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TAGS];
GO
IF OBJECT_ID(N'[dbo].[PRODTAGS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PRODTAGS];
GO
IF OBJECT_ID(N'[dbo].[NEWS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NEWS];
GO
IF OBJECT_ID(N'[dbo].[EVENTs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EVENTs];
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
    [Prod_Val_Dat] datetime  NOT NULL
);
GO

-- Creating table 'HAND_SUB_GEB_PROD'
CREATE TABLE [dbo].[HAND_SUB_GEB_PROD] (
    [Couple_ID] int IDENTITY(1,1) NOT NULL,
    [HAND_GEB_Hand_ID] int  NOT NULL,
    [PROD_Prod_ID] int  NOT NULL,
    [SUB_GEB_Sub_ID] int  NOT NULL
);
GO

-- Creating table 'SUB_GEB'
CREATE TABLE [dbo].[SUB_GEB] (
    [Sub_ID] int IDENTITY(1,1) NOT NULL,
    [Sub_Name] nvarchar(max)  NOT NULL,
    [Sub_IMG] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'REVs'
CREATE TABLE [dbo].[REVs] (
    [REV_ID] int IDENTITY(1,1) NOT NULL,
    [PROD_ID] nvarchar(max)  NOT NULL,
    [USER_ID] nvarchar(max)  NOT NULL,
    [REV_text] nvarchar(max)  NOT NULL,
    [PROD_Prod_ID] int  NOT NULL,
    [USER_USER_Id] int  NOT NULL
);
GO

-- Creating table 'USERs'
CREATE TABLE [dbo].[USERs] (
    [USER_Id] int IDENTITY(1,1) NOT NULL,
    [USER_Name] nvarchar(max)  NOT NULL,
    [USER_PW] nvarchar(max)  NOT NULL,
    [USER_Sec] int  NOT NULL,
    [USER_Val_dat] datetime  NOT NULL
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
    [COUPLE_ID] int IDENTITY(1,1) NOT NULL,
    [PROD_Prod_ID] int  NOT NULL,
    [CAT_CAT_Id] int  NOT NULL
);
GO

-- Creating table 'SESSIONS'
CREATE TABLE [dbo].[SESSIONS] (
    [SESSIONS_ID] int IDENTITY(1,1) NOT NULL,
    [SESSIONS_Token] nvarchar(max)  NOT NULL,
    [SESSIONS_TTL] datetime  NOT NULL,
    [USER_Id_USER_Id] int  NOT NULL
);
GO

-- Creating table 'TAGS'
CREATE TABLE [dbo].[TAGS] (
    [TAGS_Id] int IDENTITY(1,1) NOT NULL,
    [TAGS_Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PRODTAGS'
CREATE TABLE [dbo].[PRODTAGS] (
    [PROD_Id] int  NOT NULL,
    [TAGS_id] nvarchar(max)  NOT NULL,
    [PROD_Prod_ID] int  NOT NULL,
    [TAG_TAGS_Id] int  NOT NULL
);
GO

-- Creating table 'NEWS'
CREATE TABLE [dbo].[NEWS] (
    [News_Id] int IDENTITY(1,1) NOT NULL,
    [News_Title] nvarchar(max)  NOT NULL,
    [News_Body] nvarchar(max)  NOT NULL,
    [News_IMG] nvarchar(max)  NOT NULL,
    [News_Link] nvarchar(max)  NOT NULL,
    [USERs_USER_Id] int  NOT NULL
);
GO

-- Creating table 'EVENTs'
CREATE TABLE [dbo].[EVENTs] (
    [Event_Id] int IDENTITY(1,1) NOT NULL,
    [Event_Name] nvarchar(max)  NOT NULL,
    [Event_Body] nvarchar(max)  NOT NULL,
    [Event_Address] nvarchar(max)  NOT NULL,
    [Event_Link] nvarchar(max)  NOT NULL,
    [USERs_USER_Id] int  NOT NULL
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

-- Creating primary key on [Couple_ID] in table 'HAND_SUB_GEB_PROD'
ALTER TABLE [dbo].[HAND_SUB_GEB_PROD]
ADD CONSTRAINT [PK_HAND_SUB_GEB_PROD]
    PRIMARY KEY CLUSTERED ([Couple_ID] ASC);
GO

-- Creating primary key on [Sub_ID] in table 'SUB_GEB'
ALTER TABLE [dbo].[SUB_GEB]
ADD CONSTRAINT [PK_SUB_GEB]
    PRIMARY KEY CLUSTERED ([Sub_ID] ASC);
GO

-- Creating primary key on [REV_ID] in table 'REVs'
ALTER TABLE [dbo].[REVs]
ADD CONSTRAINT [PK_REVs]
    PRIMARY KEY CLUSTERED ([REV_ID] ASC);
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

-- Creating primary key on [COUPLE_ID] in table 'CAT_PROD'
ALTER TABLE [dbo].[CAT_PROD]
ADD CONSTRAINT [PK_CAT_PROD]
    PRIMARY KEY CLUSTERED ([COUPLE_ID] ASC);
GO

-- Creating primary key on [SESSIONS_ID] in table 'SESSIONS'
ALTER TABLE [dbo].[SESSIONS]
ADD CONSTRAINT [PK_SESSIONS]
    PRIMARY KEY CLUSTERED ([SESSIONS_ID] ASC);
GO

-- Creating primary key on [TAGS_Id] in table 'TAGS'
ALTER TABLE [dbo].[TAGS]
ADD CONSTRAINT [PK_TAGS]
    PRIMARY KEY CLUSTERED ([TAGS_Id] ASC);
GO

-- Creating primary key on [PROD_Id] in table 'PRODTAGS'
ALTER TABLE [dbo].[PRODTAGS]
ADD CONSTRAINT [PK_PRODTAGS]
    PRIMARY KEY CLUSTERED ([PROD_Id] ASC);
GO

-- Creating primary key on [News_Id] in table 'NEWS'
ALTER TABLE [dbo].[NEWS]
ADD CONSTRAINT [PK_NEWS]
    PRIMARY KEY CLUSTERED ([News_Id] ASC);
GO

-- Creating primary key on [Event_Id] in table 'EVENTs'
ALTER TABLE [dbo].[EVENTs]
ADD CONSTRAINT [PK_EVENTs]
    PRIMARY KEY CLUSTERED ([Event_Id] ASC);
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

-- Creating foreign key on [PROD_Prod_ID] in table 'PRODTAGS'
ALTER TABLE [dbo].[PRODTAGS]
ADD CONSTRAINT [FK_PRODPRODTAGS]
    FOREIGN KEY ([PROD_Prod_ID])
    REFERENCES [dbo].[PRODs]
        ([Prod_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODPRODTAGS'
CREATE INDEX [IX_FK_PRODPRODTAGS]
ON [dbo].[PRODTAGS]
    ([PROD_Prod_ID]);
GO

-- Creating foreign key on [SUB_GEB_Sub_ID] in table 'HAND_SUB_GEB_PROD'
ALTER TABLE [dbo].[HAND_SUB_GEB_PROD]
ADD CONSTRAINT [FK_SUB_BEGHAND_SUB_GEB_PROD]
    FOREIGN KEY ([SUB_GEB_Sub_ID])
    REFERENCES [dbo].[SUB_GEB]
        ([Sub_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SUB_BEGHAND_SUB_GEB_PROD'
CREATE INDEX [IX_FK_SUB_BEGHAND_SUB_GEB_PROD]
ON [dbo].[HAND_SUB_GEB_PROD]
    ([SUB_GEB_Sub_ID]);
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

-- Creating foreign key on [USER_Id_USER_Id] in table 'SESSIONS'
ALTER TABLE [dbo].[SESSIONS]
ADD CONSTRAINT [FK_USERSESSIONS]
    FOREIGN KEY ([USER_Id_USER_Id])
    REFERENCES [dbo].[USERs]
        ([USER_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USERSESSIONS'
CREATE INDEX [IX_FK_USERSESSIONS]
ON [dbo].[SESSIONS]
    ([USER_Id_USER_Id]);
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

-- Creating foreign key on [TAG_TAGS_Id] in table 'PRODTAGS'
ALTER TABLE [dbo].[PRODTAGS]
ADD CONSTRAINT [FK_TAGSPRODTAGS]
    FOREIGN KEY ([TAG_TAGS_Id])
    REFERENCES [dbo].[TAGS]
        ([TAGS_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TAGSPRODTAGS'
CREATE INDEX [IX_FK_TAGSPRODTAGS]
ON [dbo].[PRODTAGS]
    ([TAG_TAGS_Id]);
GO

-- Creating foreign key on [USERs_USER_Id] in table 'NEWS'
ALTER TABLE [dbo].[NEWS]
ADD CONSTRAINT [FK_NewsUSERs]
    FOREIGN KEY ([USERs_USER_Id])
    REFERENCES [dbo].[USERs]
        ([USER_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NewsUSERs'
CREATE INDEX [IX_FK_NewsUSERs]
ON [dbo].[NEWS]
    ([USERs_USER_Id]);
GO

-- Creating foreign key on [USERs_USER_Id] in table 'EVENTs'
ALTER TABLE [dbo].[EVENTs]
ADD CONSTRAINT [FK_EVENTUSERs]
    FOREIGN KEY ([USERs_USER_Id])
    REFERENCES [dbo].[USERs]
        ([USER_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EVENTUSERs'
CREATE INDEX [IX_FK_EVENTUSERs]
ON [dbo].[EVENTs]
    ([USERs_USER_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------