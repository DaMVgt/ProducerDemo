# ProducerDemo
Aplicativo para crear y enviar mensajes a una cola administrada con la herramienta RabbitMQ. Ejercicio realizado en carrera FullStack .NET en Fundacion Kinal.

## Herramientas usadas
1. Docker.
2. RabbitMQ.

### Configuración Docker
Se necesita tener instalado programa para poder hacer uso de las herramientas [Download Docker](https://www.docker.com/get-started/).
>Ingreso de comandos desde una terminal.
- Descargar imagen de Rabbit.

```
docker pull rabbitmq:3-management
```

- Levantar servicio de RabbitMQ.

```
docker run --rm -d -p 15672:15672 -p 5672:5672 --name dev_rabbit_net rabbitmq:3-management
```

### Configuración RabbitMQ
- URL de entrada al panel de RabbitMQ http://localhost:15672/.
- Usuario y constraseña para logeo son las que traen por defecto "guest".
- Creación de exchange para uso de QUEUE.
![Creacion de exchange](https://imgur.com/MBJ18VT.png)
>Nota: Si se agrega otro exchange diferente al **exchange-demo** también se debe de cambiar en el código.
- Creación de QUEUE.
![Creacion de QUEUE](https://imgur.com/T4Jektq.png)
- Conexión de Exchange al QUEUE dando click en el QUEUE creado anteriormente.
![Conexion Exchange a QUEUE](https://imgur.com/NDsyj3y.png)
> En "From Exchange" se agrega el Exchange creado y luego click en "Bind".
