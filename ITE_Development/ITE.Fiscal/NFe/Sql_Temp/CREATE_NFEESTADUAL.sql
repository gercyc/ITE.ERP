CREATE TABLE dbo.NfeEstadual (
  IdNfe INT IDENTITY
 ,IdMovimento INT NOT NULL
 ,ChaveAcesso VARCHAR(44)
 ,XmlNfe VARCHAR(MAX)
 ,StatusXml INT

  CONSTRAINT PK_NfeEstadual_ID PRIMARY KEY (IdNfe)
 ,CONSTRAINT FK_Movimento FOREIGN KEY (IdMovimento) REFERENCES Movimento (IdMovimento)
)
GO