INSERT INTO dbo.Users (Username, Roles, FirstName, LastName, Mail, Addres, Phone)
VALUES
('cieran.villegas', 0 , 'Cieran', 'Villegas', 'cieran.villegas@gmail.com', 'Pertholzer Strasse 19', '0744565975'),
('dewey.stacey', 0 , 'Dewey', 'Stacey', 'dewey.stacey@gmail.com', 'Hainbuchen 69', '0744565976'),
('imaani.hawkins', 0 , 'Imaani', 'Hawkins', 'imaani.hawkins@gmail.com', 'Staudgasse 59', '0744565977'),
('alyssa.salazar', 0 , 'Alyssa ', 'Salazar', 'alyssa.salazar@gmail.com', 'Ziegelgasse 31', '0744565978'),
('danyl.kavanagh', 0 , 'Danyl ', 'Kavanagh', 'danyl.kavanagh@gmail.com', 'Linzer Strasse 95', '0744565979'),
('duane.glenn', 0 , 'Duane', 'Glenn', 'duane.glenn@gmail.com', 'Horner Strasse 46', '0744565980'),
('willa.cresswell', 0 , 'Willa', 'Cresswell', 'willa.cresswell@gmail.com', 'Bahngasse 20', '0744565981'),
('anais.hoffman', 0 , 'Anais ', 'Hoffman', 'anais.hoffman@gmail.com', 'Steinfelden 17', '0744565982'),
('mohammod.atkins', 0 , 'Mohammod', 'Atkins', 'mohammod.atkins@gmail.com', 'Horner Untere Hauptstrasse 89', '0744565983'),
('ivy.lucas', 0 , 'Ivy', 'Lucas', 'ivy.lucas@gmail.com', 'Marktplatz 68', '0744565984')


INSERT INTO dbo.Products (ProductName, Description, Price, Quantity, Tags)
VALUES
('Colonists of Catan', NULL, 45, 30, 'Strategy, Dice, Family'),
('Root', NULL, 60, 15, 'Strategy, Dice, Cards, Figures'),
('Uno', NULL, 15, 30, 'Cards, Family'),
('Cluedo', NULL, 35, 10, 'Logic, Mistery, Family'),
('Zestrea', NULL, 25, 10, 'Cards, Popular, Family'),
('Secret Hitler', NULL, 45, 5, 'Role-playing, Group, Talkative'),
('Ligreto', NULL, 15, 10, 'Speed, Cards, Family'),
('Citadele', NULL, 25, 10, 'Strategy, Cards, Family'),
('Dixit', NULL, 25, 15, 'Fun, Cards, Family'),
('Exploding Kittens', NULL, 15, 20, 'Cards, Family')


INSERT INTO dbo.Orders (States, Price, ShippingAdress, UserId)
VALUES
(0, 120, 'Pertholzer Strasse 19', NULL),
(0, 150, 'Hainbuchen 69', NULL),
(0, 200, 'Staudgasse 59', NULL),
(0, 300, 'Horner Untere Hauptstrasse 89', NULL),
(0, 75, 'Horner Strasse 46', NULL),
(0, 125, 'Staudgasse 59', NULL),
(0, 160, 'Pertholzer Strasse 19', NULL),
(0, 155, 'Steinfelden 17', NULL),
(0, 265, 'Horner Untere Hauptstrasse 89', NULL),
(0, 270, 'Ziegelgasse 31', NULL)


INSERT INTO dbo.OrderItems(ProductId, Quantity, OrderId)
VALUES
(1, 2, 2),
(3, 1, 1),
(3, 1, 2),
(5, 1, 2),
(2, 2, 4),
(5, 1, 4),
(3, 3, 7),
(1, 3, 3),
(6, 1, 1),
(7, 1, 1)