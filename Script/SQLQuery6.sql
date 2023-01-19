CREATE DATABASE World;
USE World;
CREATE TABLE city (
    id int  NOT NULL IDENTITY(1,1) ,
    city_name char(128)  NOT NULL,
    lat decimal(9,6)  NOT NULL,
    long decimal(9,6)  NOT NULL,
    CONSTRAINT city_pk PRIMARY KEY (id)
);
CREATE TABLE country (
    id int  NOT NULL IDENTITY(1,1),
    country_name char(128)  NOT NULL,
    country_name_eng char(128)  NOT NULL,
    country_code char(8)  NOT NULL,
    CONSTRAINT country_ak_1 UNIQUE (country_name),
    CONSTRAINT country_ak_2 UNIQUE (country_name_eng),
    CONSTRAINT country_ak_3 UNIQUE (country_code),
    CONSTRAINT country_pk PRIMARY KEY  (id)
);


INSERT INTO country (country_name, country_name_eng, country_code) VALUES ('Deutschland', 'Germany', 'DEU');
INSERT INTO country (country_name, country_name_eng, country_code) VALUES ('Srbija', 'Serbia', 'SRB');
INSERT INTO country (country_name, country_name_eng, country_code) VALUES ('Hrvatska', 'Croatia', 'HRV');
INSERT INTO country (country_name, country_name_eng, country_code) VALUES ('United Stated of America', 'United Stated of America', 'USA');
INSERT INTO country (country_name, country_name_eng, country_code) VALUES ('Polska', 'Poland', 'POL');

INSERT INTO city (city_name, lat, long) VALUES ('Berlin', 52.520008, 13.404954);
INSERT INTO city (city_name, lat, long) VALUES ('Belgrade', 44.787197, 20.457273);
INSERT INTO city (city_name, lat, long) VALUES ('Zagreb', 45.815399, 15.966568);
INSERT INTO city (city_name, lat, long) VALUES ('New York', 40.73061, -73.935242);
INSERT INTO city (city_name, lat, long) VALUES ('Los Angeles', 34.052235, -118.243683);
INSERT INTO city (city_name, lat, long) VALUES ('Warsaw', 52.237049, 21.017532);

SELECT * FROM country;
SELECT * FROM city;
 