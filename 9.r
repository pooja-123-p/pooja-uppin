data<-mtcars
print("original data frame:")
head(data)
print("Accessing 'mpg' columns:")
data$mpg
print("Accessing 1st 5 rows & columns 1 to 3")
data[1:5,1:3]
print("element at row 3,columns 2:")
data[3,2]
print("cars with mileage greater than 20 mpg:")
subset_data<-subset(data,mpg>20)
subset_data
data$drat<-NULL
print("modified data frame:")
head(data)
print("summary of the data:")
summary(data)
sorted_data<-data[order(-data$mpg),]
print("cars sorted by highest mileage:")
head(sorted_data)
high_hp<-subset(data,hp>150)
print("cars with HorsePower greater than 150:")
high_hp
