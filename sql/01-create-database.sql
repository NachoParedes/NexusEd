CREATE DATABASE IF NOT EXISTS NexusEd;
USE NexusEd;

-- ========================================================
-- ENTIDADES BASE (Sin dependencias de otras tablas)
-- ========================================================

CREATE TABLE Personas (
    IdPersona INT AUTO_INCREMENT PRIMARY KEY,
    Dni INT UNIQUE NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Email VARCHAR(150)
);

CREATE TABLE Institutos (
    IdInstituto INT PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL,
    Direccion VARCHAR(200),
    Telefono VARCHAR(30),
    Contacto VARCHAR(100)
);

CREATE TABLE Cursos (
    IdCurso INT PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL
);

-- ========================================================
-- ROLES DE PERSONAS (Dependen de Personas)
-- ========================================================

CREATE TABLE Alumnos (
    IdPersona INT PRIMARY KEY,
    NroLibreta INT UNIQUE NOT NULL,
    FechaInscripcion DATE NOT NULL,
    Carrera VARCHAR(100) NOT NULL,
    FOREIGN KEY (IdPersona) REFERENCES Personas(IdPersona) ON DELETE CASCADE
);

CREATE TABLE Profesores (
    IdPersona INT PRIMARY KEY,
    Legajo INT UNIQUE NOT NULL,
    Titulo VARCHAR(150) NOT NULL,
    FOREIGN KEY (IdPersona) REFERENCES Personas(IdPersona) ON DELETE CASCADE
);

-- ========================================================
-- TIPOS DE CURSOS (Dependen de Cursos, Institutos y Profesores)
-- ========================================================

CREATE TABLE CursosUniversitarios (
    IdCurso INT PRIMARY KEY,
    Aula VARCHAR(50),
    Horario VARCHAR(100),
    IdProfesor INT NOT NULL,
    FOREIGN KEY (IdCurso) REFERENCES Cursos(IdCurso) ON DELETE CASCADE,
    FOREIGN KEY (IdProfesor) REFERENCES Profesores(IdPersona)
);

CREATE TABLE CursosExternos (
    IdCurso INT PRIMARY KEY,
    IdInstituto INT NOT NULL,
    FOREIGN KEY (IdCurso) REFERENCES Cursos(IdCurso) ON DELETE CASCADE,
    FOREIGN KEY (IdInstituto) REFERENCES Institutos(IdInstituto)
);

-- ========================================================
-- RELACIONES / TRANSACCIONES (Dependen de Cursos y Alumnos)
-- ========================================================

CREATE TABLE Inscripciones (
    IdInscripcion INT AUTO_INCREMENT PRIMARY KEY,
    IdCurso INT NOT NULL,
    IdAlumno INT NOT NULL,
    FechaInscripcion DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (IdCurso) REFERENCES Cursos(IdCurso) ON DELETE CASCADE,
    FOREIGN KEY (IdAlumno) REFERENCES Alumnos(IdPersona) ON DELETE CASCADE,
    UNIQUE (IdCurso, IdAlumno) 
);