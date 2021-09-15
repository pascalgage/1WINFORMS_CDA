DROP TABLE IF EXISTS
clients
GO


CREATE TABLE clients
(
	client_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	client_nom VARCHAR(30) NOT NULL,
	client_date DATE NOT NULL,
	client_montant VARCHAR(50) NOT NULL,
	client_codePostal VARCHAR(50) NOT NULL
)