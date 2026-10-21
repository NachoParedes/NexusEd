classDiagram
    class Persona {
        +int Dni
        +string Nombre
        +string Apellido
    }
    class Alumno {
        +int NroLibreta
        +string Carrera
    }
    class Profesor {
        +int Legajo
        +string Titulo
    }
    class Instituto {
        +int IdInstituto
        +string Nombre
    }
    class Curso {
        +int IdCurso
        +string NombreCurso
    }
    class CursoUniversitario {
        +string Aula
        +string Horario
    }
    class CursoExterno {
    }

    Persona <|-- Alumno : Herencia
    Persona <|-- Profesor : Herencia
    Curso <|-- CursoUniversitario : Herencia
    Curso <|-- CursoExterno : Herencia

    CursoUniversitario "*" --> "1" Profesor : Asignado a
    CursoExterno "*" --> "1" Instituto : Pertenece a
    Curso "*" <--> "*" Alumno : Inscripción (M:N)