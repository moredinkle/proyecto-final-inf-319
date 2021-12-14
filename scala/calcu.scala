println("---------- Calculadora ----------")
def suma(a:Int,b:Int):Int=a+b
def resta(a:Int,b:Int):Int=a-b
def mult(a:Int,b:Int):Int=a*b
def div(a:Int,b:Int):Int=a/b
def mod(a:Int,b:Int):Int=a%b

def xay(x:Int, y:Int, funcion:(Int, Int) => Int):Int = funcion(x,y)

def calcu(x:Int, y:Int, operacion:String):Int={
    operacion match {
        case "suma"=>xay(x,y,suma)
        case "resta"=>xay(x,y,resta)
        case "mult"=>xay(x,y,mult)
        case "div"=>xay(x,y,div)
    }
}

var bool : Boolean = true;
while(bool == true){
    print("a:")
    val a = scala.io.StdIn.readInt()
    print("b:")
    val b = scala.io.StdIn.readInt()
    print("Operacion (suma, resta, mult o div):")
    val op = scala.io.StdIn.readLine()
    var res = 0
    if(op == "suma" || op == "resta" || op == "mult" || op == "div" ) {
        res = calcu(a,b,op)
        if(op == "div"){
            var m = xay(a,b,mod) / b.toFloat
            var r = res.toFloat + m
            println(r)
        }
        else println(res)
    }
    else println("Operación no reconocida")
    println("Continuar? s/n")
    var co = scala.io.StdIn.readLine()
    if(co != "s") bool = false
}