quicksort<-function(arr){
  if( length(arr)<=1){
    return(arr)
  }
  pivot<-arr[-1]
  lesser<-arr[arr<pivot]
  equal<-arr[arr==pivot]
  greater<-arr[arr>pivot]
  sorted_lesser<-quicksort(lesser)
  sorted_greater<-quicksort(greater)
  return(c(sorted_lesser,equal,sorted_greater))
}
arr<-c(4,2,7,1,9,3)
sorted_arr<-quicksort(arr)
cat("original array",arr,"\n")
cat("sorted array",sorted_arr,"\n")
