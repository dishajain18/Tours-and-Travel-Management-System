INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Amit Patel', 9876543210, 28, 'M', 380001, 'MG Road', 123, 'Ahmedabad', 'India', TO_DATE('10-09-1996', 'DD-MM-YYYY'), 101);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Priya Sharma', 8765432109, 35, 'F', 110001, 'Main Street', 456, 'Delhi', 'India', TO_DATE('20-05-1989', 'DD-MM-YYYY'), 102);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Rahul Kumar', 7890123456, 40, 'M', 560001, 'Brigade Road', 789, 'Bangalore', 'India', TO_DATE('15-12-1984', 'DD-MM-YYYY'), 103);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Neha Singh', 6543210987, 30, 'F', 400001, 'Park Street', NULL, 'Mumbai', 'India', TO_DATE('25-07-1992', 'DD-MM-YYYY'), 104);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Rajesh Kumar', 9876543211, 32, 'M', 380002, 'Park Avenue', 456, 'Ahmedabad', 'India', TO_DATE('15-03-1992', 'DD-MM-YYYY'), 105);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Anita Sharma', 8765432110, 28, 'F', 110002, 'Lake Road', 789, 'Delhi', 'India', TO_DATE('20-08-1996', 'DD-MM-YYYY'), 106);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Sanjay Patel', 7890123457, 35, 'M', 560002, 'MG Lane', NULL, 'Bangalore', 'India', TO_DATE('10-05-1989', 'DD-MM-YYYY'), 107);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Meera Gupta', 6543210988, 27, 'F', 400002, 'Gandhi Nagar', 102, 'Mumbai', 'India', TO_DATE('25-12-1997', 'DD-MM-YYYY'), 108);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Vikram Singh', 7890654321, 40, 'M', 560003, 'Brigade Street', 205, 'Bangalore', 'India', TO_DATE('03-09-1984', 'DD-MM-YYYY'), 109);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Sneha Verma', 6789012345, 31, 'F', 400003, 'Marine Drive', 305, 'Mumbai', 'India', TO_DATE('18-07-1993', 'DD-MM-YYYY'), 110);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Arjun Malhotra', 9876543213, 36, 'M', 380003, 'Gandhi Road', 408, 'Ahmedabad', 'India', TO_DATE('12-11-1988', 'DD-MM-YYYY'), 111);

INSERT INTO Person (Name, Phone, Age, Sex, Pincode, Street, House_no, City, Country, Birthdate, Person_id) 
VALUES ('Pooja Khanna', 8765432112, 29, 'F', 110003, 'Main Avenue', 502, 'Delhi', 'India', TO_DATE('29-04-1995', 'DD-MM-YYYY'), 112);


INSERT INTO Customer (Person_id) VALUES (101);

INSERT INTO Customer (Person_id) VALUES (102);

INSERT INTO Customer (Person_id) VALUES (103);

INSERT INTO Customer (Person_id) VALUES (104);

INSERT INTO Tour_guide (salary, person_id) VALUES (55000, 105);

INSERT INTO Tour_guide (salary, person_id) VALUES (60000, 106);

INSERT INTO Tour_guide (salary, person_id) VALUES (58000, 107);

INSERT INTO Tour_guide (salary, person_id) VALUES (62000, 108);

INSERT INTO Travel_agency (Name, company_id, phone_number, email_address, pincode, door_no, street, city, country) 
VALUES ('Indian Voyages', 2001, '9876543210', 'info@indianvoyages.com', 110001, 20, 'MG Road', 'Delhi', 'India');

INSERT INTO Travel_agency (Name, company_id, phone_number, email_address, pincode, door_no, street, city, country) 
VALUES ('Rajasthan Tours', 2002, '8765432109', 'info@rajasthantours.in', 302001, 15, 'Jaipur Road', 'Jaipur', 'India');

INSERT INTO Travel_agency (Name, company_id, phone_number, email_address, pincode, door_no, street, city, country) 
VALUES ('Goa Travels', 2003, '7890123456', 'info@goatravels.com', 403001, 25, 'Calangute Beach Road', 'Goa', 'India');

INSERT INTO Travel_agency (Name, company_id, phone_number, email_address, pincode, door_no, street, city, country) 
VALUES ('Kerala Holidays', 2004, '6543210987', 'info@keralaholidays.com', 682001, 30, 'Backwater Street', 'Kochi', 'India');

-- Tour_package Table
INSERT INTO Tour_package (Package_id, tour_name, no_of_days, max_no_of_people, cost_for_one_person, start_date, end_date, no_of_places, company_id) 
VALUES (301, 'Golden Triangle Tour', 5, 15, 20000, TO_DATE('01-05-2024', 'DD-MM-YYYY'), TO_DATE('05-05-2024', 'DD-MM-YYYY'), 3, 2001);

