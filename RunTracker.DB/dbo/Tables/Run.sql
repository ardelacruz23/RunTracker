CREATE TABLE [dbo].[Run] (
    [RunID]        INT            IDENTITY (1, 1) NOT NULL,
    [UserID]       INT            NOT NULL,
    [RunName]      VARCHAR (50)   NOT NULL,
    [RunDate]      VARCHAR (50)   NOT NULL,
    [StartTime]    TIME (0)       NOT NULL,
    [EndTime]      TIME (0)       NOT NULL,
    [Distance]     DECIMAL (3, 1) NOT NULL,
    [Duration]     TIME (0)       NULL,
    [Pace]         TIME (0)       NULL,
    [PhotoURL]     VARCHAR (150)  NULL,
    [LocationName] VARCHAR (50)   NULL,
    [City]         VARCHAR (50)   NULL,
    [State]        VARCHAR (50)   NULL,
    [Country]      VARCHAR (50)   NULL,
    CONSTRAINT [PK_Run] PRIMARY KEY CLUSTERED ([RunID] ASC)
);









