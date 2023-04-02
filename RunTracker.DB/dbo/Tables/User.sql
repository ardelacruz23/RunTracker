CREATE TABLE [dbo].[User] (
    [UserID]       INT           IDENTITY (1, 1) NOT NULL,
    [Email]        VARCHAR (50)  NOT NULL,
    [FirstName]    VARCHAR (50)  NOT NULL,
    [LastLogin]    ROWVERSION    NULL,
    [AvatarURL]    VARCHAR (200) NULL,
    [Salt]         VARCHAR (25)  NULL,
    [PasswordHash] VARCHAR (300) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserID] ASC)
);