INSERT INTO Tour_package (Package_id, tour_name, no_of_days, max_no_of_people, cost_for_one_person, start_date, end_date, no_of_places, company_id) 
VALUES (302, 'Goa Beach Retreat', 3, 10, 15000, TO_DATE('10-06-2024', 'DD-MM-YYYY'), TO_DATE('12-06-2024', 'DD-MM-YYYY'), 2, 2003);

INSERT INTO Tour_package (Package_id, tour_name, no_of_days, max_no_of_people, cost_for_one_person, start_date, end_date, no_of_places, company_id) 
VALUES (303, 'Kerala Backwaters Experience', 7, 20, 25000, TO_DATE('15-07-2024', 'DD-MM-YYYY'), TO_DATE('21-07-2024', 'DD-MM-YYYY'), 5, 2004);

INSERT INTO Tour_package (Package_id, tour_name, no_of_days, max_no_of_people, cost_for_one_person, start_date, end_date, no_of_places, company_id) 
VALUES (304, 'Rajasthan Desert Safari', 6, 12, 18000, TO_DATE('05-08-2024', 'DD-MM-YYYY'), TO_DATE('10-08-2024', 'DD-MM-YYYY'), 4, 2002);

-- Book_tour Table
INSERT INTO Book_tour (type_of_transaction, Transaction_id, package_id, person_id, date_of_booking, duedate_of_payment, outstanding_balance, advance_amount) 
VALUES ('Online', 501, 301, 101, TO_DATE('05-04-2024', 'DD-MM-YYYY'), TO_DATE('10-04-2024', 'DD-MM-YYYY'), 15000, 5000);

INSERT INTO Book_tour (type_of_transaction, Transaction_id, package_id, person_id, date_of_booking, duedate_of_payment, outstanding_balance, advance_amount) 
VALUES ('Offline', 502, 302, 102, TO_DATE('08-04-2024', 'DD-MM-YYYY'), TO_DATE('12-04-2024', 'DD-MM-YYYY'), 10000, 5000);

INSERT INTO Book_tour (type_of_transaction, Transaction_id, package_id, person_id, date_of_booking, duedate_of_payment, outstanding_balance, advance_amount) 
VALUES ('Online', 503, 303, 103, TO_DATE('10-04-2024', 'DD-MM-YYYY'), TO_DATE('15-04-2024', 'DD-MM-YYYY'), 20000, 5000);

INSERT INTO Book_tour (type_of_transaction, Transaction_id, package_id, person_id, date_of_booking, duedate_of_payment, outstanding_balance, advance_amount) 
VALUES ('Offline', 504, 304, 104, TO_DATE('12-04-2024', 'DD-MM-YYYY'), TO_DATE('18-04-2024', 'DD-MM-YYYY'), 12000, 6000);

-- cancel_tour Table
INSERT INTO cancel_tour (cancellation_id, refund_amount, date_of_cancellation, Transaction_id) 
VALUES (601, 10000, TO_DATE('09-04-2024', 'DD-MM-YYYY'), 501);

INSERT INTO cancel_tour (cancellation_id, refund_amount, date_of_cancellation, Transaction_id) 
VALUES (602, 7000, TO_DATE('11-04-2024', 'DD-MM-YYYY'), 502);

INSERT INTO cancel_tour (cancellation_id, refund_amount, date_of_cancellation, Transaction_id) 
VALUES (603, 15000, TO_DATE('12-04-2024', 'DD-MM-YYYY'), 503);

INSERT INTO cancel_tour (cancellation_id, refund_amount, date_of_cancellation, Transaction_id) 
VALUES (604, 9000, TO_DATE('14-04-2024', 'DD-MM-YYYY'), 504);

INSERT INTO cities (City_id, City_name, Pincode, state, country, website_address) 
VALUES (501, 'Ahmedabad', 380001, 'Gujarat', 'India', 'www.ahmedabad.gov.in');

INSERT INTO cities (City_id, City_name, Pincode, state, country, website_address) 
VALUES (502, 'Delhi', 110001, 'Delhi', 'India', 'www.delhi.gov.in');

INSERT INTO cities (City_id, City_name, Pincode, state, country, website_address) 
VALUES (503, 'Bangalore', 560001, 'Karnataka', 'India', 'www.bengaluru.gov.in');

INSERT INTO cities (City_id, City_name, Pincode, state, country, website_address) 
VALUES (504, 'Mumbai', 400001, 'Maharashtra', 'India', 'www.mumbai.gov.in');

INSERT INTO Flight (capacity, flight_no, type_of_flight, source, destination) 
VALUES (200, 'AI101', 'Domestic', 'DEL', 'BOM');

INSERT INTO Flight (capacity, flight_no, type_of_flight, source, destination) 
VALUES (180, 'SG202', 'Domestic', 'BLR', 'DEL');

