/* CREAZIONE TABELLA CARRELLO */
CREATE TABLE [dbo].[Carrello] (
    [IdProdotto]          INT             NOT NULL,
    [IdCategoriaProdotto] INT             NOT NULL,
    [Prezzo]              DECIMAL (10, 2) NOT NULL,
    [Quantita]            INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([IdProdotto] ASC),
    FOREIGN KEY ([IdProdotto]) REFERENCES [dbo].[Prodotti] ([Id]),
    FOREIGN KEY ([IdCategoriaProdotto]) REFERENCES [dbo].[Categorie] ([Id])
);

/* CREAZIONE TABELLA CLIENTI */
CREATE TABLE [dbo].[Clienti] (
    [Id]       INT            NOT NULL,
    [Nome]     NVARCHAR (50)  NULL,
    [Cognome]  NVARCHAR (50)  NULL,
    [Email]    NVARCHAR (100) NULL,
    [Validita] CHAR (1)       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

/* CREAZIONE TABELLA CATEGORIE */
CREATE TABLE [dbo].[Categorie] (
    [Id]          INT            NOT NULL,
    [Descrizione] NVARCHAR (255) NULL,
    [Validita]    CHAR (1)       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

/* CREAZIONE TABELLA PRODOTTI */
CREATE TABLE [dbo].[Prodotti] (
    [Id]                  INT             NOT NULL,
    [IdCategoria]         INT             NULL,
    [DescrizioneProdotto] NVARCHAR (50)   NOT NULL,
    [Quantita]            INT             NULL,
    [Prezzo]              DECIMAL (10, 2) NOT NULL,
    [Immagine]            NVARCHAR (255)  NOT NULL,
    [Validita]            CHAR (1)        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_IdCategoria] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[Categorie] ([Id])
);

/* CREAZIONE TABELLA TESTATA VENDITE */
CREATE TABLE [dbo].[TestataVendite] (
    [NumeroFattura] INT            NOT NULL,
    [ClienteID]     INT            NOT NULL,
    [Data]          DATETIME       NOT NULL,
    [Indirizzo]     NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([NumeroFattura] ASC),
    FOREIGN KEY ([ClienteID]) REFERENCES [dbo].[Clienti] ([Id])
);

/* CREAZIONE TABELLA DETTAGLIO VENDITE */
CREATE TABLE [dbo].[DettaglioVendite] (
    [IdDettaglioVendita] INT NOT NULL,
    [NumeroFattura]      INT NOT NULL,
    [IdProdotto]         INT NOT NULL,
    [QuantitaVenduta]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdDettaglioVendita] ASC),
    FOREIGN KEY ([IdProdotto]) REFERENCES [dbo].[Prodotti] ([Id]),
    FOREIGN KEY ([NumeroFattura]) REFERENCES [dbo].[TestataVendite] ([NumeroFattura])
);
