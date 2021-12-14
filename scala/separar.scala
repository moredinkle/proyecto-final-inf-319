print("n:")
val n = scala.io.StdIn.readInt()
var lista = new Array[Int](n)
for(i <- 0 until n){
    print("["+i+"]:")
    lista(i) = scala.io.StdIn.readInt()
}

var pares = for (i <- lista if (i % 2 == 0)) yield i
var impares = for (i <- lista if (i % 2 != 0)) yield i

println("Pares:")
println(pares.mkString(" "))
println("Impares:")
println(impares.mkString(" "))