# Write a Python script to display datetime in various formats using datetime module a. Current date and time b. Current year c. Month of year d. Week number of the year e. Weekday of the week f. Day of year g. Day of the month h. Day of week
from datetime import datetime

# Current date and time
current_datetime = datetime.now()
print(f"a. Current date and time: {current_datetime}")

# Current year
current_year = current_datetime.year
print(f"b. Current year: {current_year}")

# Month of year
month_of_year = current_datetime.strftime("%B")
print(f"c. Month of year: {month_of_year}")

# Week number of the year
week_number = current_datetime.strftime("%U")
print(f"d. Week number of the year: {week_number}")

# Weekday of the week
weekday = current_datetime.strftime("%A")
print(f"e. Weekday of the week: {weekday}")

# Day of year
day_of_year = current_datetime.strftime("%j")
print(f"f. Day of year: {day_of_year}")

# Day of the month
day_of_month = current_datetime.strftime("%d")
print(f"g. Day of the month: {day_of_month}")

# Day of week
day_of_week = current_datetime.strftime("%w")
print(f"h. Day of week: {day_of_week}")
