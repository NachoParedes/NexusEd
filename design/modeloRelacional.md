erDiagram
    Personas {
        int IdPersona PK
        int Dni UK
        string Nombre
        string Apellido
        date FechaNacimiento
        string Email
    }
    Alumnos {
        int IdPersona PK, FK
        int NroLibreta UK
        date FechaInscripcion
        string Carrera
    }
    Profesores {
        int IdPersona PK, FK
        int Legajo UK
        string Titulo
    }
    Institutos {
        int IdInstituto PK
        string Nombre
        string Direccion
        string Telefono
        string Contacto
    }
    Cursos {
        int IdCurso PK
        string Nombre
    }
    CursosUniversitarios {
        int IdCurso PK, FK
        string Aula
        string Horario
        int IdProfesor FK
    }
    CursosExternos {
        int IdCurso PK, FK
        int IdInstituto FK
    }
    Inscripciones {
        int IdInscripcion PK
        int IdCurso FK
        int IdAlumno FK
        datetime FechaInscripcion
    }

    Personas ||--o| Alumnos : "hereda"
    Personas ||--o| Profesores : "hereda"
    
    Cursos ||--o| CursosUniversitarios : "hereda"
    Cursos ||--o| CursosExternos : "hereda"
    
    Profesores ||--o{ CursosUniversitarios : "dicta"
    Institutos ||--o{ CursosExternos : "organiza"
    
    Alumnos ||--o{ Inscripciones : "tiene"
    Cursos ||--o{ Inscripciones : "tiene"