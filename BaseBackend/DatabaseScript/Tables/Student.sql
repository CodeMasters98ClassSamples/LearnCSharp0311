CREATE TABLE [dbo].[Student] (
    [Id]         INT            NOT NULL,
    [UserId]     INT            NOT NULL,
    [Referer]    NVARCHAR (100) NULL,
    [University] NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

