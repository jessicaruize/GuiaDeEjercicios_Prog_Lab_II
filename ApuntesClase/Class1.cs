using System;
using System.Collections.Generic;

namespace _01CladeDeIntroduccion
{
    public class Class1
    {

    }
}
/*
                    01 CLASE INTRODUCCION .net Y C#
 .NET : 
-Es una plataforma de desarrollo. nace 2002 Microsoft.
CARACTERISTICAS:
- Multiplataforma
- Open Source
- Multi-lenguaje: Visual Basic.NET - F# - C# 
COMPONENTES
- Common Language Runtime (CLR) -> Administra memoria.
- Base Class Library (BCL) 
- Componentes de infraestructura comùn  (lengguajes, compiladores, sistema de proyectos etc.)
- Frameworks (Windows Forms, WPF, ASP.NET) //Desarrollar aplicaciones especificas.
-Herramientas de desarrollo. (editores de codigo, IDEs, linea de comandos).

bibliotecas: Serie de funciones para realizar tareas especificas.
Frameworks (marcos de trabajo): Define un modelo de trabajo y nos brinda una serie de herramientas de alto nivel que permite 
desarrollar ciertos tipos de aplicaciones con facilidad, ejecuta el codigo, se componen de multiples bibliotecas.
Inversion de control, nosotros encastramos las bibliotecas en nuestro codigo, el frameworks nos dice donde meterlos.
 
PROCESO DE COMPILACION
1_ Se compila los archivos que contienen el codigo fuente a lenguaje intermedio. (compilaciòn estatica)
2_ Al ejecutarse la aplicaciòn, el lenguaje intermedio se compila a lenguaje nativo(maquina) por CLR (Just in Time)
tiempo de compilacion: Todo lo que pasa desde que se esta desarrollando hasta que termino la compilaciòn
Tiempo de ejecucion : el tiempo durante el cual se esta ejecutando el programa.
 
C# 
CARACTERISTICAS
-Compilacion hìbrida
-Orientado a objetos
-Orientado a componentes
-Seguridad de tipos (tipado estatico)
-Garbage collection
-Sistema de tipos unificado. Todos derivan de object
-Case Sensitive. diferencias entre MAY y MIN 
 

                02 CLASE DE CLASES Y METODOS

Principio dry:  Cuando ocurre un cambio en el codigo no deberiamos tener que hacer el cambio en mas de un lugar en paralelo.
Toda pieza de conocimiento debe tener una representacion unica, inequivoca y fidedigna dentro de un sistema. 
Pieza de conocimiento: Funcionalidad presisa dentro del contexto de negocio o un algoritmo concreto.
ùnica: Para cada pieza de representacion no debe existir otra representacion de la misma pieza.
inequivoca: Solamente puede ser interpretada, entendida o explicada de una manera.
fidedig: Debemos confiar que es correcta.

METODOS ESTATICOS:
Permiten separar el codigo en piezas para reutilizarlos en otras partes del codigo.
CLASES:
identificador : sustantivo singular
STATIC : Todos los miembros estaticos

Atajos
ctr + r + r --> Cambia nombre 
ctr + k + c --> Comenta
ctr + k + u --> descomenta
ctrl + k + d --> Ordena el còdigo
crtl + alt + cursor --> varios cursores.
seleccionar atributos lamparita crea constructores, get set etc.


 Paradigma: Teoria o cunjunto de teorias cuyo nucleo central se acepta sin cuestionar
 y que suministra la base y modelo para resolver problemas y avanzar en el conocimiento.
 Un paradigma de prpogramaciòn define la forma, metodologia o estilo con el que 
 se resolvera un problema, utilizando un lenguaje de programaciòn
 POO es un paradigma de prog, propone resolver problemas a traves de identificar objetos
(no son siempre tangibles) de la vida real, sus atributos, sus comportamientos y 
las relaciones  de colaboracion entre ellos.

PILARES

-Encapsulamiento.

- Abstraccion. 
Habilidad de abordar un concepto mientras se ignoran algunos detalle(Lo no importante).
    -Identificar las entidades que forman parte de nuestro contexto o problema a resolver.
    -Definir las caracteristicas esenciales de una entidad.
    -Descartar las caracteristicas que no sean relevantes.

-Herencia.
-Polimorfismo.

                03 CLASE DE POO

Clase: Es una descripciòn de un conjunto de objetos que coparten los mismos atributos, 
metodos, relaciones y semantica en un determinado contexto.(definen como son los objetos)

Composicion:
-Atributos. (caracteristicas que son compartidas por todos los objetos de una clase.)
-Metodos. (Acciones del objeto)
-Relaciones, las clases se conectan a travez de relaciones y colaboran para realizar un comportamiento mayor.
-Semantica, significado que se le da a la clase y a sus relaciones dentro del contexto de negocio.

Constructor:
Metodo especial que le da un valor inicial a los atributos de un objeto 
para asegurar el correcto funcionamiento del mismo.()Valor inicial valido y seguro).
    -Estaticos: No lleva parametros de entrada ni modificador de accesibilidad ya que lo llama el CLR 
    -Es invocado una ùnica vez en la primera interaciòn con la clase.Inicializa atributos estaticos.
    -Solo acepta miembros static, los constructores de instancia aceptan miembros static y no static. 
 
-Metodos de acceso:(getter/lectura - setter/escritura)
Permiten consultar o modificar el valor de los atributos de un objeto de forma segura(encapsulamiento).

-Diagrama de clases:
UML lenguaje que sirve para escribir modelos para construir software.
    -Contexto de negocio/ Dominio.
    -Como nombrar: Grafìa pascal, sustantivo-singular, nombres descriptivos 

OBJETOS:
son instancias de una clase, una instancia es una manifestacion concreta de algo.
-Caracteristicas:
    -Viven en la memoria.(tiempo de ejecuciòn)
    -Tienen identidad, se puede diferenciar un objeto de otro. la identidad maxima es la direcciòn de meoria.
    -Los objetos se comunican. Si estan relacionados pueden enviar o recibir mensajes de otros objetos.
el comportamiento de un objeto son las acciones que puede realizar al recibir un mensaje de otro objeto.
Tiempo de vida:
    -Se puede saber cuando se crea pero no cuando termina, no esta vinculado a su ambito. No es determinista GC.
    -New reserva memoria, el constructor lo inicializa. 
Estado de un objeto: Son los valores que toman sus atributos en un determinado momento.

        
                04 CLASE DE SOBRECARGA

 SOBRECARGA (OVERFLOW) 
-Metodos:
-Constructores
-Operadores
-Indexadores

Metodos: mismo nombre varian los parametros(tipos de datos, cantidad y/o orden), no se considera el tipo de retorno.
(ref(si requiere valor inicial y se puede cambiar en el metodo) y out(No es necesario que tenga un valor y esta pensado para que haya una salida) cuentan).
-Mas facil de mantener.
-Hacen casi lo mismo.
 
Constructores:
permite la inicializaciòn de distintas formas.

Operadores:
-Unarios + - ! ~ ++ -- true false 
-Binarios + - * / % & | ^ << >> == != < > >= <= (Se sobrecarga el contrapar)
-Unarios y binarios = && || ?? ?: => checked, unchecked, default, new, typeofas, is (NO SOBRECARGABLES).
 public static [T] operator [operator](T, T)

Operadores de coversiòn:
Pasar de un tipo a otro.
Implicit
Explicit, especificar con ()
[acceso] static implicit/explicit operator Tclase (T)



                05 CLASE DE WINDOWS FORMS

Interfaz grafica (GUI)
se desarrollo en los 60. 
Se desarrollo pensando en el usuario, mejoro la usabilidad de un sistema para el usuario promedio.
WINDOWS FORMS: 
-Libreria de clases que proveee una interfaz grafica de usuario por el mismo sistema de .NET
-Su proposito es proveer a los usuarios una facil interfaz para desarrollar aplicaciones de escritorio.
-Todos los formularios heredan de la clase Form del NS System.Windows.Forms(se puede crear clases propias).
-Las app tendran una coleccion de controles. (Abstracciones encapsulados en clases Forms y controles).
DISEÑADOR DE FORMULARIOS: provee muchas herramientas.
PARCIAL CLASS: Separacion logica de una clase, misma clase separada en mas de un archivo.
OBJETO FORM
-New (Se crea la instancia del formulario)
-Load (El formulario se encuentra en memoria pero invisible)
-Paint (Se dibuja el formulario y sus controles)
-Activated (El formulario recibe foco)
-FormClousing (Comienza el cierre Form, se puede cancelar)
-FormClosed (El formulario se cierra)
-Disposed (El objeto esta siendo destruido)
PROPIEDADES:
-Name: Nombre utilizado en el codigo para identificar al objeto.
-BackColor: Indica el color de fondo del componente.
-Cursor: Indica el cursor que aparece al pasar el puntero por el control.
-Enabled: Indica si el control esta habilitado.
-Font: Fuente utilizada para mostrar el texto en el control.
-ForeColor: Color utilizado para mostrar el texto.
-Locked: Determina si se puede mover o cambiar el tamaño del control.
-Modifiers: Indica el nivel de visibilidad del objeto.
-TabIndex: Determina el indice de tabulacion de ese control.
-Text: Texto asociado al control.
-Visible: Determina si el control esta siendo visible u oculto.
-BackGroundImage: Nos permite asignarle una imagen de fondo a nuestro control.
-StartPosition: Determina la posiciòn del formulario cuando aparece por primera vez.
-Icon: indica el icono del Formulario.
MessageBox: clase estatica, permite crear ventanas para interactuar, es sobrecargado.
Instanciarlo (new)
Show() hace visible el formulario
ShowDialog() actua como ventana modal.
thread.Sleep(seg) Dormir
hide() Esconde el formulario
Close() Cerrar 
CONTROLES: Objetos ya preparados para utilizar en la interfaz grafica.(Todos heredan de la clase control)
Evento LOAD Se dispara cuando el formulario se esta cargando (configurar los controles creados).


                06 CLASE DE COLECCIONES

 ARRAYS::  matrices, conectores : Permite almacenar multiples variables del mismo tipo.
Nombre en plural. 
-Dimensionalidad()Unidimensionales y multidimensionales
-Tamaño fijo, se especifica cuando se declara.
-Indexaciòn  base - cero. 
-Se inicializan con los valores por defecto.
Jaggers: array de array


COLLECIONES:
Son objetos que sirvan para almacenar, organizar y administrar datos.
-Tamaño dinàmico.
-Enumerables(foreach)
-Copiar su contenido en un array (copyto)
-Indexacion base - cero (no todas)
GENERICAS: (+ usadas)
-Elementos del mismo tipo (seguridad de tipos)
List<Tipo>      -    Dictionary<clave, valor>   -    queue<Tipo>  (Cola) p-p (no indexadas)-   Stack<Tipo> (pila) u-p (no indexadas)
indexada base-cero
NO GENERICAS:
-Elementos de distintos tipos.(objec)
CONCURRENTES:
-Son eficientes y seguras para acceder a los elementos desde distintos procesos de ejecucion (hilos)
INMUTABLES 
-No se pueden modificar.


                07 CLASE DE ENCAPSULAMIENTO

 ENCAPSULAMIENTO: Pilar de la POO
-(Caja negra) Agrupa los atributos del objeto junto con sus metodos.
- Ocultar detalles de la implementaciòn y proteger el estado del objeto (Se expone solo lo que necesitamos).
- al tener solo acceso a lo esencial ayuda al usuario de la clase a manejar la complejidad de la soluciòn.
- Que algo este encapsulado no significa que este oculto, pero que este oculto sì implica cierto nivel de encapsulamiento.
Abstraccion: Determino que imformacion es relevante y cual no, identificando sus datos y operaciones.
Encapsulamiento: agrupo esos datos y operaciones en una clase.(se aislan del exterior)
Ocultamiento de informacion: Estos datos permiten restringir el acceso a sus miembros a travès de modificadores de accso / visibilidad
Interface de una clase: metodos y propiedades publicos(Se pueden acceder)
MODIFICADORES: 
-public accesible desde cualquier parte.
-private solo accesible desde dentro del mismo tipo.
-internal Solo accesible desde dentro del mismo ensamblado / proyecto.
-protected solo accesible desde dentro del mismo tipo o tipos derivados(hijos)
Buenas practicas (steve McConnell)
-Minimizar la accesibilidad de clases y sus miembros.¿que preserva mejor la integridad de la abstraccion?
-No exponer el estado del objeto. Solo si lo amerita se expone con set -get 
-Ocultar los detalles de la implementaciòn.
-No asuman como serà utilizada la clase. el usuario lo va a utilizar como quiera y entienda. 
-Evitar usar clases internas.(Salvo casos puntuales,rompen el encapsulamiento.)
-Favoreces el tiempo de lectura del codigo sobre el de escritura. (codigo legible)
-Tener cuidado de no romper la semantica del encapsulamiento.
-Mantener un bajo nivel de acoplamiento. (La conexion y dependencia entre dos clases cuanto mas bajo sea mejor)

PROPIEDADES:
Permite leer, escribir o calcular el valor de un atributo. Otra forma de escribir mètodos de acceso(get-set).
Forma segura de obtener y modificar el estado de un objeto. Aportan el ocultamiento de los detalles de la implementacion.
Su nombre son sustantivos.(igual que los atributos.)

ENUMERADOS: ej Console.Color
-Tipo de dato
-Representa un conjunto de constantes numericas con nombre.
-Definen y limitan el conjunto de valores que se le puede asignar a una variable o parametro de entrada. 
-Numeros enteros y tienen base-cero (una forma segura es darle un valor definido a todos y no dejar el por defecto)
-En la declaracion es el ùnico lugar donde se puede cambiar los valores; 

//INDEXADORES. (No esta estrictamente ligado a colecciones o arrays)
Ordenar datos de acuerdo a un criterio a travez de un indice.
Nos permiten acceder a un dato a travez de un ìndice.
-Puede trabajar con mas de un indice. (matrices ej)
-Se puede indexar por cualquier tipo
-Se pueden sobrecargar 
-No se pueden declarar indexadores estaticos.(Se los invoca a travez de una referencia a una instancia.)

            
                08 CLASE DE HERENCIA 

Nos permite llevar la generalidad de una clase a una especializacion 
en base a clases ya existentes en lugar de crear nuevas clases desde cero. (relaciòn semantica "es un...").
Clases bases (principal) y derivadas. (Todo hereda de object)
Hereda todos los miembros menos los constructores. ( El constructor de la clase base creado si o si tiene que ser llamado por la clase derivada)
 TIPOS:
-Herencia Simple: Una clase derivada solo puede heredar de una clase base
-Herencia Multiple: una clase puede heredad de una o mas clases bases.
Sustitucion de Liskov
-Cada clase que hereda de otra, puede usarse como su padre sin necesidad de conocer las diferencias entre ellas.
 S : T ->  T objeto = new S();  -> Animal animal = new Perro(); (En memoria es un perro).
Herencia en C#
-Las clases derivadas heredan todos los miembros de la clase base menos los constructores.
-La accesibilidad de una clase derivada no puede ser mas accesible que su clase base.
-Los miembros publicos de una clase base implicitamente se convierten en miembros publicos de la clase derivada
-Aunque se hereden miembros privados de la clase base, el ùnico que puede acceder a ellos es la clase base.
-Transitividad: Clases C hereda de B - B hereda de A - C tambien hereda de A
MODIFICADOR PROTECTED: Modificador de visibilidad que solo pueden acceder a las clases heredadas.
CLASES SEALED (SELLADAS): Evita que la clase pueda tener derivadas. 


 
               09 CLASE DE POLIMORFISMO Y CLASES ABSTRACTAS

POLIMORFISMO(muchas formas)
-Habilidad de los objetos de responder al mismo mensaje(invocaciòn de un mètodo) de distintas formas.
-Los tipos derivados pueden redefinir la implementaciòn de una operacion en el tipo base.(como se responde a un determinado mensaje)
-Un objeto debe ser responsable de si mismo.(debe responder a todas las preguntas importantes sobre si mismo).
-Todas las clases derivadas heredan la interfaz(operaciones y propiedades publicas) de su clase base.
-Cada clase derivada es una clase semi-independiente, cada una podrìa requerir resolver la respuesta al mismo mensaje de distintas formas.
POLIMORFISMO BASADO EN HERENCIA:
Se resuelve en forma dinamica en tiempo de ejecuciòn.
Depende de la instancia en meoria del tipo real del objeto en memoria, cual implementacion de la misma operacion se va a invocar.
HERENCIA NO-POLIMORFICA EN C#
-Permite redefinir un metodo de la clase base pero sin que se aplique polimorfismo.
-NEW -> palabra reservada para invalidar / redefinir / sobreescribir un metodo de la clase base de forma no-polimorfica.
[modificador de acceso] new [return] identificado() 
-El runtime ejecutarà la implementaciòn correspondiente al tipo de referencia sin importar el tipo de objeto en memoria. T:S / S t = new T() -> va a implementar S
HERENCIA POLIMÒRFICA EN C#
-Permite redefinir un metodo de la clase base aplicando polimorfismo.
-El runtime ejecutarà la implementacion correspondiente al tipo real del objeto en memoria T:S / S t = new T() -> se va a implementar T
-VIRTUAL -> palabra reservada para declarar un mètodo que puda ser invalidado / redefinido / sobrescrito por una clase derivada.
-OVERRIDE -> palabra reservada para declarar un mètodo para invalidar / redefinir / sobrescribir un mètodo virtual de la clase base.
-Por polimorfismo la implementacion del mètodo que se va a ejecutar es la mas cercana a la jerarquia de herencia.(toma el padre mas inmediato).
METODOS DE EQUIVALENCIA:
GetType() devuelve el tipo de instancia en memoria.(objeto) -
Sobrescribir:
Equals : dos objetos son iguales si apuntan a la misma direcciòn de memoria.(Puede cambiar el criterio)
GetHashCode : decuelve un codigo hsash. valor numerico que se utiliza para identificar y comparar objetos ()
-Ambos evaluan la igualdad de dos objetos.
Object.ReferenceEquals(obj,obj) compara direcciones de memoria
CLASE ABSTRACTA:
-Clases que no se pueden instanciar (referenciar si - instanciar no) Por polimorfismo va a la instancia.
-Derivadas si no son abstractas si se pueden instanciar.
-Modela la base de una jerarquia de herencia. (RAÌZ). Pensadas para ser heredadas. 
-Declaran una serie de metodos y atributos que definen una jerarquia de herencia, pero no hacen a un tipo de objeto por si mismo.
-Clases incompletas que por si solas no tienen lo sufieciente y por lo tanto no se deberian instanciar
MIEMBROS ABSTRACTOS: 
-Definen una operaciòn pero no su implementaciòn. (sin cuerpo) Se pueden sobrecargar
-Las clases derivadas no abstractas seran las que DEBEN aportar una implementaciòn al mètodo.(si o si).
-Las clases abstractas son las ùnicas que pueden contener miembros abstractos.
-Los miembros abstractos son implicitamente virtuales, el polimorfismo aplica de igual forma.


 */