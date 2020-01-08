using System;
using System.Collections.Generic;
using System.Text;

namespace dataSample
{
    public class Sql
    {
        public static string Insert = @"
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(1, N'Maria', N'Anders', N'Berlin', N'Germany', N'030-0074321')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(2, N'Ana', N'Trujillo', N'México D.F.', N'Mexico', N'(5) 555-4729')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(3, N'Antonio', N'Moreno', N'México D.F.', N'Mexico', N'(5) 555-3932')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(4, N'Thomas', N'Hardy', N'London', N'UK', N'(171) 555-7788')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(5, N'Christina', N'Berglund', N'Luleå', N'Sweden', N'0921-12 34 65')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(6, N'Hanna', N'Moos', N'Mannheim', N'Germany', N'0621-08460')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(7, N'Frédérique', N'Citeaux', N'Strasbourg', N'France', N'88.60.15.31')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(8, N'Martín', N'Sommer', N'Madrid', N'Spain', N'(91) 555 22 82')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(9, N'Laurence', N'Lebihan', N'Marseille', N'France', N'91.24.45.40')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(10, N'Elizabeth', N'Lincoln', N'Tsawassen', N'Canada', N'(604) 555-4729')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(11, N'Victoria', N'Ashworth', N'London', N'UK', N'(171) 555-1212')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(12, N'Patricio', N'Simpson', N'Buenos Aires', N'Argentina', N'(1) 135-5555')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(13, N'Francisco', N'Chang', N'México D.F.', N'Mexico', N'(5) 555-3392')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(14, N'Yang', N'Wang', N'Bern', N'Switzerland', N'0452-076545')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(15, N'Pedro', N'Afonso', N'Sao Paulo', N'Brazil', N'(11) 555-7647')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(16, N'Elizabeth', N'Brown', N'London', N'UK', N'(171) 555-2282')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(17, N'Sven', N'Ottlieb', N'Aachen', N'Germany', N'0241-039123')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(18, N'Janine', N'Labrune', N'Nantes', N'France', N'40.67.88.88')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(19, N'Ann', N'Devon', N'London', N'UK', N'(171) 555-0297')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(20, N'Roland', N'Mendel', N'Graz', N'Austria', N'7675-3425')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(21, N'Aria', N'Cruz', N'Sao Paulo', N'Brazil', N'(11) 555-9857')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(22, N'Diego', N'Roel', N'Madrid', N'Spain', N'(91) 555 94 44')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(23, N'Martine', N'Rancé', N'Lille', N'France', N'20.16.10.16')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(24, N'Maria', N'Larsson', N'Bräcke', N'Sweden', N'0695-34 67 21')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(25, N'Peter', N'Franken', N'München', N'Germany', N'089-0877310')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(26, N'Carine', N'Schmitt', N'Nantes', N'France', N'40.32.21.21')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(27, N'Paolo', N'Accorti', N'Torino', N'Italy', N'011-4988260')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(28, N'Lino', N'Rodriguez', N'Lisboa', N'Portugal', N'(1) 354-2534')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(29, N'Eduardo', N'Saavedra', N'Barcelona', N'Spain', N'(93) 203 4560')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(30, N'José', N'Pedro Freyre', N'Sevilla', N'Spain', N'(95) 555 82 82')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(31, N'André', N'Fonseca', N'Campinas', N'Brazil', N'(11) 555-9482')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(32, N'Howard', N'Snyder', N'Eugene', N'USA', N'(503) 555-7555')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(33, N'Manuel', N'Pereira', N'Caracas', N'Venezuela', N'(2) 283-2951')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(34, N'Mario', N'Pontes', N'Rio de Janeiro', N'Brazil', N'(21) 555-0091')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(35, N'Carlos', N'Hernández', N'San Cristóbal', N'Venezuela', N'(5) 555-1340')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(36, N'Yoshi', N'Latimer', N'Elgin', N'USA', N'(503) 555-6874')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(37, N'Patricia', N'McKenna', N'Cork', N'Ireland', N'2967 542')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(38, N'Helen', N'Bennett', N'Cowes', N'UK', N'(198) 555-8888')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(39, N'Philip', N'Cramer', N'Brandenburg', N'Germany', N'0555-09876')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(40, N'Daniel', N'Tonini', N'Versailles', N'France', N'30.59.84.10')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(41, N'Annette', N'Roulet', N'Toulouse', N'France', N'61.77.61.10')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(42, N'Yoshi', N'Tannamuri', N'Vancouver', N'Canada', N'(604) 555-3392')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(43, N'John', N'Steel', N'Walla Walla', N'USA', N'(509) 555-7969')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(44, N'Renate', N'Messner', N'Frankfurt a.M.', N'Germany', N'069-0245984')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(45, N'Jaime', N'Yorres', N'San Francisco', N'USA', N'(415) 555-5938')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(46, N'Carlos', N'González', N'Barquisimeto', N'Venezuela', N'(9) 331-6954')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(47, N'Felipe', N'Izquierdo', N'I. de Margarita', N'Venezuela', N'(8) 34-56-12')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(48, N'Fran', N'Wilson', N'Portland', N'USA', N'(503) 555-9573')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(49, N'Giovanni', N'Rovelli', N'Bergamo', N'Italy', N'035-640230')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(50, N'Catherine', N'Dewey', N'Bruxelles', N'Belgium', N'(02) 201 24 67')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(51, N'Jean', N'Fresnière', N'Montréal', N'Canada', N'(514) 555-8054')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(52, N'Alexander', N'Feuer', N'Leipzig', N'Germany', N'0342-023176')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(53, N'Simon', N'Crowther', N'London', N'UK', N'(171) 555-7733')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(54, N'Yvonne', N'Moncada', N'Buenos Aires', N'Argentina', N'(1) 135-5333')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(55, N'Rene', N'Phillips', N'Anchorage', N'USA', N'(907) 555-7584')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(56, N'Henriette', N'Pfalzheim', N'Köln', N'Germany', N'0221-0644327')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(57, N'Marie', N'Bertrand', N'Paris', N'France', N'(1) 42.34.22.66')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(58, N'Guillermo', N'Fernández', N'México D.F.', N'Mexico', N'(5) 552-3745')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(59, N'Georg', N'Pipps', N'Salzburg', N'Austria', N'6562-9722')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(60, N'Isabel', N'de Castro', N'Lisboa', N'Portugal', N'(1) 356-5634')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(61, N'Bernardo', N'Batista', N'Rio de Janeiro', N'Brazil', N'(21) 555-4252')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(62, N'Lúcia', N'Carvalho', N'Sao Paulo', N'Brazil', N'(11) 555-1189')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(63, N'Horst', N'Kloss', N'Cunewalde', N'Germany', N'0372-035188')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(64, N'Sergio', N'Gutiérrez', N'Buenos Aires', N'Argentina', N'(1) 123-5555')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(65, N'Paula', N'Wilson', N'Albuquerque', N'USA', N'(505) 555-5939')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(66, N'Maurizio', N'Moroni', N'Reggio Emilia', N'Italy', N'0522-556721')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(67, N'Janete', N'Limeira', N'Rio de Janeiro', N'Brazil', N'(21) 555-3412')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(68, N'Michael', N'Holz', N'Genève', N'Switzerland', N'0897-034214')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(69, N'Alejandra', N'Camino', N'Madrid', N'Spain', N'(91) 745 6200')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(70, N'Jonas', N'Bergulfsen', N'Stavern', N'Norway', N'07-98 92 35')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(71, N'Jose', N'Pavarotti', N'Boise', N'USA', N'(208) 555-8097')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(72, N'Hari', N'Kumar', N'London', N'UK', N'(171) 555-1717')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(73, N'Jytte', N'Petersen', N'Kobenhavn', N'Denmark', N'31 12 34 56')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(74, N'Dominique', N'Perrier', N'Paris', N'France', N'(1) 47.55.60.10')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(75, N'Art', N'Braunschweiger', N'Lander', N'USA', N'(307) 555-4680')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(76, N'Pascale', N'Cartrain', N'Charleroi', N'Belgium', N'(071) 23 67 22 20')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(77, N'Liz', N'Nixon', N'Portland', N'USA', N'(503) 555-3612')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(78, N'Liu', N'Wong', N'Butte', N'USA', N'(406) 555-5834')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(79, N'Karin', N'Josephs', N'Münster', N'Germany', N'0251-031259')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(80, N'Miguel', N'Angel Paolino', N'México D.F.', N'Mexico', N'(5) 555-2933')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(81, N'Anabela', N'Domingues', N'Sao Paulo', N'Brazil', N'(11) 555-2167')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(82, N'Helvetius', N'Nagy', N'Kirkland', N'USA', N'(206) 555-8257')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(83, N'Palle', N'Ibsen', N'Århus', N'Denmark', N'86 21 32 43')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(84, N'Mary', N'Saveley', N'Lyon', N'France', N'78.32.54.86')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(85, N'Paul', N'Henriot', N'Reims', N'France', N'26.47.15.10')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(86, N'Rita', N'Müller', N'Stuttgart', N'Germany', N'0711-020361')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(87, N'Pirkko', N'Koskitalo', N'Oulu', N'Finland', N'981-443655')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(88, N'Paula', N'Parente', N'Resende', N'Brazil', N'(14) 555-8122')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(89, N'Karl', N'Jablonski', N'Seattle', N'USA', N'(206) 555-4112')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(90, N'Matti', N'Karttunen', N'Helsinki', N'Finland', N'90-224 8858')
GO
INSERT[dbo].[Customer]
        ([Id], [FirstName], [LastName], [City], [Country], [Phone]) VALUES(91, N'Zbyszek', N'Piestrzeniewicz', N'Warszawa', N'Poland', N'(26) 642-7012')
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(1, CAST(N'2012-07-04T00:00:00.000' AS DateTime), N'542378', 85, CAST(440.00 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(2, CAST(N'2012-07-05T00:00:00.000' AS DateTime), N'542379', 79, CAST(1863.40 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(3, CAST(N'2012-07-08T00:00:00.000' AS DateTime), N'542380', 34, CAST(1813.00 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(4, CAST(N'2012-07-08T00:00:00.000' AS DateTime), N'542381', 84, CAST(670.80 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(5, CAST(N'2012-07-09T00:00:00.000' AS DateTime), N'542382', 76, CAST(3730.00 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(6, CAST(N'2012-07-10T00:00:00.000' AS DateTime), N'542383', 34, CAST(1444.80 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(7, CAST(N'2012-07-11T00:00:00.000' AS DateTime), N'542384', 14, CAST(625.20 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(8, CAST(N'2012-07-12T00:00:00.000' AS DateTime), N'542385', 68, CAST(2490.50 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(9, CAST(N'2012-07-15T00:00:00.000' AS DateTime), N'542386', 88, CAST(517.80 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(10, CAST(N'2012-07-16T00:00:00.000' AS DateTime), N'542387', 35, CAST(1119.90 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(11, CAST(N'2012-07-17T00:00:00.000' AS DateTime), N'542388', 20, CAST(2018.60 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(12, CAST(N'2012-07-18T00:00:00.000' AS DateTime), N'542389', 13, CAST(100.80 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(13, CAST(N'2012-07-19T00:00:00.000' AS DateTime), N'542390', 56, CAST(1746.20 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(14, CAST(N'2012-07-19T00:00:00.000' AS DateTime), N'542391', 61, CAST(448.00 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(15, CAST(N'2012-07-22T00:00:00.000' AS DateTime), N'542392', 65, CAST(624.80 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(16, CAST(N'2012-07-23T00:00:00.000' AS DateTime), N'542393', 20, CAST(2464.80 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(17, CAST(N'2012-07-24T00:00:00.000' AS DateTime), N'542394', 24, CAST(724.50 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(18, CAST(N'2012-07-25T00:00:00.000' AS DateTime), N'542395', 7, CAST(1176.00 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(19, CAST(N'2012-07-26T00:00:00.000' AS DateTime), N'542396', 87, CAST(364.80 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(20, CAST(N'2012-07-29T00:00:00.000' AS DateTime), N'542397', 25, CAST(4031.00 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(21, CAST(N'2012-07-30T00:00:00.000' AS DateTime), N'542398', 33, CAST(1101.20 AS Decimal(12, 2)))
GO
INSERT[dbo].[Order] ([Id], [OrderDate], [OrderNumber], [CustomerId], [TotalAmount]) VALUES(22, CAST(N'2012-07-31T00:00:00.000' AS DateTime), N'542399', 89, CAST(676.00 AS Decimal(12, 2)))
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(1, N'Exotic Liquids', N'Charlotte Cooper', NULL, N'London', N'UK', N'(171) 555-2222', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(2, N'New Orleans Cajun Delights', N'Shelley Burke', NULL, N'New Orleans', N'USA', N'(100) 555-4822', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(3, N'Grandma Kelly''s Homestead', N'Regina Murphy', NULL, N'Ann Arbor', N'USA', N'(313) 555-5735', N'(313) 555-3349')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(4, N'Tokyo Traders', N'Yoshi Nagase', NULL, N'Tokyo', N'Japan', N'(03) 3555-5011', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(5, N'Cooperativa de Quesos ''Las Cabras''', N'Antonio del Valle Saavedra', NULL, N'Oviedo', N'Spain', N'(98) 598 76 54', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(6, N'Mayumi''s', N'Mayumi Ohno', NULL, N'Osaka', N'Japan', N'(06) 431-7877', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(7, N'Pavlova, Ltd.', N'Ian Devling', NULL, N'Melbourne', N'Australia', N'(03) 444-2343', N'(03) 444-6588')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(8, N'Specialty Biscuits, Ltd.', N'Peter Wilson', NULL, N'Manchester', N'UK', N'(161) 555-4448', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(9, N'PB Knäckebröd AB', N'Lars Peterson', NULL, N'Göteborg', N'Sweden', N'031-987 65 43', N'031-987 65 91')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(10, N'Refrescos Americanas LTDA', N'Carlos Diaz', NULL, N'Sao Paulo', N'Brazil', N'(11) 555 4640', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(11, N'Heli Süßwaren GmbH & Co. KG', N'Petra Winkler', NULL, N'Berlin', N'Germany', N'(010) 9984510', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(12, N'Plutzer Lebensmittelgroßmärkte AG', N'Martin Bein', NULL, N'Frankfurt', N'Germany', N'(069) 992755', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(13, N'Nord-Ost-Fisch Handelsgesellschaft mbH', N'Sven Petersen', NULL, N'Cuxhaven', N'Germany', N'(04721) 8713', N'(04721) 8714')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(14, N'Formaggi Fortini s.r.l.', N'Elio Rossi', NULL, N'Ravenna', N'Italy', N'(0544) 60323', N'(0544) 60603')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(15, N'Norske Meierier', N'Beate Vileid', NULL, N'Sandvika', N'Norway', N'(0)2-953010', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(16, N'Bigfoot Breweries', N'Cheryl Saylor', NULL, N'Bend', N'USA', N'(503) 555-9931', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(17, N'Svensk Sjöföda AB', N'Michael Björn', NULL, N'Stockholm', N'Sweden', N'08-123 45 67', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(18, N'Aux joyeux ecclésiastiques', N'Guylène Nodier', NULL, N'Paris', N'France', N'(1) 03.83.00.68', N'(1) 03.83.00.62')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(19, N'New England Seafood Cannery', N'Robb Merchant', NULL, N'Boston', N'USA', N'(617) 555-3267', N'(617) 555-3389')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(20, N'Leka Trading', N'Chandra Leka', NULL, N'Singapore', N'Singapore', N'555-8787', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(21, N'Lyngbysild', N'Niels Petersen', NULL, N'Lyngby', N'Denmark', N'43844108', N'43844115')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(22, N'Zaanse Snoepfabriek', N'Dirk Luchte', NULL, N'Zaandam', N'Netherlands', N'(12345) 1212', N'(12345) 1210')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(23, N'Karkki Oy', N'Anne Heikkonen', NULL, N'Lappeenranta', N'Finland', N'(953) 10956', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(24, N'G''day, Mate', N'Wendy Mackenzie', NULL, N'Sydney', N'Australia', N'(02) 555-5914', N'(02) 555-4873')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(25, N'Ma Maison', N'Jean-Guy Lauzon', NULL, N'Montréal', N'Canada', N'(514) 555-9022', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(26, N'Pasta Buttini s.r.l.', N'Giovanni Giudici', NULL, N'Salerno', N'Italy', N'(089) 6547665', N'(089) 6547667')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(27, N'Escargots Nouveaux', N'Marie Delamare', NULL, N'Montceau', N'France', N'85.57.00.07', NULL)
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(28, N'Gai pâturage', N'Eliane Noz', NULL, N'Annecy', N'France', N'38.76.98.06', N'38.76.98.58')
GO
INSERT[dbo].[Supplier]
        ([Id], [CompanyName], [ContactName], [ContactTitle], [City], [Country], [Phone], [Fax]) VALUES(29, N'Forêts d''érables', N'Chantal Goulet', NULL, N'Ste-Hyacinthe', N'Canada', N'(514) 555-2955', N'(514) 555-2921')
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(1, N'Chai', 1, CAST(18.00 AS Decimal(12, 2)), N'10 boxes x 20 bags', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(2, N'Chang', 1, CAST(19.00 AS Decimal(12, 2)), N'24 - 12 oz bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(3, N'Aniseed Syrup', 1, CAST(10.00 AS Decimal(12, 2)), N'12 - 550 ml bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(4, N'Chef Anton''s Cajun Seasoning', 2, CAST(22.00 AS Decimal(12, 2)), N'48 - 6 oz jars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(5, N'Chef Anton''s Gumbo Mix', 2, CAST(21.35 AS Decimal(12, 2)), N'36 boxes', 1)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(6, N'Grandma''s Boysenberry Spread', 3, CAST(25.00 AS Decimal(12, 2)), N'12 - 8 oz jars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(7, N'Uncle Bob''s Organic Dried Pears', 3, CAST(30.00 AS Decimal(12, 2)), N'12 - 1 lb pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(8, N'Northwoods Cranberry Sauce', 3, CAST(40.00 AS Decimal(12, 2)), N'12 - 12 oz jars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(9, N'Mishi Kobe Niku', 4, CAST(97.00 AS Decimal(12, 2)), N'18 - 500 g pkgs.', 1)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(10, N'Ikura', 4, CAST(31.00 AS Decimal(12, 2)), N'12 - 200 ml jars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(11, N'Queso Cabrales', 5, CAST(21.00 AS Decimal(12, 2)), N'1 kg pkg.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(12, N'Queso Manchego La Pastora', 5, CAST(38.00 AS Decimal(12, 2)), N'10 - 500 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(13, N'Konbu', 6, CAST(6.00 AS Decimal(12, 2)), N'2 kg box', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(14, N'Tofu', 6, CAST(23.25 AS Decimal(12, 2)), N'40 - 100 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(15, N'Genen Shouyu', 6, CAST(15.50 AS Decimal(12, 2)), N'24 - 250 ml bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(16, N'Pavlova', 7, CAST(17.45 AS Decimal(12, 2)), N'32 - 500 g boxes', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(17, N'Alice Mutton', 7, CAST(39.00 AS Decimal(12, 2)), N'20 - 1 kg tins', 1)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(18, N'Carnarvon Tigers', 7, CAST(62.50 AS Decimal(12, 2)), N'16 kg pkg.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(19, N'Teatime Chocolate Biscuits', 8, CAST(9.20 AS Decimal(12, 2)), N'10 boxes x 12 pieces', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(20, N'Sir Rodney''s Marmalade', 8, CAST(81.00 AS Decimal(12, 2)), N'30 gift boxes', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(21, N'Sir Rodney''s Scones', 8, CAST(10.00 AS Decimal(12, 2)), N'24 pkgs. x 4 pieces', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(22, N'Gustaf''s Knäckebröd', 9, CAST(21.00 AS Decimal(12, 2)), N'24 - 500 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(23, N'Tunnbröd', 9, CAST(9.00 AS Decimal(12, 2)), N'12 - 250 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(24, N'Guaraná Fantástica', 10, CAST(4.50 AS Decimal(12, 2)), N'12 - 355 ml cans', 1)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(25, N'NuNuCa Nuß-Nougat-Creme', 11, CAST(14.00 AS Decimal(12, 2)), N'20 - 450 g glasses', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(26, N'Gumbär Gummibärchen', 11, CAST(31.23 AS Decimal(12, 2)), N'100 - 250 g bags', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(27, N'Schoggi Schokolade', 11, CAST(43.90 AS Decimal(12, 2)), N'100 - 100 g pieces', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(28, N'Rössle Sauerkraut', 12, CAST(45.60 AS Decimal(12, 2)), N'25 - 825 g cans', 1)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(29, N'Thüringer Rostbratwurst', 12, CAST(123.79 AS Decimal(12, 2)), N'50 bags x 30 sausgs.', 1)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(30, N'Nord-Ost Matjeshering', 13, CAST(25.89 AS Decimal(12, 2)), N'10 - 200 g glasses', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(31, N'Gorgonzola Telino', 14, CAST(12.50 AS Decimal(12, 2)), N'12 - 100 g pkgs', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(32, N'Mascarpone Fabioli', 14, CAST(32.00 AS Decimal(12, 2)), N'24 - 200 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(33, N'Geitost', 15, CAST(2.50 AS Decimal(12, 2)), N'500 g', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(34, N'Sasquatch Ale', 16, CAST(14.00 AS Decimal(12, 2)), N'24 - 12 oz bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(35, N'Steeleye Stout', 16, CAST(18.00 AS Decimal(12, 2)), N'24 - 12 oz bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(36, N'Inlagd Sill', 17, CAST(19.00 AS Decimal(12, 2)), N'24 - 250 g  jars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(37, N'Gravad lax', 17, CAST(26.00 AS Decimal(12, 2)), N'12 - 500 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(38, N'Côte de Blaye', 18, CAST(263.50 AS Decimal(12, 2)), N'12 - 75 cl bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(39, N'Chartreuse verte', 18, CAST(18.00 AS Decimal(12, 2)), N'750 cc per bottle', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(40, N'Boston Crab Meat', 19, CAST(18.40 AS Decimal(12, 2)), N'24 - 4 oz tins', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(41, N'Jack''s New England Clam Chowder', 19, CAST(9.65 AS Decimal(12, 2)), N'12 - 12 oz cans', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(42, N'Singaporean Hokkien Fried Mee', 20, CAST(14.00 AS Decimal(12, 2)), N'32 - 1 kg pkgs.', 1)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(43, N'Ipoh Coffee', 20, CAST(46.00 AS Decimal(12, 2)), N'16 - 500 g tins', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(44, N'Gula Malacca', 20, CAST(19.45 AS Decimal(12, 2)), N'20 - 2 kg bags', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(45, N'Rogede sild', 21, CAST(9.50 AS Decimal(12, 2)), N'1k pkg.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(46, N'Spegesild', 21, CAST(12.00 AS Decimal(12, 2)), N'4 - 450 g glasses', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(47, N'Zaanse koeken', 22, CAST(9.50 AS Decimal(12, 2)), N'10 - 4 oz boxes', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(48, N'Chocolade', 22, CAST(12.75 AS Decimal(12, 2)), N'10 pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(49, N'Maxilaku', 23, CAST(20.00 AS Decimal(12, 2)), N'24 - 50 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(50, N'Valkoinen suklaa', 23, CAST(16.25 AS Decimal(12, 2)), N'12 - 100 g bars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(51, N'Manjimup Dried Apples', 24, CAST(53.00 AS Decimal(12, 2)), N'50 - 300 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(52, N'Filo Mix', 24, CAST(7.00 AS Decimal(12, 2)), N'16 - 2 kg boxes', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(53, N'Perth Pasties', 24, CAST(32.80 AS Decimal(12, 2)), N'48 pieces', 1)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(54, N'Tourtière', 25, CAST(7.45 AS Decimal(12, 2)), N'16 pies', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(55, N'Pâté chinois', 25, CAST(24.00 AS Decimal(12, 2)), N'24 boxes x 2 pies', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(56, N'Gnocchi di nonna Alice', 26, CAST(38.00 AS Decimal(12, 2)), N'24 - 250 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(57, N'Ravioli Angelo', 26, CAST(19.50 AS Decimal(12, 2)), N'24 - 250 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(58, N'Escargots de Bourgogne', 27, CAST(13.25 AS Decimal(12, 2)), N'24 pieces', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(59, N'Raclette Courdavault', 28, CAST(55.00 AS Decimal(12, 2)), N'5 kg pkg.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(60, N'Camembert Pierrot', 28, CAST(34.00 AS Decimal(12, 2)), N'15 - 300 g rounds', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(61, N'Sirop d''érable', 29, CAST(28.50 AS Decimal(12, 2)), N'24 - 500 ml bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(62, N'Tarte au sucre', 29, CAST(49.30 AS Decimal(12, 2)), N'48 pies', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(63, N'Vegie-spread', 7, CAST(43.90 AS Decimal(12, 2)), N'15 - 625 g jars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(64, N'Wimmers gute Semmelknödel', 12, CAST(33.25 AS Decimal(12, 2)), N'20 bags x 4 pieces', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(65, N'Louisiana Fiery Hot Pepper Sauce', 2, CAST(21.05 AS Decimal(12, 2)), N'32 - 8 oz bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(66, N'Louisiana Hot Spiced Okra', 2, CAST(17.00 AS Decimal(12, 2)), N'24 - 8 oz jars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(67, N'Laughing Lumberjack Lager', 16, CAST(14.00 AS Decimal(12, 2)), N'24 - 12 oz bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(68, N'Scottish Longbreads', 8, CAST(12.50 AS Decimal(12, 2)), N'10 boxes x 8 pieces', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(69, N'Gudbrandsdalsost', 15, CAST(36.00 AS Decimal(12, 2)), N'10 kg pkg.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(70, N'Outback Lager', 7, CAST(15.00 AS Decimal(12, 2)), N'24 - 355 ml bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(71, N'Flotemysost', 15, CAST(21.50 AS Decimal(12, 2)), N'10 - 500 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(72, N'Mozzarella di Giovanni', 14, CAST(34.80 AS Decimal(12, 2)), N'24 - 200 g pkgs.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(73, N'Röd Kaviar', 17, CAST(15.00 AS Decimal(12, 2)), N'24 - 150 g jars', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(74, N'Longlife Tofu', 4, CAST(10.00 AS Decimal(12, 2)), N'5 kg pkg.', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(75, N'Rhönbräu Klosterbier', 12, CAST(7.75 AS Decimal(12, 2)), N'24 - 0.5 l bottles', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(76, N'Lakkalikööri', 23, CAST(18.00 AS Decimal(12, 2)), N'500 ml', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(77, N'Original Frankfurter grüne Soße', 12, CAST(13.00 AS Decimal(12, 2)), N'12 boxes', 0)
GO
INSERT[dbo].[Product] ([Id], [ProductName], [SupplierId], [UnitPrice], [Package], [IsDiscontinued]) VALUES(78, N'Stroopwafels', 22, CAST(9.75 AS Decimal(12, 2)), N'24 pieces', 0)
GO
";
    }
}
