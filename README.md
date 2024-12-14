# Registro de Usuario API



## Descripción

Este proyecto implementa un servicio backend para registrar usuarios, almacenando su nombre y número de teléfono, utilizando **C#** y **ASP.NET Core**. Está diseñado con una **arquitectura por capas** que incluye una capa de presentación, aplicación, dominio e infraestructura para separar las preocupaciones y mejorar la mantenibilidad.

### Autor
Desarrollado por **Cesar Carreño**

## Tabla de Contenidos

- [Descripción del Proyecto](#descripción)
- [Arquitectura](#arquitectura)
- [Explicación del Código](#explicación-del-código)
- [Dependencias](#dependencias)
- [Instalación](#instalación)
- [Ejemplos de Uso](#ejemplos-de-uso)
- [Mejoras Futuras](#mejoras-futuras)

## Arquitectura

La arquitectura del proyecto está organizada en **4 capas**:

### 1. Capa de Presentación
La capa de presentación es responsable de manejar las solicitudes HTTP. Aquí se encuentran los controladores que exponen los endpoints de la API. En este caso, el controlador `UserController` permite a los usuarios registrar sus datos a través de una solicitud `POST`.

### 2. Capa de Aplicación
La capa de aplicación contiene la lógica de negocio que valida los datos del usuario antes de pasarlos a la capa de dominio. El servicio `UserApplicationService` interactúa con la capa de dominio para realizar el registro y proporciona retroalimentación al usuario.

### 3. Capa de Dominio
La capa de dominio es donde ocurre la lógica central del negocio. La clase `UserDomainServices` es responsable de registrar al usuario y comunicarse con la capa de repositorios.

### 4. Capa de Infraestructura
La infraestructura maneja el almacenamiento de datos. En este caso, la clase `UserRepository` simula el almacenamiento en memoria y la notificación al usuario sobre su registro exitoso.

## Explicación del Código

### **UserController**
Exponen el endpoint `POST /api/user/register`, donde se reciben los datos de usuario (`name`, `phone`) y se validan. Si la validación es exitosa, los datos se pasan a la capa de aplicación.

### **UserApplicationService**
Valida los datos del usuario y luego interactúa con la capa de dominio para realizar el registro del usuario. Si todo es exitoso, se devuelve un mensaje de éxito.

### **UserDomainServices**
Es el responsable de almacenar los datos del usuario y notificarlo mediante un mensaje. Esta capa es crucial para manejar la lógica de negocio principal.

### **UserValidator**
Valida los datos recibidos de los usuarios utilizando **FluentValidation**. Asegura que el nombre y el teléfono sean válidos antes de proceder con el registro.

### **UserRepository**
Simula un repositorio que guarda los datos del usuario en memoria y notifica al usuario sobre su registro.

## Dependencias

Este proyecto utiliza las siguientes dependencias:

- **FluentValidation**: Para validar los datos de los usuarios.
- **ASP.NET Core**: Para construir la API web y exponer los endpoints.
- **NUnit**: Para realizar pruebas unitarias (si es necesario).

## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/usuario/repositorio.git
