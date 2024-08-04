1) This procedure returns hotel bookings in past 1 month.

CREATE OR REPLACE PROCEDURE SIX_MONTH_HOTEL /*HOTEL BOOKED IN PAST 6 MONTHS*/
IS
CURSOR HOTEL_DETAILS IS 
  SELECT P.NAME, H.HOTEL_NAME
  FROM HOTEL H, HOTEL_BOOKING_DETAILS H2, PERSON P
  WHERE (SYSDATE - H2.HOTEL_BOOKING_DATE) <= 30 AND H2.HOTEL_ID = H.HOTEL_ID AND P.PERSON_ID = H2.PERSON_ID;

THISNAME PERSON.NAME%TYPE;
THISHOTELNAME HOTEL.HOTEL_NAME%TYPE;

BEGIN
  OPEN HOTEL_DETAILS;

  LOOP
    FETCH HOTEL_DETAILS INTO THISNAME, THISHOTELNAME;
    EXIT WHEN HOTEL_DETAILS%NOTFOUND;
    DBMS_OUTPUT.PUT_LINE('Name of customer is: ' || THISNAME || ' and Name of hotel is: ' || THISHOTELNAME);
  END LOOP;

  CLOSE HOTEL_DETAILS;
END;
/

declare
  begin
   six_month_hotel;
  end;
  /

2) This procedure gets the names of cities which are visited by the customers
for the given package organized by the particular travel agency.

CREATE OR REPLACE PROCEDURE cities_visited(agencyname IN VARCHAR2, packagename IN VARCHAR2) AS
  CURSOR citiess IS 
    SELECT p.name AS person_name, c1.city_name, a.name AS agency_name, t.tour_name
    FROM customer c, person p, travel_agency a, book_tour b, tour_package t, cities c1, package_cities p1
    WHERE b.package_id = t.package_id AND t.company_id = a.company_id AND a.name = agencyname
    AND t.tour_name = packagename AND c.person_id = b.person_id
    AND c.person_id = p.person_id AND t.package_id = p1.package_id AND p1.city_id = c1.city_id;
  
  cityy citiess%ROWTYPE;
BEGIN
  OPEN citiess;
  
  LOOP
    FETCH citiess INTO cityy;
    EXIT WHEN citiess%NOTFOUND;
    DBMS_OUTPUT.PUT_LINE('Travel agency name: ' || cityy.agency_name || ' and City name: ' || cityy.city_name || ' and Package name: ' || cityy.tour_name || ' and Customer name: ' || cityy.person_name);
  END LOOP;
  
  CLOSE citiess;
END;
/
declare
  begin
   cities_visited('Indian Voyages','Golden Triangle Tour');
  end;
  /


