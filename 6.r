install.packages("markovchain")
library(markovchain)
transition_matrix=matrix(c(0.8,0.2,0.3,0.7),byrow = TRUE,nrow = 2,
                         dimnames = list(c("state A","state B"),c("state A","state B")))
my_chain=new("markovchain",states=c("state A","state B"),transitionMatrix=transition_matrix)
stationary_distribution=steadyStates(my_chain)
cat("stationary distribution:\n")
print(stationary_distribution)
