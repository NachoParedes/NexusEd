USE NexusEd;
-- 1. Normalizar email a minúsculas y validar fecha de nacimiento
DELIMITER //
CREATE TRIGGER trg_personas_before_insert
BEFORE INSERT ON Personas
FOR EACH ROW
BEGIN
    -- Convierte el email a minúsculas y quita espacios extra
    IF NEW.Email IS NOT NULL THEN
        SET NEW.Email = LOWER(TRIM(NEW.Email));
    END IF;

    -- Impide registrar personas con fechas de nacimiento futuras
    IF NEW.FechaNacimiento > CURDATE() THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: La fecha de nacimiento no puede ser una fecha futura.';
    END IF;
END //
DELIMITER ;

-- 2. Autocompletar la fecha de inscripción si no se envía desde C#
DELIMITER //
CREATE TRIGGER trg_inscripciones_before_insert
BEFORE INSERT ON Inscripciones
FOR EACH ROW
BEGIN
    IF NEW.FechaInscripcion IS NULL THEN
        SET NEW.FechaInscripcion = NOW();
    END IF;
END //
DELIMITER ;

-- 3. Validar que la fecha de inscripción del alumno no sea futura
DELIMITER //
CREATE TRIGGER trg_alumnos_before_insert
BEFORE INSERT ON Alumnos
FOR EACH ROW
BEGIN
    IF NEW.FechaInscripcion > CURDATE() THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: La fecha de inscripción del alumno no puede ser futura.';
    END IF;
END //
DELIMITER ;