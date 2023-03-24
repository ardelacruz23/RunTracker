CREATE TABLE [dbo].[Admin] (
    [AdminId]      INT           NOT NULL,
    [Email]        VARCHAR (50)  NOT NULL,
    [FirstName]    VARCHAR (50)  NOT NULL,
    [LastName]     VARCHAR (50)  NOT NULL,
    [AvatarURL]    VARCHAR (200) NOT NULL,
    [Salt]         VARCHAR (50)  NOT NULL,
    [PasswordHash] VARCHAR (300) NOT NULL,
    [LastLogin]    ROWVERSION    NOT NULL
);

