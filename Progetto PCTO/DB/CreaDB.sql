/* CREAZIONE TABELLA CLIENTI */
CREATE TABLE [dbo].[Clienti] (
    [Id]      INT           NOT NULL,
    [Nome]    VARCHAR (50)  NULL,
    [Cognome] VARCHAR (50)  NULL,
    [Email]   VARCHAR (100) NULL,
	[Validita] CHAR          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

/* CREAZIONE TABELLA CATEGORIE */
CREATE TABLE [dbo].[Categorie] (
    [Id]          INT   NOT NULL,
    [Descrizione] NVARCHAR (255) NULL,
    [Validita]    NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

/* CREAZIONE TABELLA PRODOTTI */
CREATE TABLE [dbo].[Prodotti] (
    [Id] INT NOT NULL,
    [DescrizioneProdotto] NVARCHAR (50) NOT NULL,
    [Prezzo]   DECIMAL (10, 2) NOT NULL,
    [Immagine] NVARCHAR (255)  NOT NULL,
    [Validita] CHAR (1)        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

/* CREAZIONE TABELLA TESTATA VENDITE */
CREATE TABLE [dbo].[TestataVendite]
(
	[NumeroFattura] INT NOT NULL,
	[Data] DATETIME NOT NULL,
	[ClienteID] INT NOT NULL,
	[Totale] DECIMAL(18, 2) NOT NULL,
	[ModalitaPagamento] NVARCHAR(50) NOT NULL,
	PRIMARY KEY CLUSTERED ([NumeroFattura] ASC),
	FOREIGN KEY (ClienteID) REFERENCES [Clienti] ([Id]),
);

/* CREAZIONE TABELLA DETTAGLIO VENDITE */
CREATE TABLE [dbo].[DettaglioVendite]
(
	[NumeroFattura] INT NOT NULL,
	[IdProdotto] INT NOT NULL,
	[DescrizioneProdotto] NVARCHAR(50) NOT NULL,
	[QuantitaVenduta] INT NOT NULL,
	[PrezzoUnitario] DECIMAL(18, 2) NOT NULL,
	PRIMARY KEY CLUSTERED ([NumeroFattura], [IdProdotto]),
	FOREIGN KEY (IdProdotto) REFERENCES [Prodotti] ([Id]),
	FOREIGN KEY (NumeroFattura) REFERENCES [TestataVendite] ([NumeroFattura])
);