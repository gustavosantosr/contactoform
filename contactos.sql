-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 07-05-2019 a las 21:03:33
-- Versión del servidor: 10.0.38-MariaDB
-- Versión de PHP: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `drmonkey_contactos`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Contactos`
--

CREATE TABLE `Contactos` (
  `Id` int(11) NOT NULL,
  `nombre` longtext,
  `email` longtext NOT NULL,
  `mensaje` longtext,
  `documento` int(11) NOT NULL,
  `TipoDocumentoID` int(11) NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `Contactos`
--

INSERT INTO `Contactos` (`Id`, `nombre`, `email`, `mensaje`, `documento`, `TipoDocumentoID`) VALUES
(1, 'Gustavo Santos', 'gustavosantosr@gmail.com', NULL, 80819446, 0),
(2, 'Gustavo Santos', 'gustavosantosr@gmail.com', NULL, 80819446, 1),
(3, 'Gustavo Santos', 'gustavosantosr@gmail.com', NULL, 80819446, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `TiposDocumentos`
--

CREATE TABLE `TiposDocumentos` (
  `Id` int(11) NOT NULL,
  `Tipo` longtext
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `TiposDocumentos`
--

INSERT INTO `TiposDocumentos` (`Id`, `Tipo`) VALUES
(1, 'Cédula Ciudadania'),
(2, 'Cédula Extrangería'),
(3, 'Tarjeta de Identidad');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20190507163420_Initial', '2.1.8-servicing-32085'),
('20190507165122_TipoDocumento', '2.1.8-servicing-32085');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `Contactos`
--
ALTER TABLE `Contactos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Contactos_TipoDocumentoID` (`TipoDocumentoID`);

--
-- Indices de la tabla `TiposDocumentos`
--
ALTER TABLE `TiposDocumentos`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `Contactos`
--
ALTER TABLE `Contactos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `TiposDocumentos`
--
ALTER TABLE `TiposDocumentos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
