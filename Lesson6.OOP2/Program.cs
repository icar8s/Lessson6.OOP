using System.Threading.Channels;
using Lesson6.OOP2;
Patient _patient = new Patient("Илья","Пусков",21);
var plan = new Treatment_method(2);
_patient.AppendDoctor(plan);