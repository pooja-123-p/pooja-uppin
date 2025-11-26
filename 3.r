a = 10
b = 5

cat("Arithmetic operation\n")
cat("sum:", a+b, "\n")
cat("diff:", a-b, "\n")
cat("Product:", a*b, "\n")
cat("division:", a/b, "\n")
cat("Modulus:", a %% b, "\n")
cat("conditional stmts\n")
if(a == b){
  cat("a & b are equal\n")
} else if (a>b){
  cat("a is greaterthan b\n")
} else{
  cat("a is smaller than b\n")
}

cat("switch statement\n")
choice = "Product"
result = switch(choice,
                "sum" = paste("sum is", a+b),
                "diff" = paste("diff is", a-b),
                "Product"= paste("Product is", a*b),
                "Modulus"= paste("Modulus is", a%%b),
                "unknown choice")
cat(result, "\n\n")

cat("for loop\n")
total = 0
for (i in 1:a){
  total = total + i
}
cat("sum of first ", a, "numeric", "total", "\n")
cat(C"while loop")
fact = 1
n = b
while(n>b){
  fact = fact*n
  n = n-1
}
cat("Factorial of", b, "is", fact, "\n")
cat(C"Repeat loop:")
x = 1
repeat{
  cat("value of x:", x, "\n")
  x = x+1
  if(x>5){
    break
  }
}
cat("\n")
cat("function ()")
greet = function(name = "sruthi"){
  cat("Hello", name, "!welcome to R-Program")
}
greet()
greet("/n pruthvi()")
