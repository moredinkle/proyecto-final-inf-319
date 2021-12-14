print("n:")
val n = scala.io.StdIn.readInt()
var a = 0
var b = 1
var aux = 0
print("0, ")
for(i <- 2 to n){
    aux = a
    a = b
    b = aux + a
    print(a+", ")
}

