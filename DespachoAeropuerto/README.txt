SIMULACION DE DESPACHO DE AVIONES CON COLA DE PRIORIDAD
=======================================================
Requisitos : Visual Studio 2022 (carga de trabajo "Desarrollo de escritorio con .NET")
             y SDK de .NET 8.
Abrir      : doble clic en DespachoAeropuerto.sln  ->  F5.

Estructuras propias (sin usar Queue<T> ni SortedList):
  Estructuras/Nodo.cs          nodo de lista enlazada
  Estructuras/ColaSimple.cs    cola FIFO con lista enlazada
  Estructuras/ColaPrioridad.cs arreglo de colas FIFO, una por nivel de prioridad
