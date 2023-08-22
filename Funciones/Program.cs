// See https://aka.ms/new-console-template for more information
int a = 1;
int b = 2;

int c = a + b;
int d = b + a;

static void Sum(int num1, int num2){ //Esta funcion sirve para llamar datos no regresa nada pero si recibe los parametros dentro del parentesis
    int num3 = num1 + num2;
    Console.WriteLine(); // CW Y doble vez tabular 
};

Sum(1, 4);//asi invoco la funcion

static void Show() // Esta funcion se encarga de no recibir ni regresar nada
 {
    Console.WriteLine("Hola soy un texto que se imprime desde funcion");
};

Show();//asi invoco la funcion

static int Mul(int num1, int num2)//Esta funcion se encarga de recibir y llamar paramtros
{ 
    return num1 * num2;
};
int m = Mul(4,5);//asi invoco la funcion
Console.WriteLine(m);