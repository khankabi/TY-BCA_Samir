#write a python script to display alternate charcters of string from both the direction.
org_str = input ("Enter a string: ")
l_to_r = org_str[::2]
r_to_l = org_str[::-2]
print(f"Alternate character from left to right = {l_to_r}")
print(f"Alternate character from left to right = {r_to_l}")
