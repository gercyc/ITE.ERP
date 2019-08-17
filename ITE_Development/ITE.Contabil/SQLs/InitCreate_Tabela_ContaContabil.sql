CREATE TABLE tbContaContabil (
  IdContaContabil INT IDENTITY,
  IdMatriz INT NOT NULL,
  CodigoContaContabil VARCHAR(8000) NOT NULL,
  CodigoReduzido VARCHAR(8000) NULL,
  DescricaoContaContabil VARCHAR(200) NOT NULL,
  IndAnaliticaSintetica INT NOT NULL,
  TipoContaSped INT NULL,
  Natureza INT NOT NULL,
  Nivel INT NOT NULL,
  DataInclusao DATETIME NOT NULL,
  DataAlteracao DATETIME NULL,
  CONSTRAINT [PK_dbo.tbContaContabil] PRIMARY KEY CLUSTERED (IdContaContabil),
  CONSTRAINT FK_tbContaContabil_tbEmpresaMatriz_IdEmpresaMatriz FOREIGN KEY (IdMatriz) REFERENCES dbo.tbEmpresaMatriz (IdEmpresaMatriz)
) ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CODCT_RED
ON tbContaContabil (CodigoReduzido)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CODCT_RED_2
ON tbContaContabil (CodigoReduzido)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_UNIQUE_CCT
ON tbContaContabil (IdMatriz, CodigoContaContabil)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_UNIQUE_CCT_2
ON tbContaContabil (IdMatriz, CodigoContaContabil)
ON [PRIMARY]
GO