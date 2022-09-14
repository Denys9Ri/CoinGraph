CREATE TABLE [dbo].[Coins] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL DEFAULT 0,
    [CoinName] TEXT NOT NULL ,
    [Price]    INT            NOT NULL,
    CONSTRAINT [PK_Coins] PRIMARY KEY CLUSTERED ([Id] ASC)
);

