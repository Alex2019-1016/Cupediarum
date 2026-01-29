# Cupediarum

# Proyecto_Cupediarum
Sistema de ventas para el Restaurante Nova (Restaurante ficticio)

## 1. Ficha del Equipo (Info Semana 1)
*Esta sección formaliza la constitución del grupo de trabajo.*

| Nombre del Estudiante | Rol Principal | GitHub User     |
| --------------------- | ------------- | --------------- |
| Alexa Caba            | Fullstack     | @Alex2019-1016  |

_____
## 2. Definición del Negocio

### 🏢 La Empresa (Cliente)

- **Nombre:** Restaurante Nova (Empresa Ficticia basada en procesos reales).
- **Sector:** Ventas de Comidas y Bebidas.

  ### El Problema

El sistema que utiliza Restaurante Nova, no es practico para el usuario, poco atractivo a nivel de interfaz y carece
de opciones que podrian hacer que el usuario agilice su trabajo. Esto genera algunos problemas como:

1. Problemas con el tiempo de respuesta al cliente.
2. Confusiones a la hora de preparar la comida.
3. Descontrol en las cuentas.
4. Problemas para identificar el dueño (mesero) de cada pedido.
5. Perdida de tiempo al tomar los pedidos al hacerse desde adentro.

   ### La Solución Propuesta

Desarrollar **"Cupediarum"**, una aplicacion de escritorio, que permita a los usuarios del restaurante interactuar
de forma mas sencilla y facil, registrar las ventas, llevar el control de las mesas y darle un mejor
servicio al cliente.

_____
## 3. Alcance del Proyecto (Scope)
### ✅ Dentro del Alcance (MVP - Producto Mínimo Viable)

*Funcionalidades críticas que estarán listas para la semana 11.*

· El sistema permitirá la gestión básica de un restaurante pequeño o mediano. 
· Incluirá control de productos, pedidos, ventas y usuarios. 
· Funcionará de manera local utilizando SQL Server. 

### Fuera del Alcance

*Cosas que NO haremos en este curso por falta de tiempo.*

1. **Pagos en Línea:** No integraremos pasarela de pagos (Stripe/Azul), el pago se registra manual en el local.
2. **Control de Inventario:** No se controlará el stock de productos.
3. No se podrá a adaptar al móvil por falta de tiempo.

_____
## 4. Stack Tecnológico

- **Lenguaje:** C#
- **Frontend:** C# + Windows Forms, .NET
- **Backend:** C# , SQL Server
- **Base de Datos:** SQLSever
- **Herramientas Extra:** GitHub Projects (para gestión de tareas).

_____
## 5. Requerimientos

### ⚙️ Requerimientos Funcionales (RF)
|  ID  	|        Título        |                  Descripción Breve                      |	  Prioridad   |
| ----- | -------------------- | ------------------------------------------------------- | -------------- |
| RF-01 |	Gestión de Servicios | Admin puede agregar productos y asignar precios.        | Media          |
| RF-02 | Control de las mesas | Control en la cantidad de mesas, pedidos y tiempo.      | Alta (Crítico) |
| RF-03 |	Registro de Cobro	   | Cajero/a recibe el pago y lo registra en el sistema.    | Alta           |

