// See https://aka.ms/new-console-template for more information
using Observer;

var subject = new TVNews();
var suscriber1 = new Subscriber("Branco");
var suscriber2 = new Subscriber("John Doe");
var suscriber3 = new Subscriber("Juan Perez");

subject.Attach(suscriber1);
subject.Attach(suscriber2);
subject.Attach(suscriber3);

subject.Notify();

subject.Detach(suscriber2);

subject.Notify();

Console.ReadKey();
