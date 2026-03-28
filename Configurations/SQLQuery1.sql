USE Master; 
GO 

CREATE DATABASE MyWebAppDB; 
GO 

USE MyWebAppDB; 
GO 

CREATE TABLE Cliente ( 
	Id INT PRIMARY KEY IDENTITY(1,1), 
	Nome NVARCHAR(100), 
	Email NVARCHAR(100) 
); 
GO 

SELECT * FROM Cliente; 
GO  
       
INSERT INTO Cliente 
	(Nome, Email)  
VALUES 
	('João Silva', 'joao.silva@email.com'), 
	('Maria Oliveira', 'maria.oliveira@email.com'), 
	('Carlos Souza', 'carlos.souza@email.com');
GO  
    
SELECT * FROM Cliente;   
GO  
    
ALTER TABLE Cliente 
ALTER COLUMN Nome NVARCHAR(100) NOT NULL; 
GO  
     
ALTER TABLE Cliente 
ALTER COLUMN Email NVARCHAR(100) NOT NULL; 
GO  
    
SELECT * FROM Cliente;  
GO  
    
