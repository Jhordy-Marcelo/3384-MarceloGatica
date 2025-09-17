# Control de Versiones

### GitBash
<< Una herramienta que permite interactuar con Git desde una interfaz de línea de comandos. Básicamente, combina la potencia del sistema de control de versiones Git con un entorno de consola similar al de Linux, pero dentro de Windows. Gracias a esto, el usuario puede ejecutar comandos que facilitan la gestión de proyectos, como crear repositorios, clonar, realizar commits, trabajar con ramas y sincronizar archivos con plataformas como GitHub.>>

### GitHub
<< plataforma en línea que permite guardar proyectos y trabajar en ellos de manera colaborativa usando Git. Facilita el control de versiones, el trabajo en equipo y la organización del código, siendo muy útil tanto en el ámbito académico como profesional.>>

## Comandos

#### Comandos de Configuracion

---git config --global user.name "Tu Nombre"---

---git config --global user.email "tu@email.com"---

---git config --global core.editor "code -wait"---

---git config --list---

#### Comandos Básicos de Repositorio

---git init # Inicializar repositorio---

---git status # Ver estado de archivos---

---git add archivo.txt # Agregar archivo específico---

---git add . # Agregar todos los archivos---

---git commit -m "mensaje" # Crear commit con mensaje---

---git log # Ver historial de commits---

---git log --oneline # Ver historial resumido---

#### Comandos de Repositorio Remoto

---git remote add origin [URL] # Conectar con repositorio remoto---

---git remote -v # Ver repositorios remotos---

---git push origin main # Subir cambios a GitHub---

---git push -u origin main # Primer push (establecer upstream)---

---git pull origin main # Descargar cambios de GitHub---

---git clone [URL] # Clonar repositorio existente---

#### Comandos de Información
