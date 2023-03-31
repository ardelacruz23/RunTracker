CREATE TABLE [dbo].[User] (
    [UserID]       INT           NOT NULL,
    [Email]        VARCHAR (50)  NOT NULL,
    [FirstName]    VARCHAR (50)  NOT NULL,
    [LastName]     VARCHAR (50)  NOT NULL,
    [LastLogin]    ROWVERSION    NULL,
    [AvatarURL]    VARCHAR (200) NULL,
    [Salt]         VARCHAR (25)  NOT NULL,
    [PasswordHash] VARCHAR (300) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserID] ASC)
);

