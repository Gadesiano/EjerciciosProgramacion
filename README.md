# EjerciciosProgramacion

Repositorio de ejercicios de programación en **.NET / C#**, orientado a entrenar lógica, algoritmos y buenas prácticas de desarrollo. Sirve también como práctica de control de versiones con Git y GitHub.

## Stack

- Visual Studio 2022
- .NET (C#)
- Git + GitHub

## Estructura del proyecto

```
EjerciciosProgramacion/
├── EjerciciosProgramacion.sln
├── README.md
└── src/
    └── EjerciciosProgramacion/       # Proyecto principal (Console App)
        ├── Program.cs                # Menú de selección de ejercicios
        ├── Algoritmos/
        ├── Strings/
        ├── LINQ/
        ├── POO/
        └── ...
```

## Organización de ejercicios

Cada ejercicio es una clase independiente dentro de su carpeta temática. Las categorías crecen a medida que se añaden nuevos ejercicios.

| Categoría | Descripción |
|-----------|-------------|
| `Algoritmos` | Ordenación, búsqueda, recursividad |
| `Strings` | Manipulación de cadenas |
| `LINQ` | Consultas y operaciones sobre colecciones |
| `POO` | Patrones y principios de orientación a objetos |

## Convención de commits

Se usa el estándar [Conventional Commits](https://www.conventionalcommits.org):

```
feat:     nuevo ejercicio o funcionalidad
fix:      corrección de un error
refactor: mejora de código sin cambio de comportamiento
test:     añadir o modificar tests
chore:    mantenimiento, configuración
docs:     documentación
```

## Progreso

El historial de commits refleja el avance del proyecto. Cada ejercicio resuelto corresponde a al menos un commit con descripción del problema abordado.
