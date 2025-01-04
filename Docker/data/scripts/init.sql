CREATE TABLE courses (
    id integer NOT NULL,
    name varchar NOT NULL,
    description varchar NOT NULL,
    review integer,
    dateadded timestamptz default now(),
    dateupdated timestamptz default now() NULL,
    CONSTRAINT course_id PRIMARY KEY (id)
);

INSERT INTO courses 
    (id, name, description, review)
VALUES 
    (0, 'English', 'English course', 10)
