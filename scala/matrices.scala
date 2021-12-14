import Array._

def suma(a:Array[Array[Int]],b:Array[Array[Int]]) {
    var res = ofDim[Int](2,2)
    println("resultado:")
    for (i <- 0 to 1) {
        for ( j <- 0 to 1) {
            res(i)(j) = a(i)(j) + b(i)(j)
            print(" " + res(i)(j))
        }
        println()
    }
}

def resta(a:Array[Array[Int]],b:Array[Array[Int]]) {
    var res = ofDim[Int](2,2)
    println("resultado:")
    for (i <- 0 to 1) {
        for ( j <- 0 to 1) {
            res(i)(j) = a(i)(j) - b(i)(j)
            print(" " + res(i)(j))
        }
        println()
    }
}


def multi(a:Array[Array[Int]],b:Array[Array[Int]]) {
    var res = ofDim[Int](2,2)
    println("resultado:")
    for (i <- 0 to 1) {
        for ( j <- 0 to 1) {
            res(i)(j) = 0
            for(k <- 0 to 1) {
                res(i)(j) += a(i)(k) * b(k)(j)
            }
            print(" " + res(i)(j))
        }
        println()
    }
}

def xay(x:Array[Array[Int]], y:Array[Array[Int]], funcion:(Array[Array[Int]], Array[Array[Int]]) => Unit):Unit = funcion(x,y)

def calcu(x:Array[Array[Int]], y:Array[Array[Int]], operacion:String){
    operacion match {
        case "suma"=>xay(x,y,suma)
        case "resta"=>xay(x,y,resta)
        case "multi"=>xay(x,y,multi)
    }
}


var mat1 = ofDim[Int](2,2)
var mat2 = ofDim[Int](2,2)

println("---------- Calculadora de matrices ----------")
println("matriz 1:")
for (i <- 0 to 1) {
    for ( j <- 0 to 1) {
        print("["+i+","+j+"]:")
        mat1(i)(j) = scala.io.StdIn.readInt()
    }
}

println("matriz 2:")
for (i <- 0 to 1) {
    for ( j <- 0 to 1) {
        print("["+i+","+j+"]:")
        mat2(i)(j) = scala.io.StdIn.readInt()
    }
}

print("Operacion (suma, resta o multi):")
val op = scala.io.StdIn.readLine()
if(op == "suma" || op == "resta" || op == "multi") {
    calcu(mat1,mat2,op)
}
else println("Operación no reconocida")
