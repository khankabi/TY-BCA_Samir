#write a python program to sort (ascending and descending) a dictionary by value.
dictx={5:50,6:60,7:70,8:80,9:90}
print(dictx)
asc_sort_dict=sorted(dictx.values())
print("Ascending dictionary : ",asc_sort_dict)
des_sort_dict=sorted(dictx.values(),reverse=True)
print("descending dictionary : ",des_sort_dict)

print("second method")
#another method
import operator
d = {1: 2, 3: 4, 4: 3, 2: 1, 0: 0}
print('Original dictionary : ',d)
sorted_d = sorted(d.items(), key=operator.itemgetter(1))
print('Dictionary in ascending order by value : ',sorted_d)
sorted_d = dict( sorted(d.items(), key=operator.itemgetter(1),reverse=True))
print('Dictionary in descending order by value : ',sorted_d)