INSERT INTO Flight (capacity, flight_no, type_of_flight, source, destination) 
VALUES (220, 'AI303', 'Domestic', 'BOM', 'HYD');

INSERT INTO Flight (capacity, flight_no, type_of_flight, source, destination) 
VALUES (250, 'SG404', 'Domestic', 'DEL', 'BLR');

INSERT INTO staff (salary, person_id, bonus_per_year, company_id) 
VALUES (45000, 109, 5000, 2001);

INSERT INTO staff (salary, person_id, bonus_per_year, company_id) 
VALUES (48000, 110, 5500, 2002);

INSERT INTO staff (salary, person_id, bonus_per_year, company_id) 
VALUES (50000, 111, 6000, 2003);

INSERT INTO staff (salary, person_id, bonus_per_year, company_id) 
VALUES (52000, 112, 6500, 2004);

INSERT INTO feedback (feedback_description, person_id, package_id) 
VALUES ('Excellent service, loved the tour!', 101, 301);

INSERT INTO feedback (feedback_description, person_id, package_id) 
VALUES ('Great experience, would recommend to others.', 102, 302);

INSERT INTO feedback (feedback_description, person_id, package_id) 
VALUES ('Had an amazing time, thank you!', 103, 303);

INSERT INTO feedback (feedback_description, person_id, package_id) 
VALUES ('Good tour, enjoyed every moment.', 104, 304);

INSERT INTO hotel (Hotel_id, phone_no, hotel_name, city_id) 
VALUES (701, 1234567890, 'Grand Hyatt', 502);

INSERT INTO hotel (Hotel_id, phone_no, hotel_name, city_id) 
VALUES (702, 2345678901, 'Taj Palace', 501);

INSERT INTO hotel (Hotel_id, phone_no, hotel_name, city_id) 
VALUES (703, 3456789012, 'Leela Palace', 503);

INSERT INTO hotel (Hotel_id, phone_no, hotel_name, city_id) 
VALUES (704, 4567890123, 'Marriott', 504);

INSERT INTO hotel_booking_details (Booking_no_no, hotel_booking_date, Person_id, Hotel_id) 
VALUES (801, TO_DATE('06-03-2024', 'DD-MM-YYYY'), 101, 701);

INSERT INTO hotel_booking_details (Booking_no_no, hotel_booking_date, Person_id, Hotel_id) 
VALUES (802, TO_DATE('09-03-2024', 'DD-MM-YYYY'), 102, 702);

INSERT INTO hotel_booking_details (Booking_no_no, hotel_booking_date, Person_id, Hotel_id) 
VALUES (803, TO_DATE('12-02-2024', 'DD-MM-YYYY'), 103, 703);

INSERT INTO hotel_booking_details (Booking_no_no, hotel_booking_date, Person_id, Hotel_id) 
VALUES (804, TO_DATE('14-03-2024', 'DD-MM-YYYY'), 104, 704);
INSERT INTO package_cities (city_id, package_id) 
VALUES (501, 301);

INSERT INTO package_cities (city_id, package_id) 
VALUES (502, 302);

INSERT INTO package_cities (city_id, package_id) 
VALUES (503, 303);

INSERT INTO package_cities (city_id, package_id) 
VALUES (504, 304);

INSERT INTO flight_booking_details (Booking_id, Seat_no, Cost_of_journey, Date_of_travel, Flight_no, Person_id) 
VALUES (901, 15, 8000, TO_DATE('20-04-2024', 'DD-MM-YYYY'), 'AI101', 101);

INSERT INTO flight_booking_details (Booking_id, Seat_no, Cost_of_journey, Date_of_travel, Flight_no, Person_id) 
VALUES (902, 25, 10000, TO_DATE('22-04-2024', 'DD-MM-YYYY'), 'SG202', 102);

INSERT INTO flight_booking_details (Booking_id, Seat_no, Cost_of_journey, Date_of_travel, Flight_no, Person_id) 
VALUES (903, 30, 12000, TO_DATE('25-04-2024', 'DD-MM-YYYY'), 'AI303', 103);

INSERT INTO flight_booking_details (Booking_id, Seat_no, Cost_of_journey, Date_of_travel, Flight_no, Person_id) 
VALUES (904, 20, 9000, TO_DATE('28-04-2024', 'DD-MM-YYYY'), 'SG404', 104);
INSERT INTO guide_travel_agency (Person_id, company_id) 
VALUES (105, 2001);

INSERT INTO guide_travel_agency (Person_id, company_id) 
VALUES (106, 2002);

INSERT INTO guide_travel_agency (Person_id, company_id) 
VALUES (107, 2003);

INSERT INTO guide_travel_agency (Person_id, company_id) 
VALUES (108, 2004);











