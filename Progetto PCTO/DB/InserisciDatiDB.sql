DELETE FROM [dbo].[Categorie]  
DELETE FROM [dbo].[Clienti]  
DELETE FROM [dbo].[Prodotti]  

GO  

INSERT INTO [dbo].[Categorie]  
VALUES  
(1, 'Sparatutto', ' '),  
(2, 'Avventura', ' '),  
(3, 'GDR', ' '),  
(4, 'RPG', ' '),  
(5, 'Simulazione', ' '),  
(6, 'Sport', ' '),  
(7, 'Puzzle', ' '),  
(8, 'Strategia', ' '),  
(9, 'Azione', ' ')  

GO  

INSERT INTO [dbo].[Clienti]  
VALUES  
(1, 'PIPPO', 'ROSSI', 'pippo.rossi@gmail.com', ' '),  
(2, 'PLUTO', 'VERDI', 'pluto.verdi@gmail.com', ' '),  
(3, 'PAPERINO', 'BIANCHI', 'paperino.bianchi@gmail.com', ' '),  
(4, 'TOPOLINO', 'NERI', 'topolino.neri@gmail.com', ' '),  
(5, 'MINNIE', 'ROSSI', 'minnie.rossi@gmail.com', ' '),  
(6, 'PAPERINA', 'VERDI', 'paperina.verdi@gmail.com', ' '),  
(7, 'PIPPA', 'BIANCHI', 'pippa.bianchi@gmail.com', ' '),  
(8, 'PLUTINA', 'NERI', 'plutina.neri@gmail.com', ' '),  
(9, 'TOPOLINA', 'ROSSI', 'topolina.rossi@gmail.com', ' '),  
(10, 'MINNINA', 'VERDI', 'minnina.verdi@gmail.com', ' '),  
(11, 'PAPERETTA', 'BIANCHI', 'paperetta.bianchi@gmail.com', ' '),  
(12, 'PAPEROTTO', 'NERI', 'paperotto.neri@gmail.com', ' ')  

GO  

INSERT INTO [dbo].[Prodotti]  
VALUES  
(1, 'Call of Duty Black Ops 6', '79.99', 'https://m.media-amazon.com/images/I/81TKxDas9TL._AC_UF894,1000_QL80_.jpg', ' '),
(2, 'FIFA 23', '69.99', 'https://m.media-amazon.com/images/I/81VRidE3hdL._AC_UF894,1000_QL80_.jpg', ' '),  
(3, 'The Last of Us Part II', '59.99', 'https://m.media-amazon.com/images/I/81EWJFQdvpL.jpg', ' '),  
(4, 'God of War Ragnarök', '69.99', 'https://m.media-amazon.com/images/I/81CGXiu94cL.jpg', ' '),  
(5, 'Assassin''s Creed Valhalla', '49.99', 'https://m.media-amazon.com/images/I/81xm0C9FFVL._AC_UF894,1000_QL80_.jpg', ' '),  
(6, 'Cyberpunk 2077', '39.99', 'https://m.media-amazon.com/images/I/81YptknEr3L.jpg', ' '),
(7, 'The Witcher 3: Wild Hunt', '29.99', 'https://m.media-amazon.com/images/I/81OzY7w8EaL._AC_UF1000,1000_QL80_.jpg', ' '),  
(8, 'Minecraft', '19.99', 'https://m.media-amazon.com/images/I/810ZqvwzdGL._AC_UF894,1000_QL80_.jpg', ' '),  
(9, 'The Legend of Zelda: Breath of the Wild', '59.99', 'https://m.media-amazon.com/images/I/81lsqTe-YiL.jpg', ' '),  
(10, 'Super Mario Odyssey', '49.99', 'https://m.media-amazon.com/images/I/91-VfRp-i0L._AC_UF894,1000_QL80_.jpg', ' ')

GO