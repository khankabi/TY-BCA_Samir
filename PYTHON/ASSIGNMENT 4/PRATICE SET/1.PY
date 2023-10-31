# Write a Python program to print Calendar of specific month of input year using calendar module
import calendar

def print_calendar():
    year = int(input("Enter the year: "))
    month = int(input("Enter the month (1-12): "))

    # Validate input
    if 1 <= month <= 12:
        # Print the calendar
        cal = calendar.month(year, month)
        print(f"\nCalendar for {calendar.month_name[month]} {year}:\n")
        print(cal)
    else:
        print("Invalid month input. Please enter a number between 1 and 12.")

# Call the function to execute the program
print_calendar()
