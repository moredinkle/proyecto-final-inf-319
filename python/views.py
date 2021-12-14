from django.shortcuts import render
from django.http import HttpResponse
from .forms import *
from array import *

#funciones
#fibo
def func_fibo(n):
    a = 0
    b = 1
    res = "0"
    for i in range(n):
        res += ", "
        aux = a
        a = b
        b = aux+a
        res += str(a)
    return res

#calculadora
def suma(x,y): return x + y
def resta(x,y): return x - y
def mult(x,y): return x * y
def div(x,y): return x / y

def func_calcu(a,b,func):
    res = func(a,b)
    return str(res)

def inter(a,b,op):
    if (op == 'suma'):
        return func_calcu(a,b,suma)
    elif (op == 'resta'):
        return func_calcu(a,b,resta)
    elif (op == 'mult'):
        return func_calcu(a,b,mult)
    elif (op == 'div'):
        return func_calcu(a,b,div)
    else:
        return "Operacion no reconocida"

#matrices
def sumat(m1, m2):
    res = [[0,0],[0,0]]
    cad = ""
    for i in range(2):
        for j in range(2):
            res[i][j] = m1[i][j] + m2[i][j]
            cad += str(res[i][j]) + " "
        cad+="<br>"
    return cad

def resmatri(m1, m2):
    res = [[0,0],[0,0]]
    cad = ""
    for i in range(2):
        for j in range(2):
            res[i][j] = m1[i][j] - m2[i][j]
            cad += str(res[i][j]) + " "
        cad+="<br>"
    return cad

def mulmat(m1, m2):
    res = [[0,0],[0,0]]
    cad = ""
    for i in range(2):
        for j in range(2):
            for k in range(2):
                res[i][j] += m1[i][k] * m2[k][j]
            cad += str(res[i][j]) + " "
        cad+="<br>"
    return cad


def interm(a,b,op):
    if (op == 'suma'):
        return func_mat(a,b,sumat)
    elif (op == 'resta'):
        return func_mat(a,b,resmatri)
    elif (op == 'multi'):
        return func_mat(a,b,mulmat)
    else:
        return "Operacion no reconocida"

def func_mat(a,b,func):
    return func(a,b)

#criba
def func_criba(n):
    import math
    cad=""
    arr=[]
    arr = [0 for i in range(n+1)]
    for i in range(2,math.trunc(math.sqrt(n+1))):
        if(arr[i] == 0):
            j=2
            while(i*j < n):
                arr[i*j] = 1
                j+=1

    for i in range(2,n):
        if(arr[i]==0):
            cad+= str(i) + ", "
    return cad

#separar
def func_separar(s):
    arr = [int(x) for x in s.split()]
    pares = ""
    impares = ""
    for x in arr:
        if(x % 2 == 0):
            pares += str(x) +", "
        else:
            impares += str(x) +", "
    return "Pares: <br>" + pares + "<br><br>Impares:<br>" + impares



#vistas

def index(request):
    return render(request, "form_index.html")

def fibov(request):
    form = fibo()
    return render(request, "form_fibo.html", {"form":form})

def cribav(request):
    form = criba()
    return render(request, "form_criba.html", {"form":form})

def separarv(request):
    form = separar()
    return render(request, "form_separar.html", {"form":form})

def calculadorav(request):
    form = calculadora()
    return render(request, "form_calcu.html", {"form":form})

def calc_matv(request):
    form = calc_mat()
    return render(request, "form_matrices.html", {"form":form})


def resfibo(request):
    resp = "<h2>Resultados</h2>"
    x = request.GET['n_fibo']
    resp += func_fibo(int(x))
    return HttpResponse(resp)


def rescalcu(request):
    resp = "<h2>Resultados</h2>"
    a = int(request.GET['a'])
    b = int(request.GET['b'])
    op = request.GET['op_c']
    resp += inter(a,b,op)
    return HttpResponse(resp)

def resmat(request):
    resp = "<h2>Resultados</h2>"
    mat1 = [[0,0],[0,0]]
    mat2 = [[0,0],[0,0]]
    mat1[0][0] = int(request.GET['mat100'])
    mat1[0][1] = int(request.GET['mat101'])
    mat1[1][0] = int(request.GET['mat110'])
    mat1[1][1] = int(request.GET['mat111'])
    mat2[0][0] = int(request.GET['mat200'])
    mat2[0][1] = int(request.GET['mat201'])
    mat2[1][0] = int(request.GET['mat210'])
    mat2[1][1] = int(request.GET['mat211'])
    op = request.GET['op_m']
    resp += interm(mat1, mat2, op)
    return HttpResponse(resp)


def rescriba(request):
    resp = "<h2>Resultados</h2>"
    x = request.GET['n_criba']
    resp += func_criba(int(x))
    return HttpResponse(resp)

def ressep(request):
    resp = "<h2>Resultados</h2>"
    x = request.GET['lista']
    resp += func_separar(x)
    return HttpResponse(resp)

#falta separar

