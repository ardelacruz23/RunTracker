﻿CREATE TABLE [dbo].[Run] (
    [RunId]        INT            NOT NULL,
    [UserID]       INT            NOT NULL,
    [RunName]      VARCHAR (50)   NOT NULL,
    [DateID]       DATE           NOT NULL,
    [StartTime]    DATETIME       NOT NULL,
    [EndTime]      DATETIME       NOT NULL,
    [Distance]     DECIMAL (3, 1) NOT NULL,
    [Pace]         TIME (6)       NOT NULL,
    [PhotoURL]     VARCHAR (150)  NULL,
    [LocationName] VARCHAR (50)   NULL,
    [City]         VARCHAR (50)   NULL,
    [State]        VARCHAR (50)   NULL,
    [Country]      VARCHAR (50)   NULL,
    CONSTRAINT [PK_Run] PRIMARY KEY CLUSTERED ([RunId] ASC)
);

