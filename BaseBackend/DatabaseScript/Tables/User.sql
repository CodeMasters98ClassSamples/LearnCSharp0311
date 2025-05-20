CREATE TABLE [dbo].[User] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [NationalCode]    NVARCHAR (150) NULL,
    [FirstName]       NVARCHAR (150) NULL,
    [LastName]        NVARCHAR (150) NULL,
    [PhoneNumber]     NVARCHAR (11)  NULL,
    [LastDocument]    NVARCHAR (250) NULL,
    [Gender]          SMALLINT       DEFAULT ((0)) NULL,
    [CreatedAt]       DATETIME       DEFAULT (getdate()) NULL,
    [CreatedByUserId] INT            NULL,
    [IsDeleted]       BIT            NULL,
    [DeletedAt]       DATETIME       NULL,
    [DeletedByUserId] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

