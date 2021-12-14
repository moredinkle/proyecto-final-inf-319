println("criba de eratostenes")
print("n:")
val n = scala.io.StdIn.readInt()
var marcados = new Array[Boolean](n+1)
for(i <- 2 to Math.round(scala.math.sqrt(n).floatValue)){
    if(!marcados(i)){
        var j = i*2
        while(j <= n){
            marcados(j) = true
            j+=i
        }
    }
}

for(i <- 2 until n){
    if(!marcados(i)){
        print(i + " ")
    }
}